namespace Tyuiu.DarychevAA.Task1.V4
{
    partial class MainForm_DAA
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridOutTable_DAA = new DataGridView();
            toolStripActions_DAA = new ToolStrip();
            toolStripButtonOpenFile_DAA = new ToolStripButton();
            toolStripButtonSave_DAA = new ToolStripButton();
            toolStripButtonFilter_DAA = new ToolStripButton();
            toolStripButtonRefreshTable_DAA = new ToolStripButton();
            toolStripTextBoxSearch_DAA = new ToolStripTextBox();
            toolStripLabelSearch = new ToolStripLabel();
            toolStripButtonShowCharts = new ToolStripButton();
            statusStripDataInfo_DAA = new StatusStrip();
            toolStripStatusLabelCountRows_DAA = new ToolStripStatusLabel();
            toolStripStatusLabelSumPrice_DAA = new ToolStripStatusLabel();
            toolStripStatusLabelAvgPrice_DAA = new ToolStripStatusLabel();
            toolStripStatusLabelMinPrice_DAA = new ToolStripStatusLabel();
            toolStripStatusLabelMaxPrice_DAA = new ToolStripStatusLabel();
            saveFileDialogSaveTable_DAA = new SaveFileDialog();
            openFileDialogOpenTable_DAA = new OpenFileDialog();
            buttonChangeToBooks_DAA = new Button();
            buttonChangeToReaders = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridOutTable_DAA).BeginInit();
            toolStripActions_DAA.SuspendLayout();
            statusStripDataInfo_DAA.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridOutTable_DAA
            // 
            dataGridOutTable_DAA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridOutTable_DAA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridOutTable_DAA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridOutTable_DAA.BackgroundColor = SystemColors.ControlLightLight;
            dataGridOutTable_DAA.BorderStyle = BorderStyle.None;
            dataGridOutTable_DAA.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridOutTable_DAA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridOutTable_DAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridOutTable_DAA.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridOutTable_DAA.Location = new Point(0, 67);
            dataGridOutTable_DAA.Margin = new Padding(0);
            dataGridOutTable_DAA.Name = "dataGridOutTable_DAA";
            dataGridOutTable_DAA.RowTemplate.Height = 25;
            dataGridOutTable_DAA.Size = new Size(929, 424);
            dataGridOutTable_DAA.TabIndex = 0;
            dataGridOutTable_DAA.EditingControlShowing += dataGridOutTable_DAA_EditingControlShowing;
            dataGridOutTable_DAA.SelectionChanged += dataGridOutTable_DAA_SelectionChanged;
            // 
            // toolStripActions_DAA
            // 
            toolStripActions_DAA.AutoSize = false;
            toolStripActions_DAA.ImageScalingSize = new Size(24, 24);
            toolStripActions_DAA.Items.AddRange(new ToolStripItem[] { toolStripButtonOpenFile_DAA, toolStripButtonSave_DAA, toolStripButtonFilter_DAA, toolStripButtonRefreshTable_DAA, toolStripTextBoxSearch_DAA, toolStripLabelSearch, toolStripButtonShowCharts });
            toolStripActions_DAA.Location = new Point(0, 0);
            toolStripActions_DAA.Name = "toolStripActions_DAA";
            toolStripActions_DAA.Size = new Size(929, 42);
            toolStripActions_DAA.TabIndex = 3;
            toolStripActions_DAA.Text = "toolStrip1";
            // 
            // toolStripButtonOpenFile_DAA
            // 
            toolStripButtonOpenFile_DAA.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonOpenFile_DAA.Image = Properties.Resources.document_3530;
            toolStripButtonOpenFile_DAA.ImageTransparentColor = Color.Magenta;
            toolStripButtonOpenFile_DAA.Name = "toolStripButtonOpenFile_DAA";
            toolStripButtonOpenFile_DAA.Size = new Size(28, 39);
            toolStripButtonOpenFile_DAA.Text = "toolStripButton1";
            toolStripButtonOpenFile_DAA.ToolTipText = "Open file";
            toolStripButtonOpenFile_DAA.Click += toolStripButtonOpenFile_DAA_Click;
            // 
            // toolStripButtonSave_DAA
            // 
            toolStripButtonSave_DAA.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSave_DAA.Image = Properties.Resources.savetheapplication_guardar_2958;
            toolStripButtonSave_DAA.ImageTransparentColor = Color.Magenta;
            toolStripButtonSave_DAA.Name = "toolStripButtonSave_DAA";
            toolStripButtonSave_DAA.Size = new Size(28, 39);
            toolStripButtonSave_DAA.Text = "Save as DB.csv";
            toolStripButtonSave_DAA.ToolTipText = "Save file";
            toolStripButtonSave_DAA.Click += toolStripButtonSave_DAA_Click;
            // 
            // toolStripButtonFilter_DAA
            // 
            toolStripButtonFilter_DAA.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonFilter_DAA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripButtonFilter_DAA.Image = Properties.Resources.filter_icon_icons_com_64590;
            toolStripButtonFilter_DAA.ImageTransparentColor = Color.Magenta;
            toolStripButtonFilter_DAA.Name = "toolStripButtonFilter_DAA";
            toolStripButtonFilter_DAA.Size = new Size(28, 39);
            toolStripButtonFilter_DAA.Text = "Filter Table";
            toolStripButtonFilter_DAA.Click += toolStripButton1_Click;
            // 
            // toolStripButtonRefreshTable_DAA
            // 
            toolStripButtonRefreshTable_DAA.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonRefreshTable_DAA.Image = Properties.Resources.twocirclingarrows1_120592;
            toolStripButtonRefreshTable_DAA.ImageTransparentColor = Color.Magenta;
            toolStripButtonRefreshTable_DAA.Name = "toolStripButtonRefreshTable_DAA";
            toolStripButtonRefreshTable_DAA.Size = new Size(28, 39);
            toolStripButtonRefreshTable_DAA.Text = "Refresh Table";
            toolStripButtonRefreshTable_DAA.Click += toolStripButtonRefreshTable_DAA_Click;
            // 
            // toolStripTextBoxSearch_DAA
            // 
            toolStripTextBoxSearch_DAA.Alignment = ToolStripItemAlignment.Right;
            toolStripTextBoxSearch_DAA.BorderStyle = BorderStyle.FixedSingle;
            toolStripTextBoxSearch_DAA.Name = "toolStripTextBoxSearch_DAA";
            toolStripTextBoxSearch_DAA.RightToLeft = RightToLeft.No;
            toolStripTextBoxSearch_DAA.Size = new Size(100, 42);
            toolStripTextBoxSearch_DAA.ToolTipText = "Search by Name and Author";
            toolStripTextBoxSearch_DAA.TextChanged += toolStripTextBox1_TextChanged;
            // 
            // toolStripLabelSearch
            // 
            toolStripLabelSearch.Alignment = ToolStripItemAlignment.Right;
            toolStripLabelSearch.Name = "toolStripLabelSearch";
            toolStripLabelSearch.Size = new Size(42, 39);
            toolStripLabelSearch.Text = "Search";
            // 
            // toolStripButtonShowCharts
            // 
            toolStripButtonShowCharts.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonShowCharts.Image = Properties.Resources._1491254488_chartflexibledatestatstatistics_82950;
            toolStripButtonShowCharts.ImageTransparentColor = Color.Magenta;
            toolStripButtonShowCharts.Name = "toolStripButtonShowCharts";
            toolStripButtonShowCharts.Size = new Size(28, 39);
            toolStripButtonShowCharts.Text = "Show Chart";
            toolStripButtonShowCharts.ToolTipText = "Show Charts";
            toolStripButtonShowCharts.Click += toolStripButtonShowCharts_Click;
            // 
            // statusStripDataInfo_DAA
            // 
            statusStripDataInfo_DAA.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelCountRows_DAA, toolStripStatusLabelSumPrice_DAA, toolStripStatusLabelAvgPrice_DAA, toolStripStatusLabelMinPrice_DAA, toolStripStatusLabelMaxPrice_DAA });
            statusStripDataInfo_DAA.Location = new Point(0, 491);
            statusStripDataInfo_DAA.Name = "statusStripDataInfo_DAA";
            statusStripDataInfo_DAA.Size = new Size(929, 22);
            statusStripDataInfo_DAA.TabIndex = 4;
            statusStripDataInfo_DAA.Text = "statusStrip1";
            // 
            // toolStripStatusLabelCountRows_DAA
            // 
            toolStripStatusLabelCountRows_DAA.Name = "toolStripStatusLabelCountRows_DAA";
            toolStripStatusLabelCountRows_DAA.Size = new Size(46, 17);
            toolStripStatusLabelCountRows_DAA.Text = "Count: ";
            // 
            // toolStripStatusLabelSumPrice_DAA
            // 
            toolStripStatusLabelSumPrice_DAA.Name = "toolStripStatusLabelSumPrice_DAA";
            toolStripStatusLabelSumPrice_DAA.Size = new Size(66, 17);
            toolStripStatusLabelSumPrice_DAA.Text = "Price Sum: ";
            // 
            // toolStripStatusLabelAvgPrice_DAA
            // 
            toolStripStatusLabelAvgPrice_DAA.Name = "toolStripStatusLabelAvgPrice_DAA";
            toolStripStatusLabelAvgPrice_DAA.Size = new Size(63, 17);
            toolStripStatusLabelAvgPrice_DAA.Text = "Price Avg: ";
            // 
            // toolStripStatusLabelMinPrice_DAA
            // 
            toolStripStatusLabelMinPrice_DAA.Name = "toolStripStatusLabelMinPrice_DAA";
            toolStripStatusLabelMinPrice_DAA.Size = new Size(63, 17);
            toolStripStatusLabelMinPrice_DAA.Text = "Price Min: ";
            // 
            // toolStripStatusLabelMaxPrice_DAA
            // 
            toolStripStatusLabelMaxPrice_DAA.Name = "toolStripStatusLabelMaxPrice_DAA";
            toolStripStatusLabelMaxPrice_DAA.Size = new Size(62, 17);
            toolStripStatusLabelMaxPrice_DAA.Text = "Price Max:";
            // 
            // saveFileDialogSaveTable_DAA
            // 
            saveFileDialogSaveTable_DAA.Filter = "CSV Files(*.csv)|*.csv";
            // 
            // openFileDialogOpenTable_DAA
            // 
            openFileDialogOpenTable_DAA.CheckFileExists = false;
            openFileDialogOpenTable_DAA.Filter = "CSV Files(*.csv)|*.csv";
            // 
            // buttonChangeToBooks_DAA
            // 
            buttonChangeToBooks_DAA.BackColor = SystemColors.ControlLightLight;
            buttonChangeToBooks_DAA.FlatAppearance.BorderSize = 0;
            buttonChangeToBooks_DAA.FlatStyle = FlatStyle.Flat;
            buttonChangeToBooks_DAA.Location = new Point(0, 42);
            buttonChangeToBooks_DAA.Margin = new Padding(0);
            buttonChangeToBooks_DAA.Name = "buttonChangeToBooks_DAA";
            buttonChangeToBooks_DAA.Size = new Size(75, 25);
            buttonChangeToBooks_DAA.TabIndex = 5;
            buttonChangeToBooks_DAA.Text = "Books";
            buttonChangeToBooks_DAA.UseVisualStyleBackColor = false;
            buttonChangeToBooks_DAA.Click += buttonChangeToBooks_DAA_Click;
            // 
            // buttonChangeToReaders
            // 
            buttonChangeToReaders.FlatAppearance.BorderSize = 0;
            buttonChangeToReaders.FlatStyle = FlatStyle.Flat;
            buttonChangeToReaders.Location = new Point(75, 42);
            buttonChangeToReaders.Margin = new Padding(0);
            buttonChangeToReaders.Name = "buttonChangeToReaders";
            buttonChangeToReaders.Size = new Size(75, 25);
            buttonChangeToReaders.TabIndex = 5;
            buttonChangeToReaders.Text = "Readers";
            buttonChangeToReaders.UseVisualStyleBackColor = true;
            buttonChangeToReaders.Click += buttonChangeToReaders_Click;
            // 
            // MainForm_DAA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(929, 513);
            Controls.Add(buttonChangeToReaders);
            Controls.Add(buttonChangeToBooks_DAA);
            Controls.Add(statusStripDataInfo_DAA);
            Controls.Add(toolStripActions_DAA);
            Controls.Add(dataGridOutTable_DAA);
            Name = "MainForm_DAA";
            ShowIcon = false;
            Text = "Flat File Database";
            ((System.ComponentModel.ISupportInitialize)dataGridOutTable_DAA).EndInit();
            toolStripActions_DAA.ResumeLayout(false);
            toolStripActions_DAA.PerformLayout();
            statusStripDataInfo_DAA.ResumeLayout(false);
            statusStripDataInfo_DAA.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStripActions_DAA;
        private ToolStripButton toolStripButtonFilter_DAA;
        private ToolStripButton toolStripButtonRefreshTable_DAA;
        private ToolStripTextBox toolStripTextBoxSearch_DAA;
        private StatusStrip statusStripDataInfo_DAA;
        private ToolStripStatusLabel toolStripStatusLabelCountRows_DAA;
        private ToolStripStatusLabel toolStripStatusLabelSumPrice_DAA;
        private ToolStripStatusLabel toolStripStatusLabelAvgPrice_DAA;
        private ToolStripStatusLabel toolStripStatusLabelMinPrice_DAA;
        private ToolStripStatusLabel toolStripStatusLabelMaxPrice_DAA;
        private ToolStripLabel toolStripLabelSearch;
        private ToolStripButton toolStripButtonShowCharts;
        private ToolStripButton toolStripButtonSave_DAA;
        private SaveFileDialog saveFileDialogSaveTable_DAA;
        private ToolStripButton toolStripButtonOpenFile_DAA;
        private OpenFileDialog openFileDialogOpenTable_DAA;
        private Button buttonChangeToBooks_DAA;
        private Button buttonChangeToReaders;
        public DataGridView dataGridOutTable_DAA;
    }
}