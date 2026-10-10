namespace Bloatynosy.Views
{
    partial class AppsView
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listBoxRemoval = new System.Windows.Forms.ListBox();
            this.listBoxApps = new System.Windows.Forms.ListBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.textDetails = new System.Windows.Forms.TextBox();
            this.btnUninstall = new System.Windows.Forms.Button();
            this.comboBoxFilters = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnFilter = new System.Windows.Forms.Button();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnClosePaneMirrored = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnRefresh.Location = new System.Drawing.Point(600, 88);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(36, 30);
            this.btnRefresh.TabIndex = 248;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Text = "...";
            this.toolTip.SetToolTip(this.btnRefresh, "Refresh");
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRemove.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnRemove.Location = new System.Drawing.Point(276, 111);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(42, 30);
            this.btnRemove.TabIndex = 255;
            this.btnRemove.TabStop = false;
            this.btnRemove.Text = "-";
            this.toolTip.SetToolTip(this.btnRemove, "Remove");
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnAdd.Location = new System.Drawing.Point(276, 72);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(42, 30);
            this.btnAdd.TabIndex = 254;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "+";
            this.toolTip.SetToolTip(this.btnAdd, "Add");
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listBoxRemoval
            // 
            this.listBoxRemoval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.listBoxRemoval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxRemoval.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBoxRemoval.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F);
            this.listBoxRemoval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.listBoxRemoval.FormattingEnabled = true;
            this.listBoxRemoval.ItemHeight = 17;
            this.listBoxRemoval.Location = new System.Drawing.Point(324, 0);
            this.listBoxRemoval.Name = "listBoxRemoval";
            this.listBoxRemoval.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxRemoval.Size = new System.Drawing.Size(270, 548);
            this.listBoxRemoval.TabIndex = 253;
            // 
            // listBoxApps
            // 
            this.listBoxApps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.listBoxApps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxApps.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxApps.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxApps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.listBoxApps.FormattingEnabled = true;
            this.listBoxApps.ItemHeight = 17;
            this.listBoxApps.Location = new System.Drawing.Point(0, 0);
            this.listBoxApps.Name = "listBoxApps";
            this.listBoxApps.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxApps.Size = new System.Drawing.Size(270, 548);
            this.listBoxApps.Sorted = true;
            this.listBoxApps.TabIndex = 252;
            this.listBoxApps.SelectedIndexChanged += new System.EventHandler(this.listBoxApps_SelectedIndexChanged);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(37, 88);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(247, 39);
            this.lblHeader.TabIndex = 245;
            this.lblHeader.Text = "Dumputer";
            // 
            // textDetails
            // 
            this.textDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textDetails.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F);
            this.textDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.textDetails.Location = new System.Drawing.Point(0, 0);
            this.textDetails.Multiline = true;
            this.textDetails.Name = "textDetails";
            this.textDetails.ReadOnly = true;
            this.textDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textDetails.Size = new System.Drawing.Size(96, 100);
            this.textDetails.TabIndex = 249;
            this.textDetails.Text = "Details about selected app";
            // 
            // btnUninstall
            // 
            this.btnUninstall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUninstall.AutoEllipsis = true;
            this.btnUninstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(203)))));
            this.btnUninstall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUninstall.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnUninstall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.btnUninstall.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUninstall.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnUninstall.ForeColor = System.Drawing.Color.Black;
            this.btnUninstall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUninstall.Location = new System.Drawing.Point(276, 13);
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Size = new System.Drawing.Size(42, 36);
            this.btnUninstall.TabIndex = 200;
            this.btnUninstall.Text = "Remove";
            this.btnUninstall.UseVisualStyleBackColor = false;
            this.btnUninstall.Click += new System.EventHandler(this.btnUninstall_Click);
            // 
            // comboBoxFilters
            // 
            this.comboBoxFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.comboBoxFilters.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxFilters.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxFilters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.comboBoxFilters.FormattingEnabled = true;
            this.comboBoxFilters.Location = new System.Drawing.Point(290, 88);
            this.comboBoxFilters.Name = "comboBoxFilters";
            this.comboBoxFilters.Size = new System.Drawing.Size(248, 29);
            this.comboBoxFilters.TabIndex = 243;
            this.comboBoxFilters.Visible = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F);
            this.textBoxSearch.ForeColor = System.Drawing.Color.Silver;
            this.textBoxSearch.Location = new System.Drawing.Point(155, 19);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(326, 27);
            this.textBoxSearch.TabIndex = 244;
            this.textBoxSearch.Text = "Filter";
            this.textBoxSearch.Click += new System.EventHandler(this.textBoxSearch_Click);
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.toolTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.toolTip.IsBalloon = true;
            this.toolTip.UseAnimation = false;
            this.toolTip.UseFading = false;
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFilter.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            this.btnFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnFilter.Location = new System.Drawing.Point(558, 88);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(36, 30);
            this.btnFilter.TabIndex = 271;
            this.btnFilter.TabStop = false;
            this.btnFilter.Text = "...";
            this.toolTip.SetToolTip(this.btnFilter, "Refresh");
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(203)))));
            this.splitContainer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.splitContainer.Location = new System.Drawing.Point(42, 150);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.panelLeft);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panelRight);
            this.splitContainer.Panel2Collapsed = true;
            this.splitContainer.Size = new System.Drawing.Size(594, 548);
            this.splitContainer.SplitterDistance = 439;
            this.splitContainer.SplitterWidth = 6;
            this.splitContainer.TabIndex = 259;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panelLeft.Controls.Add(this.btnAdd);
            this.panelLeft.Controls.Add(this.btnRemove);
            this.panelLeft.Controls.Add(this.listBoxApps);
            this.panelLeft.Controls.Add(this.listBoxRemoval);
            this.panelLeft.Controls.Add(this.btnUninstall);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(594, 548);
            this.panelLeft.TabIndex = 270;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelRight.Controls.Add(this.textDetails);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.panelRight.Location = new System.Drawing.Point(0, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(96, 100);
            this.panelRight.TabIndex = 270;
            // 
            // btnClosePaneMirrored
            // 
            this.btnClosePaneMirrored.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClosePaneMirrored.BackColor = System.Drawing.Color.Transparent;
            this.btnClosePaneMirrored.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosePaneMirrored.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.btnClosePaneMirrored.FlatAppearance.BorderSize = 0;
            this.btnClosePaneMirrored.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClosePaneMirrored.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            this.btnClosePaneMirrored.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnClosePaneMirrored.Location = new System.Drawing.Point(600, 24);
            this.btnClosePaneMirrored.Name = "btnClosePaneMirrored";
            this.btnClosePaneMirrored.Size = new System.Drawing.Size(36, 30);
            this.btnClosePaneMirrored.TabIndex = 269;
            this.btnClosePaneMirrored.TabStop = false;
            this.btnClosePaneMirrored.Text = "...";
            this.btnClosePaneMirrored.UseMnemonic = false;
            this.btnClosePaneMirrored.UseVisualStyleBackColor = false;
            this.btnClosePaneMirrored.Click += new System.EventHandler(this.btnClosePaneMirrored_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoEllipsis = true;
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(162)))), ((int)(((byte)(26)))));
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 7F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(42, 124);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(16, 14);
            this.lblStatus.TabIndex = 270;
            this.lblStatus.Text = "...";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AppsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnClosePaneMirrored);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.comboBoxFilters);
            this.Font = new System.Drawing.Font("Segoe UI Variable Small Semilig", 9.75F);
            this.Name = "AppsView";
            this.Size = new System.Drawing.Size(680, 740);
            this.Load += new System.EventHandler(this.MainControl_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox textDetails;
        private System.Windows.Forms.Button btnUninstall;
        private System.Windows.Forms.ComboBox comboBoxFilters;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listBoxRemoval;
        private System.Windows.Forms.ListBox listBoxApps;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.SplitContainer splitContainer;
        public System.Windows.Forms.Button btnClosePaneMirrored;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnFilter;
    }
}
