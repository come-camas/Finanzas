namespace Finanzas
{
    partial class Apalancamiento_importe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            airButton1 = new ReaLTaiizor.Controls.AirButton();
            thunderGroupBox1 = new ReaLTaiizor.Controls.ThunderGroupBox();
            spaceBorderLabel1 = new ReaLTaiizor.Controls.SpaceBorderLabel();
            button1 = new ReaLTaiizor.Controls.Button();
            thunderGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // airButton1
            // 
            airButton1.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            airButton1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            airButton1.Image = null;
            airButton1.Location = new Point(849, 609);
            airButton1.Name = "airButton1";
            airButton1.NoRounding = false;
            airButton1.Size = new Size(212, 92);
            airButton1.TabIndex = 0;
            airButton1.Text = "APALANCAMIENTO";
            airButton1.Transparent = false;
            airButton1.Click += airButton1_Click;
            // 
            // thunderGroupBox1
            // 
            thunderGroupBox1.BackColor = Color.Transparent;
            thunderGroupBox1.BodyColorA = Color.FromArgb(26, 26, 26);
            thunderGroupBox1.BodyColorB = Color.FromArgb(30, 30, 30);
            thunderGroupBox1.BodyColorC = Color.FromArgb(46, 46, 46);
            thunderGroupBox1.BodyColorD = Color.FromArgb(50, 55, 58);
            thunderGroupBox1.Controls.Add(spaceBorderLabel1);
            thunderGroupBox1.Controls.Add(button1);
            thunderGroupBox1.ForeColor = Color.WhiteSmoke;
            thunderGroupBox1.Location = new Point(322, 201);
            thunderGroupBox1.Name = "thunderGroupBox1";
            thunderGroupBox1.Size = new Size(345, 267);
            thunderGroupBox1.TabIndex = 3;
            // 
            // spaceBorderLabel1
            // 
            spaceBorderLabel1.Customization = "Kioq/yoqKv/+/v7/IyMj/yoqKv8=";
            spaceBorderLabel1.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
            spaceBorderLabel1.Image = null;
            spaceBorderLabel1.Location = new Point(32, 50);
            spaceBorderLabel1.Name = "spaceBorderLabel1";
            spaceBorderLabel1.NoRounding = false;
            spaceBorderLabel1.Size = new Size(278, 60);
            spaceBorderLabel1.TabIndex = 3;
            spaceBorderLabel1.Text = "ESTADO DE RESULTADO";
            spaceBorderLabel1.TextAlignment = HorizontalAlignment.Center;
            spaceBorderLabel1.Transparent = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BorderColor = Color.FromArgb(32, 34, 37);
            button1.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button1.EnteredColor = Color.FromArgb(32, 34, 37);
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = null;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.InactiveColor = Color.FromArgb(32, 34, 37);
            button1.Location = new Point(77, 167);
            button1.Name = "button1";
            button1.PressedBorderColor = Color.FromArgb(165, 37, 37);
            button1.PressedColor = Color.FromArgb(165, 37, 37);
            button1.Size = new Size(180, 50);
            button1.TabIndex = 3;
            button1.Text = "IMPORTAR";
            button1.TextAlignment = StringAlignment.Center;
            button1.Click += button1_Click;
            // 
            // Apalancamiento_importe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 713);
            Controls.Add(thunderGroupBox1);
            Controls.Add(airButton1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Apalancamiento_importe";
            Text = "Apalancamiento_importe";
            Load += Apalancamiento_importe_Load;
            thunderGroupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.AirButton airButton1;
        private ReaLTaiizor.Controls.ThunderGroupBox thunderGroupBox1;
        private ReaLTaiizor.Controls.SpaceBorderLabel spaceBorderLabel1;
        private ReaLTaiizor.Controls.Button button1;
    }
}