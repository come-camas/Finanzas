using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;
using Finanzas.Clases;
using System.Linq;
using System.Diagnostics.Eventing.Reader;

namespace Finanzas
{
    public partial class Analisis_Horizontal : Form
    {
      
        public Analisis_Horizontal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ESTADOS_RESULTADO();
            mostrar();
            resultado();

            //BALANCE_GENERAL();



        }

        private void mostrar()
        {
            foreach (analisis item in analisis.Lista_analisis_horizontalB)
            {
                if (item != null)
                {
                    MessageBox.Show(item.Cuenta);
                }else
                {
                    MessageBox.Show("no se han encontrado nada");
                }

            }
            
        }

        private void BALANCE_GENERAL()
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
                            analisis analisi = new analisis(worksheet.Cells[i, 1].Text.ToString(), Convert.ToDouble(worksheet.Cells[i, 2].Text), Convert.ToDouble(worksheet.Cells[i, 3].Text));
                            analisis.Lista_analisis_horizontalB.Add(analisi);

                        };
                    }

                    dataGridView1.DataSource = analisis.Lista_analisis_horizontalB;


                }
                catch (IOException)
                {

                    MessageBox.Show("NO SE HA PODIDO REALIZAR LA IMPORTACION DEL ARCHIVO");
                }
            }
        }

        private void resultado()
        {

            if (analisis.Lista_analisis_horizontalE != null)
            {
                var agua = analisis.Lista_analisis_horizontalE.FirstOrDefault(p => p.Cuenta == "activo");
               // var menos = analisis.Lista_analisis_horizontalB.FirstOrDefault(p => p.Cuenta == "activo"); 

                if (agua != null )
                {
                     double fija = Convert.ToDouble(agua._ano1V);
                     double peso = agua._ano2V;
                    

                    MessageBox.Show("la division de estos dos años es: " + (fija / peso));

                }
                else
                {
                    MessageBox.Show("No se han encontrado datos");

                }

            }
            else
            {
                MessageBox.Show("la lista esta vacia");
            }

            




        }



        private void ESTADOS_RESULTADO()
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
                            analisis analisi = new analisis(worksheet.Cells[i, 1].Text, Convert.ToDouble(worksheet.Cells[i, 2].Text), Convert.ToDouble(worksheet.Cells[i, 3].Text));
                            analisis.Lista_analisis_horizontalE.Add(analisi);

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
    }


    
}
    
