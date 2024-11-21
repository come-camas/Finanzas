using System.IO;


namespace Finanzas
{
    public partial class Form1 : Form
    {
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
        }

        private void sidebar__Click(object sender, EventArgs e)
        {
            slidebar_transicion.Start();
        }

        
    }
}
