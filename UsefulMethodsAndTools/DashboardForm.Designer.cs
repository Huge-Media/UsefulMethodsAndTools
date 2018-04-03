namespace UsefulMethodsAndTools
{
    partial class DashboardForm
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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpExcel = new System.Windows.Forms.TabPage();
            this.splitContainerExcel = new System.Windows.Forms.SplitContainer();
            this.dgWorkbook = new System.Windows.Forms.DataGrid();
            this.BtnExportLO = new System.Windows.Forms.Button();
            this.BtnExport = new System.Windows.Forms.Button();
            this.BtnImport = new System.Windows.Forms.Button();
            this.tpLanguage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.RbLatin = new System.Windows.Forms.RadioButton();
            this.RbOriginal = new System.Windows.Forms.RadioButton();
            this.tpDtoToPoco = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.rtbPoco = new System.Windows.Forms.RichTextBox();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.dsTest1 = new ClassLibraryUMT.dsTest();
            this.BtnSaveData = new System.Windows.Forms.Button();
            this.BtnChoose = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ofdExcel = new System.Windows.Forms.OpenFileDialog();
            this.testAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcMain.SuspendLayout();
            this.tpExcel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerExcel)).BeginInit();
            this.splitContainerExcel.Panel1.SuspendLayout();
            this.splitContainerExcel.Panel2.SuspendLayout();
            this.splitContainerExcel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgWorkbook)).BeginInit();
            this.tpLanguage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tpDtoToPoco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTest1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpExcel);
            this.tcMain.Controls.Add(this.tpLanguage);
            this.tcMain.Controls.Add(this.tpDtoToPoco);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 24);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(891, 542);
            this.tcMain.TabIndex = 0;
            // 
            // tpExcel
            // 
            this.tpExcel.BackColor = System.Drawing.Color.LightGray;
            this.tpExcel.Controls.Add(this.splitContainerExcel);
            this.tpExcel.Location = new System.Drawing.Point(4, 23);
            this.tpExcel.Name = "tpExcel";
            this.tpExcel.Padding = new System.Windows.Forms.Padding(3);
            this.tpExcel.Size = new System.Drawing.Size(883, 515);
            this.tpExcel.TabIndex = 0;
            this.tpExcel.Text = "Excel Import - Export";
            // 
            // splitContainerExcel
            // 
            this.splitContainerExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerExcel.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerExcel.Location = new System.Drawing.Point(3, 3);
            this.splitContainerExcel.Name = "splitContainerExcel";
            this.splitContainerExcel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerExcel.Panel1
            // 
            this.splitContainerExcel.Panel1.Controls.Add(this.dgWorkbook);
            // 
            // splitContainerExcel.Panel2
            // 
            this.splitContainerExcel.Panel2.Controls.Add(this.BtnExportLO);
            this.splitContainerExcel.Panel2.Controls.Add(this.BtnExport);
            this.splitContainerExcel.Panel2.Controls.Add(this.BtnImport);
            this.splitContainerExcel.Size = new System.Drawing.Size(877, 509);
            this.splitContainerExcel.SplitterDistance = 427;
            this.splitContainerExcel.TabIndex = 0;
            // 
            // dgWorkbook
            // 
            this.dgWorkbook.DataMember = "";
            this.dgWorkbook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgWorkbook.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgWorkbook.Location = new System.Drawing.Point(0, 0);
            this.dgWorkbook.Name = "dgWorkbook";
            this.dgWorkbook.Size = new System.Drawing.Size(877, 427);
            this.dgWorkbook.TabIndex = 0;
            // 
            // BtnExportLO
            // 
            this.BtnExportLO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExportLO.Location = new System.Drawing.Point(555, 16);
            this.BtnExportLO.Name = "BtnExportLO";
            this.BtnExportLO.Size = new System.Drawing.Size(151, 36);
            this.BtnExportLO.TabIndex = 2;
            this.BtnExportLO.Text = "Export LO";
            this.BtnExportLO.UseVisualStyleBackColor = true;
            this.BtnExportLO.Click += new System.EventHandler(this.BtnExportLO_Click);
            // 
            // BtnExport
            // 
            this.BtnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExport.Location = new System.Drawing.Point(712, 16);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(151, 36);
            this.BtnExport.TabIndex = 1;
            this.BtnExport.Text = "Export";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // BtnImport
            // 
            this.BtnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnImport.Location = new System.Drawing.Point(22, 16);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(151, 36);
            this.BtnImport.TabIndex = 0;
            this.BtnImport.Text = "Import";
            this.BtnImport.UseVisualStyleBackColor = true;
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // tpLanguage
            // 
            this.tpLanguage.Controls.Add(this.splitContainer1);
            this.tpLanguage.Location = new System.Drawing.Point(4, 23);
            this.tpLanguage.Name = "tpLanguage";
            this.tpLanguage.Padding = new System.Windows.Forms.Padding(3);
            this.tpLanguage.Size = new System.Drawing.Size(883, 515);
            this.tpLanguage.TabIndex = 1;
            this.tpLanguage.Text = "Language tools";
            this.tpLanguage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel1.Controls.Add(this.RichTextBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.SeaShell;
            this.splitContainer1.Panel2.Controls.Add(this.RbLatin);
            this.splitContainer1.Panel2.Controls.Add(this.RbOriginal);
            this.splitContainer1.Size = new System.Drawing.Size(877, 509);
            this.splitContainer1.SplitterDistance = 428;
            this.splitContainer1.TabIndex = 0;
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.RichTextBox1.Location = new System.Drawing.Point(0, 0);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.Size = new System.Drawing.Size(877, 196);
            this.RichTextBox1.TabIndex = 0;
            this.RichTextBox1.Text = "";
            this.RichTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // RbLatin
            // 
            this.RbLatin.AutoSize = true;
            this.RbLatin.Location = new System.Drawing.Point(167, 29);
            this.RbLatin.Name = "RbLatin";
            this.RbLatin.Size = new System.Drawing.Size(67, 18);
            this.RbLatin.TabIndex = 1;
            this.RbLatin.TabStop = true;
            this.RbLatin.Text = "to Latin";
            this.RbLatin.UseVisualStyleBackColor = true;
            this.RbLatin.CheckedChanged += new System.EventHandler(this.RbLatin_CheckedChanged);
            // 
            // RbOriginal
            // 
            this.RbOriginal.AutoSize = true;
            this.RbOriginal.Location = new System.Drawing.Point(29, 29);
            this.RbOriginal.Name = "RbOriginal";
            this.RbOriginal.Size = new System.Drawing.Size(109, 18);
            this.RbOriginal.TabIndex = 0;
            this.RbOriginal.TabStop = true;
            this.RbOriginal.Text = "Original (Cyrillic)";
            this.RbOriginal.UseVisualStyleBackColor = true;
            this.RbOriginal.CheckedChanged += new System.EventHandler(this.RbOriginal_CheckedChanged);
            // 
            // tpDtoToPoco
            // 
            this.tpDtoToPoco.BackColor = System.Drawing.Color.Honeydew;
            this.tpDtoToPoco.Controls.Add(this.splitContainer2);
            this.tpDtoToPoco.Location = new System.Drawing.Point(4, 23);
            this.tpDtoToPoco.Name = "tpDtoToPoco";
            this.tpDtoToPoco.Size = new System.Drawing.Size(883, 515);
            this.tpDtoToPoco.TabIndex = 2;
            this.tpDtoToPoco.Text = "Dto <-> Poco";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.BtnSaveData);
            this.splitContainer2.Panel2.Controls.Add(this.BtnChoose);
            this.splitContainer2.Size = new System.Drawing.Size(883, 515);
            this.splitContainer2.SplitterDistance = 434;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.rtbPoco);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dataGrid1);
            this.splitContainer3.Size = new System.Drawing.Size(883, 434);
            this.splitContainer3.SplitterDistance = 268;
            this.splitContainer3.TabIndex = 2;
            // 
            // rtbPoco
            // 
            this.rtbPoco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPoco.Location = new System.Drawing.Point(0, 0);
            this.rtbPoco.Name = "rtbPoco";
            this.rtbPoco.Size = new System.Drawing.Size(268, 434);
            this.rtbPoco.TabIndex = 0;
            this.rtbPoco.Text = "";
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "dtAddresssBook";
            this.dataGrid1.DataSource = this.dsTest1;
            this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(0, 0);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(611, 434);
            this.dataGrid1.TabIndex = 1;
            // 
            // dsTest1
            // 
            this.dsTest1.DataSetName = "dsTest";
            this.dsTest1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnSaveData
            // 
            this.BtnSaveData.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnSaveData.Location = new System.Drawing.Point(517, 18);
            this.BtnSaveData.Name = "BtnSaveData";
            this.BtnSaveData.Size = new System.Drawing.Size(131, 30);
            this.BtnSaveData.TabIndex = 1;
            this.BtnSaveData.Text = "Save Data";
            this.BtnSaveData.UseVisualStyleBackColor = true;
            this.BtnSaveData.Click += new System.EventHandler(this.BtnSaveData_Click);
            // 
            // BtnChoose
            // 
            this.BtnChoose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnChoose.Location = new System.Drawing.Point(728, 18);
            this.BtnChoose.Name = "BtnChoose";
            this.BtnChoose.Size = new System.Drawing.Size(131, 30);
            this.BtnChoose.TabIndex = 0;
            this.BtnChoose.Text = "Choose a DataSet";
            this.BtnChoose.UseVisualStyleBackColor = true;
            this.BtnChoose.Click += new System.EventHandler(this.BtnChoose_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testAppToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(891, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 544);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(891, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // testAppToolStripMenuItem
            // 
            this.testAppToolStripMenuItem.Name = "testAppToolStripMenuItem";
            this.testAppToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.testAppToolStripMenuItem.Text = "Test App";
            this.testAppToolStripMenuItem.Click += new System.EventHandler(this.testAppToolStripMenuItem_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 566);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.tcMain.ResumeLayout(false);
            this.tpExcel.ResumeLayout(false);
            this.splitContainerExcel.Panel1.ResumeLayout(false);
            this.splitContainerExcel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerExcel)).EndInit();
            this.splitContainerExcel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgWorkbook)).EndInit();
            this.tpLanguage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tpDtoToPoco.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTest1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpExcel;
        private System.Windows.Forms.TabPage tpLanguage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainerExcel;
        private System.Windows.Forms.DataGrid dgWorkbook;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.Button BtnImport;
        private System.Windows.Forms.OpenFileDialog ofdExcel;
        private System.Windows.Forms.Button BtnExportLO;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox RichTextBox1;
        private System.Windows.Forms.RadioButton RbLatin;
        private System.Windows.Forms.RadioButton RbOriginal;
        private System.Windows.Forms.TabPage tpDtoToPoco;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox rtbPoco;
        private System.Windows.Forms.Button BtnChoose;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.Button BtnSaveData;
        private ClassLibraryUMT.dsTest dsTest1;
        private System.Windows.Forms.ToolStripMenuItem testAppToolStripMenuItem;
    }
}