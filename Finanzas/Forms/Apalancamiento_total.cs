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
    public partial class Apalancamiento_total : Form
    {
        public Apalancamiento_total()
        {
            InitializeComponent();
        }

        private void Apalancamiento_total_Load(object sender, EventArgs e)
        {

            var analisis = Apalancamiento_resultados.lista_resultados_apalancamiento.FirstOrDefault(p => p.apalancamiento_operativo != null);
            double[] valores = { analisis._apalancamientooperativo, analisis._apalancamientofinan, analisis._apalancamientototal };
            formsPlot1.Plot.Add.Bars(valores);
            formsPlot1.Dock = DockStyle.Fill;
            formsPlot1.Plot.Title("Grafica sobre el apalancamiento operativo");
            formsPlot1.Plot.XLabel("  Apalancamiento Operativo                                               Apalancamiento Financiero                                            Apalancamiento Total");




        }
    }
}
