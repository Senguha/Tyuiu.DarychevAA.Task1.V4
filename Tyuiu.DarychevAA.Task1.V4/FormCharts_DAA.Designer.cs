namespace Tyuiu.DarychevAA.Task1.V4
{
    partial class FormCharts_DAA
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
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            SuspendLayout();
            // 
            // cartesianChart1
            // 
            cartesianChart1.BackColor = SystemColors.ControlLightLight;
            cartesianChart1.Dock = DockStyle.Fill;
            cartesianChart1.Location = new Point(0, 0);
            cartesianChart1.Margin = new Padding(0);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(800, 450);
            cartesianChart1.TabIndex = 1;
            // 
            // FormCharts_DAA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cartesianChart1);
            Name = "FormCharts_DAA";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Price Chart";
            Load += FormCharts_DAA_Load;
            ResumeLayout(false);
        }

        #endregion

        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
    }
}