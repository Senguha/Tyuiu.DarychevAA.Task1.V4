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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm_DAA));
            this.dataGridOutTable_DAA = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSaveFile_DAA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpenFile_DAA = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxSearch_DAA = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonFilter_DAA = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRefreshTable_DAA = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOutTable_DAA)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            this.dataGridOutTable_DAA.Location = new System.Drawing.Point(0, 88);
            this.dataGridOutTable_DAA.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridOutTable_DAA.Name = "dataGridOutTable_DAA";
            this.dataGridOutTable_DAA.RowTemplate.Height = 25;
            this.dataGridOutTable_DAA.Size = new System.Drawing.Size(929, 427);
            this.dataGridOutTable_DAA.TabIndex = 0;
            this.dataGridOutTable_DAA.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridOutTable_DAA_EditingControlShowing);
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
            // textBoxSearch_DAA
            // 
            this.textBoxSearch_DAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch_DAA.Location = new System.Drawing.Point(782, 62);
            this.textBoxSearch_DAA.Name = "textBoxSearch_DAA";
            this.textBoxSearch_DAA.Size = new System.Drawing.Size(135, 23);
            this.textBoxSearch_DAA.TabIndex = 2;
            this.textBoxSearch_DAA.TextChanged += new System.EventHandler(this.textBoxSearch_DAA_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonFilter_DAA,
            this.toolStripButtonRefreshTable_DAA});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(929, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonFilter_DAA
            // 
            this.toolStripButtonFilter_DAA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFilter_DAA.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFilter_DAA.Image")));
            this.toolStripButtonFilter_DAA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFilter_DAA.Name = "toolStripButtonFilter_DAA";
            this.toolStripButtonFilter_DAA.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFilter_DAA.Text = "toolStripButton1";
            this.toolStripButtonFilter_DAA.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButtonRefreshTable_DAA
            // 
            this.toolStripButtonRefreshTable_DAA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefreshTable_DAA.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRefreshTable_DAA.Image")));
            this.toolStripButtonRefreshTable_DAA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefreshTable_DAA.Name = "toolStripButtonRefreshTable_DAA";
            this.toolStripButtonRefreshTable_DAA.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRefreshTable_DAA.Text = "toolStripButton1";
            this.toolStripButtonRefreshTable_DAA.Click += new System.EventHandler(this.toolStripButtonRefreshTable_DAA_Click);
            // 
            // MainForm_DAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(929, 513);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textBoxSearch_DAA);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridOutTable_DAA;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItemSaveFile_DAA;
        private ToolStripMenuItem toolStripMenuItemOpenFile_DAA;
        private TextBox textBoxSearch_DAA;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonFilter_DAA;
        private ToolStripButton toolStripButtonRefreshTable_DAA;
    }
}