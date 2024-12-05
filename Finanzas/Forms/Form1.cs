using Finanzas.Forms;
using System.IO;



namespace Finanzas
{
    public partial class Form1 : Form
    {
        Analisis_Horizontal analisi_Horizontal;//ya estsa
        Analisis_Importe analisi_Importe;
        Analisis_Vertical analisi_Vertical; // ya esta
        Apalancamiento_financero apalancamiento_financiero;// ya esta
        Apalancamiento_importe apalancamiento_importe;
        Apalancamiento_total apalancamiento_total;// ya esta
        Apalncamiento_operativo apalancamiento_operativo;//ya esta
        ratios_financieros ratio;
        ayuda Ayudas; // ya esta
       

        public Form1()
        {
            InitializeComponent();
        }

        bool sidebarExpand = true;
        bool menuExpand = false;
        bool menu1Expand = false;

        private void analisis_transicion_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                Analisis_.Height += 10;
                if (Analisis_.Height >= 256)
                {
                    menuExpand = true;
                    analisis_transicion.Stop();

                }
            }
            else
            {
                Analisis_.Height -= 10;
                if (Analisis_.Height <= 86)
                {
                    menuExpand = false;
                    analisis_transicion.Stop();

                }

            }



        }

        private void Analisi__Click(object sender, EventArgs e)
        {
            analisis_transicion.Start();

        }


        private void slidebar_transicion_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand == true)
            {
                sidebar.Width -= 8;

                if (sidebar.Width <= 70)
                {
                    sidebarExpand = false;
                    slidebar_transicion.Stop();

                }


            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 300)
                {
                    sidebarExpand = true;
                    slidebar_transicion.Stop();
                }
            }
        }

        private void apalancamirnto_transicion_Tick(object sender, EventArgs e)
        {
            if (menu1Expand == false)
            {
                apalancamiento_.Height += 10;
                if (apalancamiento_.Height >= 350)
                {
                    menu1Expand = true;
                    apalancamirnto_transicion.Stop();

                }
            }
            else
            {
                apalancamiento_.Height -= 10;
                if (apalancamiento_.Height <= 86)
                {
                    menu1Expand = false;
                    apalancamirnto_transicion.Stop();

                }

            }
        }

        private void apalncamiento_boton_Click(object sender, EventArgs e)
        {
            apalancamirnto_transicion.Start();

            if (apalancamiento_importe == null)
            {
                apalancamiento_importe = new Apalancamiento_importe();
                apalancamiento_importe.FormClosed += Apalancamiento_importe_FormClosed;
                apalancamiento_importe.MdiParent = this;
                apalancamiento_importe.Dock = DockStyle.Fill;
                apalancamiento_importe.Show();

            }else {

                apalancamiento_importe.Activate();            
            }

        }

        private void Apalancamiento_importe_FormClosed(object? sender, FormClosedEventArgs e)
        {
            apalancamiento_importe = null;
        }

        private void sidebar__Click(object sender, EventArgs e)
        {
            slidebar_transicion.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ayuda_boton_Click(object sender, EventArgs e)
        {
            if (Ayudas == null)
            {
                Ayudas = new ayuda();
                Ayudas.FormClosed += Ayudo_FormClosed;
                Ayudas.MdiParent = this;
                Ayudas.Dock = DockStyle.Fill;
                Ayudas.Show();


            }
            else
            {
                Ayudas.Activate();

            }
        }

        private void Ayudo_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Ayudas = null;
        }

        private void analisi_vertical_boton_Click(object sender, EventArgs e)
        {
            if (analisi_Vertical == null)
            {

                analisi_Vertical = new Analisis_Vertical();
                analisi_Vertical.FormClosed += Analisi_Vertical_FormClosed;
                analisi_Vertical.MdiParent = this;
                analisi_Vertical.Dock = DockStyle.Fill;
                analisi_Vertical.Show();

            }
            else
            {
                analisi_Vertical.Activate();
            }
        }

        private void Analisi_Vertical_FormClosed(object? sender, FormClosedEventArgs e)
        {
            analisi_Vertical = null;
        }

        private void analisi_horizontal_boton_Click(object sender, EventArgs e)
        {
            if (analisi_Horizontal == null)
            {
                analisi_Horizontal = new Analisis_Horizontal();
                analisi_Horizontal.FormClosed += Analisi_Horizontal_FormClosed;
                analisi_Horizontal.MdiParent = this;
                analisi_Horizontal.Dock = DockStyle.Fill;
                analisi_Horizontal.Show();

            }
            else { analisi_Horizontal.Activate(); }
        }

        private void Analisi_Horizontal_FormClosed(object? sender, FormClosedEventArgs e)
        {
            analisi_Horizontal = null;
        }

        private void apalancamiento_operativo_boton_Click(object sender, EventArgs e)
        {
            if (apalancamiento_operativo == null)
            {
                apalancamiento_operativo = new Apalncamiento_operativo();
                apalancamiento_operativo.FormClosed += Apalancamiento_operativo_FormClosed;
                apalancamiento_operativo.MdiParent = this;
                apalancamiento_operativo.Dock = DockStyle.Fill;
                apalancamiento_operativo.Show();

            }
            else { apalancamiento_operativo.Activate(); }

            //crear grafico
        }



        private void Apalancamiento_operativo_FormClosed(object? sender, FormClosedEventArgs e)
        {
            apalancamiento_operativo = null;
        }

        private void apalancamiento_total_boton_Click(object sender, EventArgs e)
        {
            if (apalancamiento_total == null)
            {
                apalancamiento_total = new Apalancamiento_total();
                apalancamiento_total.FormClosed += Apalancamiento_total_FormClosed;
                apalancamiento_total.MdiParent = this;
                apalancamiento_total.Dock = DockStyle.Fill;
                apalancamiento_total.Show();

            }
            else
            {
                apalancamiento_total.Activate();
            }
            //crear grafico
        }

        private void Apalancamiento_total_FormClosed(object? sender, FormClosedEventArgs e)
        {
            apalancamiento_total = null;
        }

        private void apalancamiento_financiero_boton_Click(object sender, EventArgs e)
        {
            if (apalancamiento_financiero == null)
            {
                apalancamiento_financiero = new Apalancamiento_financero();
                apalancamiento_financiero.FormClosed += Apalancamiento_financiero_FormClosed;
                apalancamiento_financiero.MdiParent = this;
                apalancamiento_financiero.Dock = DockStyle.Fill;
                apalancamiento_financiero.Show();
            }else { apalancamiento_financiero.Activate(); } 

            //crear grafico
        }

        private void Apalancamiento_financiero_FormClosed(object? sender, FormClosedEventArgs e)
        {
            apalancamiento_financiero = null;
        }

        private void Ratios_financieros_boton_Click(object sender, EventArgs e)
        {
            if (ratio == null)
            {
                ratio = new ratios_financieros();
                ratio.FormClosed += Ratio_FormClosed;
                ratio.MdiParent = this;
                ratio.Dock = DockStyle.Fill;
                ratio.Show();


            }
            else { ratio.Activate(); }
        }

        private void Ratio_FormClosed(object? sender, FormClosedEventArgs e)
        {
            ratio = null;
        }
    }

}
