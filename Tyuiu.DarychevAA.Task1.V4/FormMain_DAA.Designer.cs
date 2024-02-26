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
            this.dataGridOutTable_DAA = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSaveFile_DAA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpenFile_DAA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonFilter_DAA = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRefreshTable_DAA = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxSearch_DAA = new System.Windows.Forms.ToolStripTextBox();
            this.statusStripDataInfo_DAA = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCountRows_DAA = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSumPrice_DAA = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelAvgPrice_DAA = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelMinPrice_DAA = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelMaxPrice_DAA = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOutTable_DAA)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStripDataInfo_DAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridOutTable_DAA
            // 
            this.dataGridOutTable_DAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridOutTable_DAA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridOutTable_DAA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridOutTable_DAA.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridOutTable_DAA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridOutTable_DAA.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridOutTable_DAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOutTable_DAA.Location = new System.Drawing.Point(0, 49);
            this.dataGridOutTable_DAA.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridOutTable_DAA.Name = "dataGridOutTable_DAA";
            this.dataGridOutTable_DAA.RowTemplate.Height = 25;
            this.dataGridOutTable_DAA.Size = new System.Drawing.Size(929, 466);
            this.dataGridOutTable_DAA.TabIndex = 0;
            this.dataGridOutTable_DAA.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridOutTable_DAA_EditingControlShowing);
            this.dataGridOutTable_DAA.SelectionChanged += new System.EventHandler(this.dataGridOutTable_DAA_SelectionChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(929, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSaveFile_DAA,
            this.toolStripMenuItemOpenFile_DAA});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItemSaveFile_DAA
            // 
            this.toolStripMenuItemSaveFile_DAA.Name = "toolStripMenuItemSaveFile_DAA";
            this.toolStripMenuItemSaveFile_DAA.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItemSaveFile_DAA.Text = "Save";
            this.toolStripMenuItemSaveFile_DAA.Click += new System.EventHandler(this.toolStripMenuItemSaveFile_DAA_Click);
            // 
            // toolStripMenuItemOpenFile_DAA
            // 
            this.toolStripMenuItemOpenFile_DAA.Name = "toolStripMenuItemOpenFile_DAA";
            this.toolStripMenuItemOpenFile_DAA.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItemOpenFile_DAA.Text = "Open";
            this.toolStripMenuItemOpenFile_DAA.Click += new System.EventHandler(this.toolStripMenuItemOpenFile_DAA_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonFilter_DAA,
            this.toolStripButtonRefreshTable_DAA,
            this.toolStripTextBoxSearch_DAA});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(929, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonFilter_DAA
            // 
            this.toolStripButtonFilter_DAA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFilter_DAA.Image = global::Tyuiu.DarychevAA.Task1.V4.Properties.Resources.filter_icon_icons_com_64590;
            this.toolStripButtonFilter_DAA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFilter_DAA.Name = "toolStripButtonFilter_DAA";
            this.toolStripButtonFilter_DAA.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFilter_DAA.Text = "Filter";
            this.toolStripButtonFilter_DAA.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButtonRefreshTable_DAA
            // 
            this.toolStripButtonRefreshTable_DAA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefreshTable_DAA.Image = global::Tyuiu.DarychevAA.Task1.V4.Properties.Resources.twocirclingarrows1_120592;
            this.toolStripButtonRefreshTable_DAA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefreshTable_DAA.Name = "toolStripButtonRefreshTable_DAA";
            this.toolStripButtonRefreshTable_DAA.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRefreshTable_DAA.Text = "Refresh";
            this.toolStripButtonRefreshTable_DAA.Click += new System.EventHandler(this.toolStripButtonRefreshTable_DAA_Click);
            // 
            // toolStripTextBoxSearch_DAA
            // 
            this.toolStripTextBoxSearch_DAA.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBoxSearch_DAA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBoxSearch_DAA.Name = "toolStripTextBoxSearch_DAA";
            this.toolStripTextBoxSearch_DAA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripTextBoxSearch_DAA.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBoxSearch_DAA.ToolTipText = "Поиск";
            this.toolStripTextBoxSearch_DAA.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // statusStripDataInfo_DAA
            // 
            this.statusStripDataInfo_DAA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCountRows_DAA,
            this.toolStripStatusLabelSumPrice_DAA,
            this.toolStripStatusLabelAvgPrice_DAA,
            this.toolStripStatusLabelMinPrice_DAA,
            this.toolStripStatusLabelMaxPrice_DAA});
            this.statusStripDataInfo_DAA.Location = new System.Drawing.Point(0, 491);
            this.statusStripDataInfo_DAA.Name = "statusStripDataInfo_DAA";
            this.statusStripDataInfo_DAA.Size = new System.Drawing.Size(929, 22);
            this.statusStripDataInfo_DAA.TabIndex = 4;
            this.statusStripDataInfo_DAA.Text = "statusStrip1";
            // 
            // toolStripStatusLabelCountRows_DAA
            // 
            this.toolStripStatusLabelCountRows_DAA.Name = "toolStripStatusLabelCountRows_DAA";
            this.toolStripStatusLabelCountRows_DAA.Size = new System.Drawing.Size(46, 17);
            this.toolStripStatusLabelCountRows_DAA.Text = "Count: ";
            // 
            // toolStripStatusLabelSumPrice_DAA
            // 
            this.toolStripStatusLabelSumPrice_DAA.Name = "toolStripStatusLabelSumPrice_DAA";
            this.toolStripStatusLabelSumPrice_DAA.Size = new System.Drawing.Size(66, 17);
            this.toolStripStatusLabelSumPrice_DAA.Text = "Price Sum: ";
            // 
            // toolStripStatusLabelAvgPrice_DAA
            // 
            this.toolStripStatusLabelAvgPrice_DAA.Name = "toolStripStatusLabelAvgPrice_DAA";
            this.toolStripStatusLabelAvgPrice_DAA.Size = new System.Drawing.Size(63, 17);
            this.toolStripStatusLabelAvgPrice_DAA.Text = "Price Avg: ";
            // 
            // toolStripStatusLabelMinPrice_DAA
            // 
            this.toolStripStatusLabelMinPrice_DAA.Name = "toolStripStatusLabelMinPrice_DAA";
            this.toolStripStatusLabelMinPrice_DAA.Size = new System.Drawing.Size(63, 17);
            this.toolStripStatusLabelMinPrice_DAA.Text = "Price Min: ";
            // 
            // toolStripStatusLabelMaxPrice_DAA
            // 
            this.toolStripStatusLabelMaxPrice_DAA.Name = "toolStripStatusLabelMaxPrice_DAA";
            this.toolStripStatusLabelMaxPrice_DAA.Size = new System.Drawing.Size(62, 17);
            this.toolStripStatusLabelMaxPrice_DAA.Text = "Price Max:";
            // 
            // MainForm_DAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(929, 513);
            this.Controls.Add(this.statusStripDataInfo_DAA);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridOutTable_DAA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm_DAA";
            this.Text = "Flat File Database";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOutTable_DAA)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStripDataInfo_DAA.ResumeLayout(false);
            this.statusStripDataInfo_DAA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridOutTable_DAA;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItemSaveFile_DAA;
        private ToolStripMenuItem toolStripMenuItemOpenFile_DAA;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonFilter_DAA;
        private ToolStripButton toolStripButtonRefreshTable_DAA;
        private ToolStripTextBox toolStripTextBoxSearch_DAA;
        private StatusStrip statusStripDataInfo_DAA;
        private ToolStripStatusLabel toolStripStatusLabelCountRows_DAA;
        private ToolStripStatusLabel toolStripStatusLabelSumPrice_DAA;
        private ToolStripStatusLabel toolStripStatusLabelAvgPrice_DAA;
        private ToolStripStatusLabel toolStripStatusLabelMinPrice_DAA;
        private ToolStripStatusLabel toolStripStatusLabelMaxPrice_DAA;
    }
}