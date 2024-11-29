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

namespace Finanzas
{
    public partial class Analisis_Vertical : Form
    {
        public Analisis_Vertical()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BALANCE_GENERAL();
            ESTADO_RESULTADO();
            
        }



        private void ESTADO_RESULTADO()
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
                            Analisi_vvertical analisi = new Analisi_vvertical(worksheet.Cells[i, 1].Text, Convert.ToDouble(worksheet.Cells[i, 2].Text));
                            Analisi_vvertical.Lista_analisis_verticalE.Add(analisi);

                        };
                    }

                    dataGridView1.DataSource = Analisi_vvertical.Lista_analisis_verticalE;


                }
                catch (IOException)
                {

                    MessageBox.Show("NO SE HA PODIDO REALIZAR LA IMPORTACION DEL ARCHIVO");
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
                            Analisi_vvertical analisi = new Analisi_vvertical(worksheet.Cells[i, 1].Text, Convert.ToDouble(worksheet.Cells[i, 2].Text));
                            Analisi_vvertical.Lista_analisis_verticalE.Add(analisi);

                        };
                    }

                    dataGridView1.DataSource = Analisi_vvertical.Lista_analisis_verticalE;


                }
                catch (IOException)
                {

                    MessageBox.Show("NO SE HA PODIDO REALIZAR LA IMPORTACION DEL ARCHIVO");
                }
            }

        }
    }
}
