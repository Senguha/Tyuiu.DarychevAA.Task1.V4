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
            this.buttonFilterTable_DAA = new System.Windows.Forms.Button();
            this.comboBoxFilterColumn_DAA = new System.Windows.Forms.ComboBox();
            this.labelSelectedColumn_DAA = new System.Windows.Forms.Label();
            this.labelSelectedOperand_DAA = new System.Windows.Forms.Label();
            this.labelFilterValue_DAA = new System.Windows.Forms.Label();
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
            this.comboBoxFilterAttribite_DAA.Location = new System.Drawing.Point(116, 52);
            this.comboBoxFilterAttribite_DAA.Name = "comboBoxFilterAttribite_DAA";
            this.comboBoxFilterAttribite_DAA.Size = new System.Drawing.Size(95, 23);
            this.comboBoxFilterAttribite_DAA.TabIndex = 0;
            // 
            // textBoxFilterValue_DAA
            // 
            this.textBoxFilterValue_DAA.Location = new System.Drawing.Point(252, 52);
            this.textBoxFilterValue_DAA.Name = "textBoxFilterValue_DAA";
            this.textBoxFilterValue_DAA.Size = new System.Drawing.Size(127, 23);
            this.textBoxFilterValue_DAA.TabIndex = 1;
            // 
            // buttonFilterTable_DAA
            // 
            this.buttonFilterTable_DAA.Location = new System.Drawing.Point(304, 99);
            this.buttonFilterTable_DAA.Name = "buttonFilterTable_DAA";
            this.buttonFilterTable_DAA.Size = new System.Drawing.Size(75, 23);
            this.buttonFilterTable_DAA.TabIndex = 2;
            this.buttonFilterTable_DAA.Text = "Filter";
            this.buttonFilterTable_DAA.UseVisualStyleBackColor = true;
            this.buttonFilterTable_DAA.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxFilterColumn_DAA
            // 
            this.comboBoxFilterColumn_DAA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterColumn_DAA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxFilterColumn_DAA.FormattingEnabled = true;
            this.comboBoxFilterColumn_DAA.Items.AddRange(new object[] {
            "Year",
            "Price"});
            this.comboBoxFilterColumn_DAA.Location = new System.Drawing.Point(12, 52);
            this.comboBoxFilterColumn_DAA.Name = "comboBoxFilterColumn_DAA";
            this.comboBoxFilterColumn_DAA.Size = new System.Drawing.Size(95, 23);
            this.comboBoxFilterColumn_DAA.TabIndex = 0;
            // 
            // labelSelectedColumn_DAA
            // 
            this.labelSelectedColumn_DAA.AutoSize = true;
            this.labelSelectedColumn_DAA.Location = new System.Drawing.Point(12, 34);
            this.labelSelectedColumn_DAA.Name = "labelSelectedColumn_DAA";
            this.labelSelectedColumn_DAA.Size = new System.Drawing.Size(95, 15);
            this.labelSelectedColumn_DAA.TabIndex = 3;
            this.labelSelectedColumn_DAA.Text = "Selected column";
            // 
            // labelSelectedOperand_DAA
            // 
            this.labelSelectedOperand_DAA.AutoSize = true;
            this.labelSelectedOperand_DAA.Location = new System.Drawing.Point(116, 34);
            this.labelSelectedOperand_DAA.Name = "labelSelectedOperand_DAA";
            this.labelSelectedOperand_DAA.Size = new System.Drawing.Size(98, 15);
            this.labelSelectedOperand_DAA.TabIndex = 3;
            this.labelSelectedOperand_DAA.Text = "Selected operand";
            // 
            // labelFilterValue_DAA
            // 
            this.labelFilterValue_DAA.AutoSize = true;
            this.labelFilterValue_DAA.Location = new System.Drawing.Point(252, 34);
            this.labelFilterValue_DAA.Name = "labelFilterValue_DAA";
            this.labelFilterValue_DAA.Size = new System.Drawing.Size(64, 15);
            this.labelFilterValue_DAA.TabIndex = 3;
            this.labelFilterValue_DAA.Text = "Filter value";
            // 
            // FormFilter_DAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 134);
            this.Controls.Add(this.labelFilterValue_DAA);
            this.Controls.Add(this.labelSelectedOperand_DAA);
            this.Controls.Add(this.labelSelectedColumn_DAA);
            this.Controls.Add(this.buttonFilterTable_DAA);
            this.Controls.Add(this.textBoxFilterValue_DAA);
            this.Controls.Add(this.comboBoxFilterColumn_DAA);
            this.Controls.Add(this.comboBoxFilterAttribite_DAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormFilter_DAA";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Filter";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxFilterAttribite_DAA;
        private TextBox textBoxFilterValue_DAA;
        private Button buttonFilterTable_DAA;
        private ComboBox comboBoxFilterColumn_DAA;
        private Label labelSelectedColumn_DAA;
        private Label labelSelectedOperand_DAA;
        private Label labelFilterValue_DAA;
    }
}