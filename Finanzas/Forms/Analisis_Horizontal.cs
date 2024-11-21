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

namespace Finanzas
{
    public partial class Analisis_Horizontal : Form
    {
        List<analisis>analisis_horizontalB=new List<analisis>();
        public Analisis_Horizontal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ESTADOS_RESULTADO();
            resultado();
            //BALANCE_GENERAL();



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
                            analisis analisi = new analisis(worksheet.Cells[i, 1].Text.ToString(), Convert.ToDouble(worksheet.Cells[i, 2].Text), Convert.ToDouble(worksheet.Cells[i, 2].Text));
                            analisis_horizontalB.Add(analisi);

                        };
                    }

                    dataGridView1.DataSource = analisis_horizontalB;


                }
                catch (IOException)
                {

                    MessageBox.Show("NO SE HA PODIDO REALIZAR LA IMPORTACION DEL ARCHIVO");
                }
            }
        }

        private void resultado()
        {



             var agua = analisis_horizontalB.FirstOrDefault(p => p.Cuenta == "activo") ;
            
            // var menos = analisis.Lista_analisis_horizontalB.FirstOrDefault(p => p.Cuenta == "pasivo"); 

            if (agua != null )
            {
                double fija = agua._ano1V;
               // double peso = agua._ano2V;
               
                MessageBox.Show("la division de estos dos a;os es: " + (fija / 1));

            }
            else
            {
                MessageBox.Show("No se han encontrado datos");

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
                            analisis analisi = new analisis(worksheet.Cells[i, 1].Text, Convert.ToDouble(worksheet.Cells[i, 2].Text), Convert.ToDouble(worksheet.Cells[i, 2].Text));
                            analisis.Lista_analisis_horizontalE.Add(analisi);

                        };
                    }

                    dataGridView1.DataSource = analisis.Lista_analisis_horizontalE;



                }
                catch (IOException)
                {

                    MessageBox.Show("NO SE HA PODIDO REALIZAR LA IMPORTACION DEL ARCHIVO");
                }
            }
        }
    }


    
}
    
