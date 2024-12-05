using Finanzas.Clases;
using iTextSharp.text;
using iTextSharp.text.factories;
using iTextSharp.text.pdf;
using Microsoft.VisualBasic;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finanzas
{
    public partial class Apalancamiento_importe : Form
    {
        public Apalancamiento_importe()
        {
            InitializeComponent();
        }

        private void airButton1_Click(object sender, EventArgs e)
        {
            CALCULOS();
            crearreporte();
        }

        private void crearreporte()
        {
            if (!Apalancamiento_resultados.lista_resultados_apalancamiento.Any())
            {
                MessageBox.Show("Hace falta recursos para realilzar el analisis");
            }
            else
            {
                var capital_trabajo = Apalancamiento_resultados.lista_resultados_apalancamiento.FirstOrDefault(p => p.apalancamiento_operativo != null);
                string apal_fi = capital_trabajo._apalancamientofinan.ToString("N4");
                string apal_op = capital_trabajo._apalancamientooperativo.ToString("N4");
                string apal_to = capital_trabajo._apalancamientototal.ToString("N4");

                var ratios = new List<(string Nombre, string Valor)>
                {


                    ("Apalancamiento Operativo",apal_op),
                    ("Apalancamiento Financiero", apal_fi),
                    ("Apalancamiento Total", apal_to),
                 

                     // Aquí no se incluirán valores no calculables
                };


                string directorio = Directory.GetCurrentDirectory();
                string fecha = DateTime.Now.ToString("yyyy/MM/dd");
                string archivo = "Apalancamiento reporte_.pdf";
                string path = Path.Combine(directorio, archivo);


                using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    iTextSharp.text.Document documento = new iTextSharp.text.Document(PageSize.A4);
                    PdfWriter writer = PdfWriter.GetInstance(documento, fs);
                    documento.Open();

                    iTextSharp.text.Font titleFont = FontFactory.GetFont("Arial", 16);
                    Paragraph title = new Paragraph("Reporte de Apalacamiento", titleFont);
                    title.Alignment = Element.ALIGN_CENTER;
                    documento.Add(title);
                    documento.Add(new Paragraph("\n"));

                    PdfPTable table = new PdfPTable(2);
                    table.AddCell("Apalancamiento");
                    table.AddCell("Valor");


                    foreach (var g in ratios) { 
                 
                        if (Convert.ToDouble(g.Valor) != 0)
                        {
                            table.AddCell(g.Nombre);
                            table.AddCell(g.Valor);
                        }

                    }
                    documento.Add(table);

                    documento.Add(new Paragraph("\n"));

                    documento.Add(new Paragraph($"Como podemos apreciar en la tabal los resultados de cada uno de los apalancamiento tales como el " +
                        $"apalancamiento operativo, dandonos a entender que se genero una rentabilidad del {apal_op}% respecto al año anterior, tambien" +
                        $"tenemos el apalancamiento financiero, pudiendo decir que podemos pagar nuestros intereses,impuestos y a nuestros acreedores " +
                        $"preferentes ganando una rentailidad del {apal_fi}%. Y por ultimo ell apalancamiento total, dantonos a entender que la variacion" +
                        $"de las ventas genero una variacion del {apal_op}% representado un {apal_to}% "));
                    


                    documento.Close();
                }

                MessageBox.Show($"el archivo se ha creado exitosamente con el nombre {archivo}");


            }
        }

        private void CALCULOS()
        {
            if (!Apalancamiento.Lista_apalancamiento_E.Any())
            {
                MessageBox.Show("NO SE HA PODIDO REALIZAR EL APALANCAMIENTO POR FALTA DE DATOS");
            }
            else
            {
                //Variaciones
                double variacion_urilidad=0;
                double variacion_ventas=0;
                double variacion_upa = 0;


                //GAO
                var vent = Apalancamiento.Lista_apalancamiento_E.FirstOrDefault(p => p.Cuenta == "UAII");
                var ventas = Apalancamiento.Lista_apalancamiento_E.FirstOrDefault(p => p.Cuenta == "ventas");
                double GAO;
                if (ventas != null)
                {

                    variacion_urilidad = (vent._monto2 - vent._monto) / vent._monto;
                    variacion_ventas = (ventas._monto2 - ventas.Monto_1) / ventas._monto;

                    GAO = (variacion_urilidad / variacion_ventas);



                }
                else
                {
                    MessageBox.Show("No se ha podido realizar el apalancamiento operativo por falta de cuentas");
                    GAO = 0;
                }

                //GAF
                var upas = Apalancamiento.Lista_apalancamiento_E.FirstOrDefault(p => p._cuenta == "UPA");
                double GAF;

                if (upas != null)
                {
                    variacion_upa = (upas._monto2 - upas._monto) / upas._monto;
                    variacion_urilidad = (vent._monto2 - vent._monto) / vent._monto;
                    GAF = (variacion_upa / variacion_urilidad);


                }
                else
                {
                    MessageBox.Show("No se ha podido rea;izar el apalancamiento financiero por falta de cuentas");
                    GAF = 0;
                }

                //GAT
                double GAT;

                if (GAO != 0 && GAF != 0)
                {
                    GAT = GAO * GAF;
                }
                else
                {
                    MessageBox.Show("No se ha podido realizar el apalancamiento total por falta de datos");
                    GAT = 0;
                }

                Apalancamiento_resultados nao = new Apalancamiento_resultados(GAO, GAF, GAT);
                Apalancamiento_resultados.lista_resultados_apalancamiento.Add(nao);

                Variaciones variaciones = new Variaciones(variacion_urilidad,variacion_ventas,variacion_upa);
                Variaciones.lista_variaciones.Add(variaciones);


            }


        }

        private void LEERAPALANCAMIENTO()
        {
            OpenFileDialog import = new OpenFileDialog();
            import.Filter = "Archivos Excel|*.xlsx;*.xlsm";

            if (import.ShowDialog() == DialogResult.OK)
            {
                string archivo = import.FileName;

                try
                {
                    using (var package = new ExcelPackage(new FileInfo(archivo)))
                    {

                        var worksheet = package.Workbook.Worksheets[0];

                        // Leer las filas (comenzando desde la fila 2 si la primera fila tiene encabezados)
                        int filas = worksheet.Dimension.Rows;

                        for (int i = 2; i <= filas; i++) // Comenzamos desde 2 para saltar el encabezado
                        {
                            Apalancamiento apalanca = new Apalancamiento(worksheet.Cells[i, 1].Text, Convert.ToDouble(worksheet.Cells[i, 2].Text), Convert.ToDouble(worksheet.Cells[i, 3].Text));
                            Apalancamiento.Lista_apalancamiento_E.Add(apalanca);

                        };
                    }

                    // dataGridView1.DataSource = analisis.Lista_analisis_horizontalE;



                }
                catch (IOException)
                {

                    MessageBox.Show("NO SE HA PODIDO REALIZAR LA IMPORTACION DEL ARCHIVO");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //LEER APALANCAMIENTO
            LEERAPALANCAMIENTO();
        }

        private void Apalancamiento_importe_Load(object sender, EventArgs e)
        {

        }
    }
}
