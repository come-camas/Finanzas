using Finanzas.Clases;
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
    public partial class Apalancamiento_financero : Form
    {
        public Apalancamiento_financero()
        {
            InitializeComponent();
        }

        private void Apalancamiento_financero_Load(object sender, EventArgs e)
        {

            var analisis = Apalancamiento_resultados.lista_resultados_apalancamiento.FirstOrDefault(p => p.apalancamiento_operativo != null);
            var analiis = Variaciones.lista_variaciones.FirstOrDefault(p => p.Variacion_Ventas != null);
            double[] valores = { analiis._upa, analiis._UAII, analisis._apalancamientofinan };
            formsPlot1.Plot.Add.Bars(valores);
            formsPlot1.Dock = DockStyle.Fill;
            formsPlot1.Plot.Title("Grafica sobre el apalancamiento operativo");
            formsPlot1.Plot.XLabel(" Variacion UPA                                                            Variacion Utilidades                                                   Apalancamiento Financiero");


        }
    }
}
