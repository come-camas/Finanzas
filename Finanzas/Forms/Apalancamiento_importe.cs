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
    public partial class Apalancamiento_importe : Form
    {
        public Apalancamiento_importe()
        {
            InitializeComponent();
        }

        private void airButton1_Click(object sender, EventArgs e)
        {
            LEERAPALANCAMIENTO();
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
                            Apalancamiento apalanca = new Apalancamiento(worksheet.Cells[i, 1].Text, Convert.ToDouble(worksheet.Cells[i, 2].Text));
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
    }
}
