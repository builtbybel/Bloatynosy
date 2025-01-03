namespace BloatynosyNue.Views
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppsView));
            this.lblSort = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listBoxRemoval = new System.Windows.Forms.ListBox();
            this.listBoxApps = new System.Windows.Forms.ListBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.textDetails = new System.Windows.Forms.TextBox();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.btnUninstall = new System.Windows.Forms.Button();
            this.comboBoxFilters = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.lblSubHeader = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.btnCollapse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSort
            // 
            this.lblSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSort.AutoEllipsis = true;
            this.lblSort.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 10.5F);
            this.lblSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSort.Location = new System.Drawing.Point(386, 81);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(79, 21);
            this.lblSort.TabIndex = 256;
            this.lblSort.Text = "Sort";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(598, 23);
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
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackColor = System.Drawing.Color.White;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            this.btnRemove.ForeColor = System.Drawing.Color.DeepPink;
            this.btnRemove.Location = new System.Drawing.Point(153, 52);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(36, 30);
            this.btnRemove.TabIndex = 255;
            this.btnRemove.TabStop = false;
            this.btnRemove.Text = "-";
            this.toolTip.SetToolTip(this.btnRemove, "Remove");
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            this.btnAdd.ForeColor = System.Drawing.Color.DeepPink;
            this.btnAdd.Location = new System.Drawing.Point(153, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(36, 30);
            this.btnAdd.TabIndex = 254;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "+";
            this.toolTip.SetToolTip(this.btnAdd, "Add");
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listBoxRemoval
            // 
            this.listBoxRemoval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxRemoval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.listBoxRemoval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxRemoval.Font = new System.Drawing.Font("Segoe UI Variable Small Semilig", 9.75F);
            this.listBoxRemoval.FormattingEnabled = true;
            this.listBoxRemoval.ItemHeight = 17;
            this.listBoxRemoval.Location = new System.Drawing.Point(195, 13);
            this.listBoxRemoval.Name = "listBoxRemoval";
            this.listBoxRemoval.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxRemoval.Size = new System.Drawing.Size(246, 391);
            this.listBoxRemoval.TabIndex = 253;
            // 
            // listBoxApps
            // 
            this.listBoxApps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxApps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.listBoxApps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxApps.Font = new System.Drawing.Font("Segoe UI Variable Small Semilig", 9.75F);
            this.listBoxApps.FormattingEnabled = true;
            this.listBoxApps.ItemHeight = 17;
            this.listBoxApps.Location = new System.Drawing.Point(6, 13);
            this.listBoxApps.Name = "listBoxApps";
            this.listBoxApps.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxApps.Size = new System.Drawing.Size(141, 391);
            this.listBoxApps.Sorted = true;
            this.listBoxApps.TabIndex = 252;
            this.listBoxApps.SelectedIndexChanged += new System.EventHandler(this.listBoxApps_SelectedIndexChanged);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(38, 12);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(215, 32);
            this.lblHeader.TabIndex = 245;
            this.lblHeader.Text = "Application Dump";
            // 
            // textDetails
            // 
            this.textDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.textDetails.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F);
            this.textDetails.Location = new System.Drawing.Point(1, 13);
            this.textDetails.Multiline = true;
            this.textDetails.Name = "textDetails";
            this.textDetails.ReadOnly = true;
            this.textDetails.Size = new System.Drawing.Size(158, 400);
            this.textDetails.TabIndex = 249;
            this.textDetails.Text = "Details about selected app";
            // 
            // textStatus
            // 
            this.textStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.textStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textStatus.Font = new System.Drawing.Font("Segoe UI Variable Small Semilig", 9F);
            this.textStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textStatus.Location = new System.Drawing.Point(43, 110);
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(245, 16);
            this.textStatus.TabIndex = 242;
            // 
            // btnUninstall
            // 
            this.btnUninstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUninstall.AutoEllipsis = true;
            this.btnUninstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(0)))), ((int)(((byte)(123)))));
            this.btnUninstall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUninstall.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUninstall.FlatAppearance.BorderSize = 0;
            this.btnUninstall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.btnUninstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUninstall.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F);
            this.btnUninstall.ForeColor = System.Drawing.Color.White;
            this.btnUninstall.Image = ((System.Drawing.Image)(resources.GetObject("btnUninstall.Image")));
            this.btnUninstall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUninstall.Location = new System.Drawing.Point(498, 549);
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Size = new System.Drawing.Size(169, 31);
            this.btnUninstall.TabIndex = 200;
            this.btnUninstall.Text = "Remove";
            this.btnUninstall.UseVisualStyleBackColor = false;
            this.btnUninstall.Click += new System.EventHandler(this.btnUninstall_Click);
            // 
            // comboBoxFilters
            // 
            this.comboBoxFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilters.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.25F);
            this.comboBoxFilters.FormattingEnabled = true;
            this.comboBoxFilters.Location = new System.Drawing.Point(471, 77);
            this.comboBoxFilters.Name = "comboBoxFilters";
            this.comboBoxFilters.Size = new System.Drawing.Size(172, 27);
            this.comboBoxFilters.TabIndex = 243;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.25F);
            this.textBoxSearch.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxSearch.Location = new System.Drawing.Point(43, 78);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(337, 26);
            this.textBoxSearch.TabIndex = 244;
            this.textBoxSearch.Text = "Filter";
            this.textBoxSearch.Click += new System.EventHandler(this.textBoxSearch_Click);
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // lblSubHeader
            // 
            this.lblSubHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubHeader.AutoEllipsis = true;
            this.lblSubHeader.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9.5F);
            this.lblSubHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubHeader.Location = new System.Drawing.Point(40, 44);
            this.lblSubHeader.Name = "lblSubHeader";
            this.lblSubHeader.Size = new System.Drawing.Size(404, 21);
            this.lblSubHeader.TabIndex = 246;
            this.lblSubHeader.Text = "Move apps from the left basket to the right trash can to delete them";
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            this.toolTip.UseAnimation = false;
            this.toolTip.UseFading = false;
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.splitContainer.Location = new System.Drawing.Point(42, 127);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.btnAdd);
            this.splitContainer.Panel1.Controls.Add(this.listBoxRemoval);
            this.splitContainer.Panel1.Controls.Add(this.listBoxApps);
            this.splitContainer.Panel1.Controls.Add(this.btnRemove);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.textDetails);
            this.splitContainer.Size = new System.Drawing.Size(632, 416);
            this.splitContainer.SplitterDistance = 444;
            this.splitContainer.SplitterWidth = 10;
            this.splitContainer.TabIndex = 259;
            // 
            // btnCollapse
            // 
            this.btnCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCollapse.BackColor = System.Drawing.Color.Transparent;
            this.btnCollapse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCollapse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.btnCollapse.FlatAppearance.BorderSize = 0;
            this.btnCollapse.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            this.btnCollapse.ForeColor = System.Drawing.Color.Black;
            this.btnCollapse.Location = new System.Drawing.Point(640, 23);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(36, 30);
            this.btnCollapse.TabIndex = 269;
            this.btnCollapse.TabStop = false;
            this.btnCollapse.Text = "...";
            this.btnCollapse.UseMnemonic = false;
            this.btnCollapse.UseVisualStyleBackColor = false;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // AppsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.btnCollapse);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblSubHeader);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.comboBoxFilters);
            this.Controls.Add(this.btnUninstall);
            this.Controls.Add(this.textStatus);
            this.Font = new System.Drawing.Font("Segoe UI Variable Small Semilig", 9.75F);
            this.Name = "AppsView";
            this.Size = new System.Drawing.Size(711, 600);
            this.Load += new System.EventHandler(this.MainControl_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox textDetails;
        private System.Windows.Forms.TextBox textStatus;
        private System.Windows.Forms.Button btnUninstall;
        private System.Windows.Forms.ComboBox comboBoxFilters;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label lblSubHeader;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listBoxRemoval;
        private System.Windows.Forms.ListBox listBoxApps;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.SplitContainer splitContainer;
        public System.Windows.Forms.Button btnCollapse;
    }
}
