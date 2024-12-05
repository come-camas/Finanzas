using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finanzas.Clases;
using ScottPlot;
using ScottPlot.WinForms;
using ScottPlot.AxisLimitManagers;
using ScottPlot.AxisPanels;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using ScottPlot.Plottables;




namespace Finanzas
{
    public partial class Apalncamiento_operativo : Form
    {
        public Apalncamiento_operativo()
        {
            InitializeComponent();
        }

        private void Apalncamiento_operativo_Load(object sender, EventArgs e)
        {
            
            var analisis = Apalancamiento_resultados.lista_resultados_apalancamiento.FirstOrDefault(p => p.apalancamiento_operativo != null);
            var analiis = Variaciones.lista_variaciones.FirstOrDefault(p => p.Variacion_Ventas != null);
            double[] valores = { analiis._Ventas, analiis._UAII, analisis._apalancamientooperativo };
            formsPlot1.Plot.Add.Bars(valores);
            formsPlot1.Dock = DockStyle.Fill;
            formsPlot1.Plot.Title("Grafica sobre el apalancamiento operativo");
            formsPlot1.Plot.XLabel(" Variacion Ventas                                                     Variacion Utilidades                                                   Apalancamiento Operativo");
            


        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {

        }
    }
}