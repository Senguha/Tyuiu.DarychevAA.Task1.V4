namespace Tyuiu.DarychevAA.Task1.V4
{
    partial class FormFilter_DAA
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
            this.comboBoxFilterAttribite_DAA = new System.Windows.Forms.ComboBox();
            this.textBoxFilterValue_DAA = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxFilterColumn_DAA = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxFilterAttribite_DAA
            // 
            this.comboBoxFilterAttribite_DAA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterAttribite_DAA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxFilterAttribite_DAA.FormattingEnabled = true;
            this.comboBoxFilterAttribite_DAA.Items.AddRange(new object[] {
            ">",
            "<",
            "="});
            this.comboBoxFilterAttribite_DAA.Location = new System.Drawing.Point(100, 52);
            this.comboBoxFilterAttribite_DAA.Name = "comboBoxFilterAttribite_DAA";
            this.comboBoxFilterAttribite_DAA.Size = new System.Drawing.Size(66, 23);
            this.comboBoxFilterAttribite_DAA.TabIndex = 0;
            // 
            // textBoxFilterValue_DAA
            // 
            this.textBoxFilterValue_DAA.Location = new System.Drawing.Point(181, 52);
            this.textBoxFilterValue_DAA.Name = "textBoxFilterValue_DAA";
            this.textBoxFilterValue_DAA.Size = new System.Drawing.Size(156, 23);
            this.textBoxFilterValue_DAA.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxFilterColumn_DAA
            // 
            this.comboBoxFilterColumn_DAA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterColumn_DAA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxFilterColumn_DAA.FormattingEnabled = true;
            this.comboBoxFilterColumn_DAA.Items.AddRange(new object[] {
            "Year",
            "Price"});
            this.comboBoxFilterColumn_DAA.Location = new System.Drawing.Point(28, 52);
            this.comboBoxFilterColumn_DAA.Name = "comboBoxFilterColumn_DAA";
            this.comboBoxFilterColumn_DAA.Size = new System.Drawing.Size(66, 23);
            this.comboBoxFilterColumn_DAA.TabIndex = 0;
            // 
            // FormFilter_DAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 134);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxFilterValue_DAA);
            this.Controls.Add(this.comboBoxFilterColumn_DAA);
            this.Controls.Add(this.comboBoxFilterAttribite_DAA);
            this.Name = "FormFilter_DAA";
            this.Text = "Filter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxFilterAttribite_DAA;
        private TextBox textBoxFilterValue_DAA;
        private Button button1;
        private ComboBox comboBoxFilterColumn_DAA;
    }
}