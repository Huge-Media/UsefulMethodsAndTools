﻿namespace UsefulMethodsAndTools
{
    partial class TestForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tcTest = new System.Windows.Forms.TabControl();
            this.tpDatatoJSON = new System.Windows.Forms.TabPage();
            this.tpOther = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgImportExcel = new System.Windows.Forms.DataGrid();
            this.brnLoadExcel = new System.Windows.Forms.Button();
            this.tcTest.SuspendLayout();
            this.tpDatatoJSON.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgImportExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1018, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Location = new System.Drawing.Point(0, 651);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1018, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tcTest
            // 
            this.tcTest.Controls.Add(this.tpDatatoJSON);
            this.tcTest.Controls.Add(this.tpOther);
            this.tcTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTest.Location = new System.Drawing.Point(0, 24);
            this.tcTest.Name = "tcTest";
            this.tcTest.SelectedIndex = 0;
            this.tcTest.Size = new System.Drawing.Size(1018, 627);
            this.tcTest.TabIndex = 2;
            // 
            // tpDatatoJSON
            // 
            this.tpDatatoJSON.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tpDatatoJSON.Controls.Add(this.splitContainer1);
            this.tpDatatoJSON.Location = new System.Drawing.Point(4, 22);
            this.tpDatatoJSON.Name = "tpDatatoJSON";
            this.tpDatatoJSON.Padding = new System.Windows.Forms.Padding(3);
            this.tpDatatoJSON.Size = new System.Drawing.Size(1010, 601);
            this.tpDatatoJSON.TabIndex = 0;
            this.tpDatatoJSON.Text = "Data to JSON";
            // 
            // tpOther
            // 
            this.tpOther.BackColor = System.Drawing.Color.Honeydew;
            this.tpOther.Location = new System.Drawing.Point(4, 22);
            this.tpOther.Name = "tpOther";
            this.tpOther.Padding = new System.Windows.Forms.Padding(3);
            this.tpOther.Size = new System.Drawing.Size(822, 486);
            this.tpOther.TabIndex = 1;
            this.tpOther.Text = "Other";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgImportExcel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.brnLoadExcel);
            this.splitContainer1.Size = new System.Drawing.Size(1004, 595);
            this.splitContainer1.SplitterDistance = 533;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgImportExcel
            // 
            this.dgImportExcel.DataMember = "";
            this.dgImportExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgImportExcel.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgImportExcel.Location = new System.Drawing.Point(0, 0);
            this.dgImportExcel.Name = "dgImportExcel";
            this.dgImportExcel.Size = new System.Drawing.Size(1004, 533);
            this.dgImportExcel.TabIndex = 0;
            // 
            // brnLoadExcel
            // 
            this.brnLoadExcel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.brnLoadExcel.BackColor = System.Drawing.Color.SeaShell;
            this.brnLoadExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnLoadExcel.Location = new System.Drawing.Point(866, 14);
            this.brnLoadExcel.Name = "brnLoadExcel";
            this.brnLoadExcel.Size = new System.Drawing.Size(123, 30);
            this.brnLoadExcel.TabIndex = 0;
            this.brnLoadExcel.Text = "Учитај Ексел фајл";
            this.brnLoadExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.brnLoadExcel.UseVisualStyleBackColor = false;
            this.brnLoadExcel.Click += new System.EventHandler(this.brnLoadExcel_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 673);
            this.Controls.Add(this.tcTest);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.tcTest.ResumeLayout(false);
            this.tpDatatoJSON.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgImportExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tcTest;
        private System.Windows.Forms.TabPage tpDatatoJSON;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tpOther;
        private System.Windows.Forms.DataGrid dgImportExcel;
        private System.Windows.Forms.Button brnLoadExcel;
    }
}