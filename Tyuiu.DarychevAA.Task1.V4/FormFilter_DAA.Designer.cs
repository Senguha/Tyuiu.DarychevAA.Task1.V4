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
            comboBoxFilterAttribite_DAA = new ComboBox();
            textBoxFilterValue_DAA = new TextBox();
            buttonFilterTable_DAA = new Button();
            comboBoxFilterColumn_DAA = new ComboBox();
            labelSelectedColumn_DAA = new Label();
            labelSelectedOperand_DAA = new Label();
            labelFilterValue_DAA = new Label();
            buttonShowReturnedBooks_DAA = new Button();
            SuspendLayout();
            // 
            // comboBoxFilterAttribite_DAA
            // 
            comboBoxFilterAttribite_DAA.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilterAttribite_DAA.FlatStyle = FlatStyle.System;
            comboBoxFilterAttribite_DAA.FormattingEnabled = true;
            comboBoxFilterAttribite_DAA.Items.AddRange(new object[] { ">", "<", "=" });
            comboBoxFilterAttribite_DAA.Location = new Point(116, 52);
            comboBoxFilterAttribite_DAA.Name = "comboBoxFilterAttribite_DAA";
            comboBoxFilterAttribite_DAA.Size = new Size(95, 23);
            comboBoxFilterAttribite_DAA.TabIndex = 0;
            // 
            // textBoxFilterValue_DAA
            // 
            textBoxFilterValue_DAA.Location = new Point(252, 52);
            textBoxFilterValue_DAA.Name = "textBoxFilterValue_DAA";
            textBoxFilterValue_DAA.Size = new Size(127, 23);
            textBoxFilterValue_DAA.TabIndex = 1;
            // 
            // buttonFilterTable_DAA
            // 
            buttonFilterTable_DAA.Location = new Point(304, 99);
            buttonFilterTable_DAA.Name = "buttonFilterTable_DAA";
            buttonFilterTable_DAA.Size = new Size(75, 23);
            buttonFilterTable_DAA.TabIndex = 2;
            buttonFilterTable_DAA.Text = "Filter";
            buttonFilterTable_DAA.UseVisualStyleBackColor = true;
            buttonFilterTable_DAA.Click += button1_Click;
            // 
            // comboBoxFilterColumn_DAA
            // 
            comboBoxFilterColumn_DAA.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilterColumn_DAA.FlatStyle = FlatStyle.System;
            comboBoxFilterColumn_DAA.FormattingEnabled = true;
            comboBoxFilterColumn_DAA.Items.AddRange(new object[] { "Year", "Price" });
            comboBoxFilterColumn_DAA.Location = new Point(12, 52);
            comboBoxFilterColumn_DAA.Name = "comboBoxFilterColumn_DAA";
            comboBoxFilterColumn_DAA.Size = new Size(95, 23);
            comboBoxFilterColumn_DAA.TabIndex = 0;
            // 
            // labelSelectedColumn_DAA
            // 
            labelSelectedColumn_DAA.AutoSize = true;
            labelSelectedColumn_DAA.Location = new Point(12, 34);
            labelSelectedColumn_DAA.Name = "labelSelectedColumn_DAA";
            labelSelectedColumn_DAA.Size = new Size(95, 15);
            labelSelectedColumn_DAA.TabIndex = 3;
            labelSelectedColumn_DAA.Text = "Selected column";
            // 
            // labelSelectedOperand_DAA
            // 
            labelSelectedOperand_DAA.AutoSize = true;
            labelSelectedOperand_DAA.Location = new Point(116, 34);
            labelSelectedOperand_DAA.Name = "labelSelectedOperand_DAA";
            labelSelectedOperand_DAA.Size = new Size(98, 15);
            labelSelectedOperand_DAA.TabIndex = 3;
            labelSelectedOperand_DAA.Text = "Selected operand";
            // 
            // labelFilterValue_DAA
            // 
            labelFilterValue_DAA.AutoSize = true;
            labelFilterValue_DAA.Location = new Point(252, 34);
            labelFilterValue_DAA.Name = "labelFilterValue_DAA";
            labelFilterValue_DAA.Size = new Size(64, 15);
            labelFilterValue_DAA.TabIndex = 3;
            labelFilterValue_DAA.Text = "Filter value";
            // 
            // buttonShowReturnedBooks_DAA
            // 
            buttonShowReturnedBooks_DAA.Location = new Point(184, 99);
            buttonShowReturnedBooks_DAA.Name = "buttonShowReturnedBooks_DAA";
            buttonShowReturnedBooks_DAA.Size = new Size(114, 23);
            buttonShowReturnedBooks_DAA.TabIndex = 4;
            buttonShowReturnedBooks_DAA.Text = "Returned books";
            buttonShowReturnedBooks_DAA.UseVisualStyleBackColor = true;
            buttonShowReturnedBooks_DAA.Click += buttonShowReturnedBooks_DAA_Click;
            // 
            // FormFilter_DAA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 134);
            Controls.Add(buttonShowReturnedBooks_DAA);
            Controls.Add(labelFilterValue_DAA);
            Controls.Add(labelSelectedOperand_DAA);
            Controls.Add(labelSelectedColumn_DAA);
            Controls.Add(buttonFilterTable_DAA);
            Controls.Add(textBoxFilterValue_DAA);
            Controls.Add(comboBoxFilterColumn_DAA);
            Controls.Add(comboBoxFilterAttribite_DAA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormFilter_DAA";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Filter";
            TopMost = true;
            Load += FormFilter_DAA_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxFilterAttribite_DAA;
        private TextBox textBoxFilterValue_DAA;
        private Button buttonFilterTable_DAA;
        private ComboBox comboBoxFilterColumn_DAA;
        private Label labelSelectedColumn_DAA;
        private Label labelSelectedOperand_DAA;
        private Label labelFilterValue_DAA;
        private Button buttonShowReturnedBooks_DAA;
    }
}