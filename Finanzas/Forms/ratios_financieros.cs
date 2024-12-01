using Finanzas.Clases;
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

namespace Finanzas.Forms
{
    public partial class ratios_financieros : Form
    {
        public ratios_financieros()
        {
            InitializeComponent();
        }

        private void airButton1_Click(object sender, EventArgs e)
        {

            ESTADOS_RESULTADO();
            BALANCEGENERAL();
            calculos();
        }

        private void calculos()
        {

           
        }

        private void BALANCEGENERAL()
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
                            Ratios_Finanacieros ratios = new Ratios_Finanacieros(worksheet.Cells[i, 1].Text, Convert.ToDouble(worksheet.Cells[i, 2].Text));
                            Ratios_Finanacieros.Lista_Ratios_B.Add(ratios);

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
                            Ratios_Finanacieros ratios=new Ratios_Finanacieros(worksheet.Cells[i, 1].Text, Convert.ToDouble(worksheet.Cells[i, 2].Text));
                            Ratios_Finanacieros.Lista_Ratios_E.Add(ratios);

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
