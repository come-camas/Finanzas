namespace Finanzas.Forms
{
    partial class Apalancamiento_financero
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
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1.5F;
            formsPlot1.Location = new Point(425, 286);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(225, 225);
            formsPlot1.TabIndex = 0;
            // 
            // Apalancamiento_financero
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 743);
            Controls.Add(formsPlot1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Apalancamiento_financero";
            Text = "Apalancamiento_financero";
            Load += Apalancamiento_financero_Load;
            ResumeLayout(false);
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot formsPlot1;
    }
}