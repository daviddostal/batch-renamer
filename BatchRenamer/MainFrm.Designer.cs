﻿namespace BatchRenamer
{
    partial class MainFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.layoutTlp = new System.Windows.Forms.TableLayoutPanel();
            this.newFilenamesDgv = new System.Windows.Forms.DataGridView();
            this.oldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.replacePatternTbx = new System.Windows.Forms.TextBox();
            this.findPnl = new System.Windows.Forms.Panel();
            this.fileExtensionsCbx = new System.Windows.Forms.CheckBox();
            this.useRegexCbx = new System.Windows.Forms.CheckBox();
            this.ignoreCaseCbx = new System.Windows.Forms.CheckBox();
            this.findLbl = new System.Windows.Forms.Label();
            this.replacePnl = new System.Windows.Forms.Panel();
            this.replaceLbl = new System.Windows.Forms.Label();
            this.addFilesBtn = new System.Windows.Forms.Button();
            this.renameBtn = new System.Windows.Forms.Button();
            this.statusbarStStrip = new System.Windows.Forms.StatusStrip();
            this.fileCountStLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.selectedCountTsLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.findPatternTbx = new System.Windows.Forms.TextBox();
            this.addFilesOfs = new System.Windows.Forms.OpenFileDialog();
            this.layoutTlp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newFilenamesDgv)).BeginInit();
            this.findPnl.SuspendLayout();
            this.replacePnl.SuspendLayout();
            this.statusbarStStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutTlp
            // 
            this.layoutTlp.ColumnCount = 2;
            this.layoutTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutTlp.Controls.Add(this.newFilenamesDgv, 0, 2);
            this.layoutTlp.Controls.Add(this.replacePatternTbx, 1, 1);
            this.layoutTlp.Controls.Add(this.findPnl, 0, 0);
            this.layoutTlp.Controls.Add(this.replacePnl, 1, 0);
            this.layoutTlp.Controls.Add(this.statusbarStStrip, 0, 3);
            this.layoutTlp.Controls.Add(this.findPatternTbx, 0, 1);
            this.layoutTlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutTlp.Location = new System.Drawing.Point(0, 0);
            this.layoutTlp.Margin = new System.Windows.Forms.Padding(0);
            this.layoutTlp.Name = "layoutTlp";
            this.layoutTlp.RowCount = 4;
            this.layoutTlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutTlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutTlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutTlp.Size = new System.Drawing.Size(683, 453);
            this.layoutTlp.TabIndex = 0;
            // 
            // newFilenamesDgv
            // 
            this.newFilenamesDgv.AllowDrop = true;
            this.newFilenamesDgv.AllowUserToAddRows = false;
            this.newFilenamesDgv.AllowUserToResizeColumns = false;
            this.newFilenamesDgv.AllowUserToResizeRows = false;
            this.newFilenamesDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.newFilenamesDgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.newFilenamesDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newFilenamesDgv.ColumnHeadersHeight = 26;
            this.newFilenamesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.newFilenamesDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oldName,
            this.newName});
            this.layoutTlp.SetColumnSpan(this.newFilenamesDgv, 2);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.newFilenamesDgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.newFilenamesDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newFilenamesDgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.newFilenamesDgv.Location = new System.Drawing.Point(0, 61);
            this.newFilenamesDgv.Margin = new System.Windows.Forms.Padding(0);
            this.newFilenamesDgv.Name = "newFilenamesDgv";
            this.newFilenamesDgv.RowHeadersVisible = false;
            this.newFilenamesDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.newFilenamesDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.newFilenamesDgv.Size = new System.Drawing.Size(683, 370);
            this.newFilenamesDgv.TabIndex = 2;
            this.newFilenamesDgv.CellToolTipTextNeeded += new System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler(this.CellToolTipNeeded);
            this.newFilenamesDgv.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnFileDrop);
            this.newFilenamesDgv.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDragOver);
            // 
            // oldName
            // 
            this.oldName.HeaderText = "Old filename";
            this.oldName.Name = "oldName";
            this.oldName.ReadOnly = true;
            // 
            // newName
            // 
            this.newName.HeaderText = "New filename";
            this.newName.Name = "newName";
            this.newName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // replacePatternTbx
            // 
            this.replacePatternTbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.replacePatternTbx.Location = new System.Drawing.Point(347, 35);
            this.replacePatternTbx.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.replacePatternTbx.Name = "replacePatternTbx";
            this.replacePatternTbx.Size = new System.Drawing.Size(330, 20);
            this.replacePatternTbx.TabIndex = 1;
            // 
            // findPnl
            // 
            this.findPnl.AutoSize = true;
            this.findPnl.Controls.Add(this.fileExtensionsCbx);
            this.findPnl.Controls.Add(this.useRegexCbx);
            this.findPnl.Controls.Add(this.ignoreCaseCbx);
            this.findPnl.Controls.Add(this.findLbl);
            this.findPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.findPnl.Location = new System.Drawing.Point(0, 0);
            this.findPnl.Margin = new System.Windows.Forms.Padding(0);
            this.findPnl.Name = "findPnl";
            this.findPnl.Padding = new System.Windows.Forms.Padding(3);
            this.findPnl.Size = new System.Drawing.Size(341, 35);
            this.findPnl.TabIndex = 4;
            // 
            // fileExtensionsCbx
            // 
            this.fileExtensionsCbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileExtensionsCbx.AutoSize = true;
            this.fileExtensionsCbx.Location = new System.Drawing.Point(240, 10);
            this.fileExtensionsCbx.Name = "fileExtensionsCbx";
            this.fileExtensionsCbx.Size = new System.Drawing.Size(95, 17);
            this.fileExtensionsCbx.TabIndex = 3;
            this.fileExtensionsCbx.Text = "File &extensions";
            this.fileExtensionsCbx.UseVisualStyleBackColor = true;
            // 
            // useRegexCbx
            // 
            this.useRegexCbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.useRegexCbx.AutoSize = true;
            this.useRegexCbx.Location = new System.Drawing.Point(177, 10);
            this.useRegexCbx.Name = "useRegexCbx";
            this.useRegexCbx.Size = new System.Drawing.Size(57, 17);
            this.useRegexCbx.TabIndex = 2;
            this.useRegexCbx.Text = "Rege&x";
            this.useRegexCbx.UseVisualStyleBackColor = true;
            // 
            // ignoreCaseCbx
            // 
            this.ignoreCaseCbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ignoreCaseCbx.AutoSize = true;
            this.ignoreCaseCbx.Location = new System.Drawing.Point(89, 10);
            this.ignoreCaseCbx.Name = "ignoreCaseCbx";
            this.ignoreCaseCbx.Size = new System.Drawing.Size(82, 17);
            this.ignoreCaseCbx.TabIndex = 1;
            this.ignoreCaseCbx.Text = "Ignore &case";
            this.ignoreCaseCbx.UseVisualStyleBackColor = true;
            // 
            // findLbl
            // 
            this.findLbl.AutoSize = true;
            this.findLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.findLbl.Location = new System.Drawing.Point(3, 11);
            this.findLbl.Margin = new System.Windows.Forms.Padding(0);
            this.findLbl.Name = "findLbl";
            this.findLbl.Size = new System.Drawing.Size(35, 13);
            this.findLbl.TabIndex = 4;
            this.findLbl.Text = "Find:";
            this.findLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // replacePnl
            // 
            this.replacePnl.AutoSize = true;
            this.replacePnl.Controls.Add(this.replaceLbl);
            this.replacePnl.Controls.Add(this.addFilesBtn);
            this.replacePnl.Controls.Add(this.renameBtn);
            this.replacePnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.replacePnl.Location = new System.Drawing.Point(341, 0);
            this.replacePnl.Margin = new System.Windows.Forms.Padding(0);
            this.replacePnl.Name = "replacePnl";
            this.replacePnl.Padding = new System.Windows.Forms.Padding(3);
            this.replacePnl.Size = new System.Drawing.Size(342, 35);
            this.replacePnl.TabIndex = 5;
            // 
            // replaceLbl
            // 
            this.replaceLbl.AutoSize = true;
            this.replaceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.replaceLbl.Location = new System.Drawing.Point(3, 11);
            this.replaceLbl.Margin = new System.Windows.Forms.Padding(0);
            this.replaceLbl.Name = "replaceLbl";
            this.replaceLbl.Size = new System.Drawing.Size(85, 13);
            this.replaceLbl.TabIndex = 2;
            this.replaceLbl.Text = "Replace with:";
            this.replaceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addFilesBtn
            // 
            this.addFilesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addFilesBtn.Location = new System.Drawing.Point(163, 6);
            this.addFilesBtn.Name = "addFilesBtn";
            this.addFilesBtn.Size = new System.Drawing.Size(75, 23);
            this.addFilesBtn.TabIndex = 0;
            this.addFilesBtn.Text = "&Add Files";
            this.addFilesBtn.UseVisualStyleBackColor = true;
            this.addFilesBtn.Click += new System.EventHandler(this.OpenFolderClick);
            // 
            // renameBtn
            // 
            this.renameBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.renameBtn.Location = new System.Drawing.Point(244, 6);
            this.renameBtn.Name = "renameBtn";
            this.renameBtn.Size = new System.Drawing.Size(92, 23);
            this.renameBtn.TabIndex = 1;
            this.renameBtn.Text = "&Rename files";
            this.renameBtn.UseVisualStyleBackColor = true;
            this.renameBtn.Click += new System.EventHandler(this.RenameClick);
            // 
            // statusbarStStrip
            // 
            this.layoutTlp.SetColumnSpan(this.statusbarStStrip, 2);
            this.statusbarStStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileCountStLbl,
            this.selectedCountTsLbl});
            this.statusbarStStrip.Location = new System.Drawing.Point(0, 431);
            this.statusbarStStrip.Name = "statusbarStStrip";
            this.statusbarStStrip.Size = new System.Drawing.Size(683, 22);
            this.statusbarStStrip.TabIndex = 3;
            // 
            // fileCountStLbl
            // 
            this.fileCountStLbl.Name = "fileCountStLbl";
            this.fileCountStLbl.Size = new System.Drawing.Size(42, 17);
            this.fileCountStLbl.Text = "Files: 0";
            // 
            // selectedCountTsLbl
            // 
            this.selectedCountTsLbl.Name = "selectedCountTsLbl";
            this.selectedCountTsLbl.Size = new System.Drawing.Size(63, 17);
            this.selectedCountTsLbl.Text = "Selected: 0";
            // 
            // findPatternTbx
            // 
            this.findPatternTbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.findPatternTbx.Location = new System.Drawing.Point(6, 35);
            this.findPatternTbx.Margin = new System.Windows.Forms.Padding(6, 0, 3, 6);
            this.findPatternTbx.Name = "findPatternTbx";
            this.findPatternTbx.Size = new System.Drawing.Size(332, 20);
            this.findPatternTbx.TabIndex = 0;
            // 
            // addFilesOfs
            // 
            this.addFilesOfs.Multiselect = true;
            // 
            // MainFrm
            // 
            this.AcceptButton = this.renameBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 453);
            this.Controls.Add(this.layoutTlp);
            this.MinimumSize = new System.Drawing.Size(635, 256);
            this.Name = "MainFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BatchRenamer";
            this.layoutTlp.ResumeLayout(false);
            this.layoutTlp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newFilenamesDgv)).EndInit();
            this.findPnl.ResumeLayout(false);
            this.findPnl.PerformLayout();
            this.replacePnl.ResumeLayout(false);
            this.replacePnl.PerformLayout();
            this.statusbarStStrip.ResumeLayout(false);
            this.statusbarStStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutTlp;
        private System.Windows.Forms.Panel findPnl;
        private System.Windows.Forms.Label findLbl;
        private System.Windows.Forms.TextBox findPatternTbx;
        private System.Windows.Forms.Panel replacePnl;
        private System.Windows.Forms.Button renameBtn;
        private System.Windows.Forms.DataGridView newFilenamesDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldName;
        private System.Windows.Forms.DataGridViewTextBoxColumn newName;
        private System.Windows.Forms.Button addFilesBtn;
        private System.Windows.Forms.CheckBox fileExtensionsCbx;
        private System.Windows.Forms.CheckBox useRegexCbx;
        private System.Windows.Forms.CheckBox ignoreCaseCbx;
        private System.Windows.Forms.Label replaceLbl;
        private System.Windows.Forms.TextBox replacePatternTbx;
        private System.Windows.Forms.StatusStrip statusbarStStrip;
        private System.Windows.Forms.ToolStripStatusLabel fileCountStLbl;
        private System.Windows.Forms.ToolStripStatusLabel selectedCountTsLbl;
        private System.Windows.Forms.OpenFileDialog addFilesOfs;
    }
}

