namespace Finanzas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            sidebar_ = new PictureBox();
            label1 = new Label();
            panel6 = new Panel();
            Analisi_ = new Button();
            Analisis_ = new FlowLayoutPanel();
            panel12 = new Panel();
            panel10 = new Panel();
            analisi_vertical_boton = new Button();
            panel2 = new Panel();
            analisi_horizontal_boton = new Button();
            ayuda_boton = new Button();
            panel7 = new Panel();
            Ratios_financieros_boton = new Button();
            analisis_transicion = new System.Windows.Forms.Timer(components);
            apalancamiento_ = new FlowLayoutPanel();
            panel11 = new Panel();
            panel13 = new Panel();
            apalncamiento_boton = new Button();
            panel15 = new Panel();
            panel16 = new Panel();
            panel14 = new Panel();
            apalancamiento_operativo_boton = new Button();
            panel19 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            apalancamiento_financiero_boton = new Button();
            panel8 = new Panel();
            apalancamiento_total_boton = new Button();
            slidebar_transicion = new System.Windows.Forms.Timer(components);
            sidebar = new FlowLayoutPanel();
            panel9 = new Panel();
            panel17 = new Panel();
            Salir_boton = new Button();
            apalancamirnto_transicion = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sidebar_).BeginInit();
            panel6.SuspendLayout();
            Analisis_.SuspendLayout();
            panel12.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            apalancamiento_.SuspendLayout();
            panel11.SuspendLayout();
            panel14.SuspendLayout();
            panel19.SuspendLayout();
            panel5.SuspendLayout();
            panel8.SuspendLayout();
            sidebar.SuspendLayout();
            panel9.SuspendLayout();
            panel17.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(sidebar_);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1478, 50);
            panel1.TabIndex = 0;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(1339, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 1;
            // 
            // sidebar_
            // 
            sidebar_.Image = (Image)resources.GetObject("sidebar_.Image");
            sidebar_.Location = new Point(12, 12);
            sidebar_.Name = "sidebar_";
            sidebar_.Size = new Size(49, 32);
            sidebar_.SizeMode = PictureBoxSizeMode.CenterImage;
            sidebar_.TabIndex = 1;
            sidebar_.TabStop = false;
            sidebar_.Click += sidebar__Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(67, 9);
            label1.Name = "label1";
            label1.Size = new Size(222, 28);
            label1.TabIndex = 1;
            label1.Text = "ANALISIS FINANCIEROS";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(32, 33, 36);
            panel6.Controls.Add(Analisi_);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(300, 86);
            panel6.TabIndex = 6;
            // 
            // Analisi_
            // 
            Analisi_.BackColor = Color.FromArgb(23, 24, 29);
            Analisi_.FlatStyle = FlatStyle.Flat;
            Analisi_.ForeColor = Color.White;
            Analisi_.Image = (Image)resources.GetObject("Analisi_.Image");
            Analisi_.ImageAlign = ContentAlignment.MiddleLeft;
            Analisi_.Location = new Point(-12, -12);
            Analisi_.Name = "Analisi_";
            Analisi_.Padding = new Padding(25, 0, 0, 0);
            Analisi_.Size = new Size(327, 114);
            Analisi_.TabIndex = 3;
            Analisi_.Text = "         Analisis";
            Analisi_.TextAlign = ContentAlignment.MiddleLeft;
            Analisi_.UseVisualStyleBackColor = false;
            Analisi_.Click += Analisi__Click;
            // 
            // Analisis_
            // 
            Analisis_.BackColor = Color.FromArgb(32, 33, 36);
            Analisis_.Controls.Add(panel6);
            Analisis_.Controls.Add(panel12);
            Analisis_.Controls.Add(panel2);
            Analisis_.Location = new Point(0, 86);
            Analisis_.Margin = new Padding(0);
            Analisis_.Name = "Analisis_";
            Analisis_.Size = new Size(300, 86);
            Analisis_.TabIndex = 5;
            // 
            // panel12
            // 
            panel12.Controls.Add(panel10);
            panel12.Controls.Add(analisi_vertical_boton);
            panel12.Location = new Point(0, 92);
            panel12.Margin = new Padding(0);
            panel12.Name = "panel12";
            panel12.Size = new Size(300, 86);
            panel12.TabIndex = 7;
            // 
            // panel10
            // 
            panel10.Location = new Point(0, 86);
            panel10.Margin = new Padding(0);
            panel10.Name = "panel10";
            panel10.Size = new Size(289, 86);
            panel10.TabIndex = 7;
            // 
            // analisi_vertical_boton
            // 
            analisi_vertical_boton.AutoSize = true;
            analisi_vertical_boton.BackColor = Color.FromArgb(32, 33, 36);
            analisi_vertical_boton.FlatStyle = FlatStyle.Flat;
            analisi_vertical_boton.ForeColor = Color.White;
            analisi_vertical_boton.Image = (Image)resources.GetObject("analisi_vertical_boton.Image");
            analisi_vertical_boton.ImageAlign = ContentAlignment.MiddleLeft;
            analisi_vertical_boton.Location = new Point(-12, -16);
            analisi_vertical_boton.Margin = new Padding(0);
            analisi_vertical_boton.Name = "analisi_vertical_boton";
            analisi_vertical_boton.Padding = new Padding(30, 0, 0, 0);
            analisi_vertical_boton.Size = new Size(322, 108);
            analisi_vertical_boton.TabIndex = 3;
            analisi_vertical_boton.Text = "         Vertical";
            analisi_vertical_boton.TextAlign = ContentAlignment.MiddleLeft;
            analisi_vertical_boton.UseVisualStyleBackColor = false;
            analisi_vertical_boton.Click += analisi_vertical_boton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(analisi_horizontal_boton);
            panel2.Location = new Point(3, 181);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 86);
            panel2.TabIndex = 12;
            // 
            // analisi_horizontal_boton
            // 
            analisi_horizontal_boton.AutoSize = true;
            analisi_horizontal_boton.BackColor = Color.FromArgb(32, 33, 36);
            analisi_horizontal_boton.FlatStyle = FlatStyle.Flat;
            analisi_horizontal_boton.ForeColor = Color.White;
            analisi_horizontal_boton.Image = (Image)resources.GetObject("analisi_horizontal_boton.Image");
            analisi_horizontal_boton.ImageAlign = ContentAlignment.MiddleLeft;
            analisi_horizontal_boton.Location = new Point(-15, -24);
            analisi_horizontal_boton.Name = "analisi_horizontal_boton";
            analisi_horizontal_boton.Padding = new Padding(30, 0, 0, 0);
            analisi_horizontal_boton.Size = new Size(323, 114);
            analisi_horizontal_boton.TabIndex = 3;
            analisi_horizontal_boton.Text = "          Horizontal";
            analisi_horizontal_boton.TextAlign = ContentAlignment.MiddleLeft;
            analisi_horizontal_boton.UseVisualStyleBackColor = false;
            analisi_horizontal_boton.Click += analisi_horizontal_boton_Click;
            // 
            // ayuda_boton
            // 
            ayuda_boton.BackColor = Color.FromArgb(23, 24, 29);
            ayuda_boton.FlatStyle = FlatStyle.Flat;
            ayuda_boton.ForeColor = Color.White;
            ayuda_boton.Image = (Image)resources.GetObject("ayuda_boton.Image");
            ayuda_boton.ImageAlign = ContentAlignment.MiddleLeft;
            ayuda_boton.Location = new Point(-9, -10);
            ayuda_boton.Name = "ayuda_boton";
            ayuda_boton.Padding = new Padding(25, 0, 0, 0);
            ayuda_boton.Size = new Size(320, 107);
            ayuda_boton.TabIndex = 3;
            ayuda_boton.Text = "         Ayuda";
            ayuda_boton.TextAlign = ContentAlignment.MiddleLeft;
            ayuda_boton.UseVisualStyleBackColor = false;
            ayuda_boton.Click += ayuda_boton_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(ayuda_boton);
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(300, 86);
            panel7.TabIndex = 6;
            // 
            // Ratios_financieros_boton
            // 
            Ratios_financieros_boton.BackColor = Color.FromArgb(23, 24, 29);
            Ratios_financieros_boton.FlatStyle = FlatStyle.Flat;
            Ratios_financieros_boton.ForeColor = Color.White;
            Ratios_financieros_boton.Image = (Image)resources.GetObject("Ratios_financieros_boton.Image");
            Ratios_financieros_boton.ImageAlign = ContentAlignment.MiddleLeft;
            Ratios_financieros_boton.Location = new Point(-12, -17);
            Ratios_financieros_boton.Name = "Ratios_financieros_boton";
            Ratios_financieros_boton.Padding = new Padding(25, 0, 0, 0);
            Ratios_financieros_boton.Size = new Size(330, 107);
            Ratios_financieros_boton.TabIndex = 3;
            Ratios_financieros_boton.Text = "          Ratios Financieros";
            Ratios_financieros_boton.TextAlign = ContentAlignment.MiddleLeft;
            Ratios_financieros_boton.UseVisualStyleBackColor = false;
            Ratios_financieros_boton.Click += Ratios_financieros_boton_Click;
            // 
            // analisis_transicion
            // 
            analisis_transicion.Interval = 20;
            analisis_transicion.Tick += analisis_transicion_Tick;
            // 
            // apalancamiento_
            // 
            apalancamiento_.BackColor = Color.FromArgb(32, 33, 36);
            apalancamiento_.Controls.Add(panel11);
            apalancamiento_.Controls.Add(panel14);
            apalancamiento_.Controls.Add(panel5);
            apalancamiento_.Controls.Add(panel8);
            apalancamiento_.Location = new Point(3, 175);
            apalancamiento_.Name = "apalancamiento_";
            apalancamiento_.Size = new Size(300, 86);
            apalancamiento_.TabIndex = 10;
            // 
            // panel11
            // 
            panel11.Controls.Add(panel13);
            panel11.Controls.Add(apalncamiento_boton);
            panel11.Controls.Add(panel15);
            panel11.Controls.Add(panel16);
            panel11.Location = new Point(0, 0);
            panel11.Margin = new Padding(0);
            panel11.Name = "panel11";
            panel11.Size = new Size(300, 86);
            panel11.TabIndex = 5;
            // 
            // panel13
            // 
            panel13.Location = new Point(0, 92);
            panel13.Name = "panel13";
            panel13.Size = new Size(289, 84);
            panel13.TabIndex = 7;
            // 
            // apalncamiento_boton
            // 
            apalncamiento_boton.BackColor = Color.FromArgb(23, 24, 29);
            apalncamiento_boton.FlatStyle = FlatStyle.Flat;
            apalncamiento_boton.ForeColor = Color.White;
            apalncamiento_boton.Image = (Image)resources.GetObject("apalncamiento_boton.Image");
            apalncamiento_boton.ImageAlign = ContentAlignment.MiddleLeft;
            apalncamiento_boton.Location = new Point(-15, -10);
            apalncamiento_boton.Margin = new Padding(0);
            apalncamiento_boton.Name = "apalncamiento_boton";
            apalncamiento_boton.Padding = new Padding(25, 0, 0, 15);
            apalncamiento_boton.Size = new Size(320, 116);
            apalncamiento_boton.TabIndex = 3;
            apalncamiento_boton.Text = "         Apalancamiento";
            apalncamiento_boton.TextAlign = ContentAlignment.MiddleLeft;
            apalncamiento_boton.UseVisualStyleBackColor = false;
            apalncamiento_boton.Click += apalncamiento_boton_Click;
            // 
            // panel15
            // 
            panel15.Location = new Point(0, 83);
            panel15.Name = "panel15";
            panel15.Size = new Size(300, 86);
            panel15.TabIndex = 6;
            // 
            // panel16
            // 
            panel16.Location = new Point(0, 68);
            panel16.Name = "panel16";
            panel16.Size = new Size(300, 86);
            panel16.TabIndex = 6;
            // 
            // panel14
            // 
            panel14.Controls.Add(apalancamiento_operativo_boton);
            panel14.Controls.Add(panel19);
            panel14.Location = new Point(0, 86);
            panel14.Margin = new Padding(0);
            panel14.Name = "panel14";
            panel14.Size = new Size(300, 86);
            panel14.TabIndex = 7;
            // 
            // apalancamiento_operativo_boton
            // 
            apalancamiento_operativo_boton.AutoSize = true;
            apalancamiento_operativo_boton.BackColor = Color.FromArgb(32, 33, 36);
            apalancamiento_operativo_boton.FlatStyle = FlatStyle.Flat;
            apalancamiento_operativo_boton.ForeColor = Color.White;
            apalancamiento_operativo_boton.Image = (Image)resources.GetObject("apalancamiento_operativo_boton.Image");
            apalancamiento_operativo_boton.ImageAlign = ContentAlignment.MiddleLeft;
            apalancamiento_operativo_boton.Location = new Point(-6, -18);
            apalancamiento_operativo_boton.Margin = new Padding(0);
            apalancamiento_operativo_boton.Name = "apalancamiento_operativo_boton";
            apalancamiento_operativo_boton.Padding = new Padding(25, 0, 0, 0);
            apalancamiento_operativo_boton.Size = new Size(317, 108);
            apalancamiento_operativo_boton.TabIndex = 3;
            apalancamiento_operativo_boton.Text = "        Operativo";
            apalancamiento_operativo_boton.TextAlign = ContentAlignment.MiddleLeft;
            apalancamiento_operativo_boton.UseVisualStyleBackColor = false;
            apalancamiento_operativo_boton.Click += apalancamiento_operativo_boton_Click;
            // 
            // panel19
            // 
            panel19.Controls.Add(panel3);
            panel19.Location = new Point(0, 64);
            panel19.Name = "panel19";
            panel19.Size = new Size(300, 86);
            panel19.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 86);
            panel3.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.Controls.Add(apalancamiento_financiero_boton);
            panel5.Location = new Point(3, 175);
            panel5.Name = "panel5";
            panel5.Size = new Size(300, 86);
            panel5.TabIndex = 6;
            // 
            // apalancamiento_financiero_boton
            // 
            apalancamiento_financiero_boton.AutoSize = true;
            apalancamiento_financiero_boton.BackColor = Color.FromArgb(32, 33, 36);
            apalancamiento_financiero_boton.FlatStyle = FlatStyle.Flat;
            apalancamiento_financiero_boton.ForeColor = Color.White;
            apalancamiento_financiero_boton.Image = (Image)resources.GetObject("apalancamiento_financiero_boton.Image");
            apalancamiento_financiero_boton.ImageAlign = ContentAlignment.MiddleLeft;
            apalancamiento_financiero_boton.Location = new Point(-9, -9);
            apalancamiento_financiero_boton.Name = "apalancamiento_financiero_boton";
            apalancamiento_financiero_boton.Padding = new Padding(25, 0, 0, 0);
            apalancamiento_financiero_boton.Size = new Size(311, 105);
            apalancamiento_financiero_boton.TabIndex = 3;
            apalancamiento_financiero_boton.Text = "         Financiero";
            apalancamiento_financiero_boton.TextAlign = ContentAlignment.MiddleLeft;
            apalancamiento_financiero_boton.UseVisualStyleBackColor = false;
            apalancamiento_financiero_boton.Click += apalancamiento_financiero_boton_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(apalancamiento_total_boton);
            panel8.Location = new Point(3, 267);
            panel8.Name = "panel8";
            panel8.Size = new Size(300, 86);
            panel8.TabIndex = 6;
            // 
            // apalancamiento_total_boton
            // 
            apalancamiento_total_boton.AutoSize = true;
            apalancamiento_total_boton.BackColor = Color.FromArgb(32, 33, 36);
            apalancamiento_total_boton.FlatStyle = FlatStyle.Flat;
            apalancamiento_total_boton.ForeColor = Color.White;
            apalancamiento_total_boton.Image = (Image)resources.GetObject("apalancamiento_total_boton.Image");
            apalancamiento_total_boton.ImageAlign = ContentAlignment.MiddleLeft;
            apalancamiento_total_boton.Location = new Point(-9, -37);
            apalancamiento_total_boton.Name = "apalancamiento_total_boton";
            apalancamiento_total_boton.Padding = new Padding(25, 0, 0, 0);
            apalancamiento_total_boton.Size = new Size(309, 139);
            apalancamiento_total_boton.TabIndex = 13;
            apalancamiento_total_boton.Text = "         Total";
            apalancamiento_total_boton.TextAlign = ContentAlignment.MiddleLeft;
            apalancamiento_total_boton.UseVisualStyleBackColor = false;
            apalancamiento_total_boton.Click += apalancamiento_total_boton_Click;
            // 
            // slidebar_transicion
            // 
            slidebar_transicion.Interval = 10;
            slidebar_transicion.Tick += slidebar_transicion_Tick;
            // 
            // sidebar
            // 
            sidebar.AutoScroll = true;
            sidebar.BackColor = Color.FromArgb(23, 24, 29);
            sidebar.Controls.Add(panel7);
            sidebar.Controls.Add(Analisis_);
            sidebar.Controls.Add(apalancamiento_);
            sidebar.Controls.Add(panel9);
            sidebar.Controls.Add(panel17);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 50);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(300, 879);
            sidebar.TabIndex = 11;
            // 
            // panel9
            // 
            panel9.Controls.Add(Ratios_financieros_boton);
            panel9.Location = new Point(3, 267);
            panel9.Name = "panel9";
            panel9.Size = new Size(300, 86);
            panel9.TabIndex = 17;
            // 
            // panel17
            // 
            panel17.Controls.Add(Salir_boton);
            panel17.Location = new Point(3, 359);
            panel17.Name = "panel17";
            panel17.Size = new Size(300, 86);
            panel17.TabIndex = 6;
            // 
            // Salir_boton
            // 
            Salir_boton.BackColor = Color.FromArgb(23, 24, 29);
            Salir_boton.FlatStyle = FlatStyle.Flat;
            Salir_boton.ForeColor = Color.White;
            Salir_boton.Image = (Image)resources.GetObject("Salir_boton.Image");
            Salir_boton.ImageAlign = ContentAlignment.MiddleLeft;
            Salir_boton.Location = new Point(-7, -6);
            Salir_boton.Name = "Salir_boton";
            Salir_boton.Padding = new Padding(25, 0, 0, 0);
            Salir_boton.Size = new Size(325, 107);
            Salir_boton.TabIndex = 17;
            Salir_boton.Text = "          Salir";
            Salir_boton.TextAlign = ContentAlignment.MiddleLeft;
            Salir_boton.UseVisualStyleBackColor = false;
            // 
            // apalancamirnto_transicion
            // 
            apalancamirnto_transicion.Interval = 20;
            apalancamirnto_transicion.Tick += apalancamirnto_transicion_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 929);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sidebar_).EndInit();
            panel6.ResumeLayout(false);
            Analisis_.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel7.ResumeLayout(false);
            apalancamiento_.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel19.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            sidebar.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel17.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox sidebar_;
        private Label label1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Button ayuda_boton;
        private FlowLayoutPanel Analisis_;
        private Panel panel7;
        private Panel panel6;
        private Panel panel10;
        private Button Analisi_;
        private Button Ratios_financieros_boton;
        private System.Windows.Forms.Timer analisis_transicion;
        private Panel panel12;
        private Button analisi_vertical_boton;
        private Button analisi_horizontal_boton;
        private FlowLayoutPanel apalancamiento_;
        private Panel panel11;
        private Panel panel13;
        private Button apalncamiento_boton;
        private Panel panel14;
        private Button apalancamiento_operativo_boton;
        private Panel panel19;
        private Button apalancamiento_financiero_boton;
        private System.Windows.Forms.Timer slidebar_transicion;
        private FlowLayoutPanel sidebar;
        private Panel panel2;
        private Panel panel3;
        private Button apalancamiento_total_boton;
        private Panel panel5;
        private Panel panel8;
        private System.Windows.Forms.Timer apalancamirnto_transicion;
        private Panel panel9;
        private Panel panel15;
        private Button Salir_boton;
        private Panel panel16;
        private Panel panel17;
    }
}
