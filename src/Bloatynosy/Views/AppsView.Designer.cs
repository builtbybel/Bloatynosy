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
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblDetails = new System.Windows.Forms.Label();
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
            this.btnBack = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.lblSubHeader = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panelMain.Controls.Add(this.lblDetails);
            this.panelMain.Controls.Add(this.lblSort);
            this.panelMain.Controls.Add(this.btnRefresh);
            this.panelMain.Controls.Add(this.btnRemove);
            this.panelMain.Controls.Add(this.btnAdd);
            this.panelMain.Controls.Add(this.listBoxRemoval);
            this.panelMain.Controls.Add(this.listBoxApps);
            this.panelMain.Controls.Add(this.lblHeader);
            this.panelMain.Controls.Add(this.textDetails);
            this.panelMain.Controls.Add(this.textStatus);
            this.panelMain.Controls.Add(this.btnUninstall);
            this.panelMain.Controls.Add(this.comboBoxFilters);
            this.panelMain.Controls.Add(this.btnBack);
            this.panelMain.Controls.Add(this.textBoxSearch);
            this.panelMain.Controls.Add(this.lblSubHeader);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(711, 600);
            this.panelMain.TabIndex = 251;
            // 
            // lblDetails
            // 
            this.lblDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDetails.AutoEllipsis = true;
            this.lblDetails.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblDetails.ForeColor = System.Drawing.Color.Black;
            this.lblDetails.Location = new System.Drawing.Point(527, 21);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(141, 39);
            this.lblDetails.TabIndex = 257;
            this.lblDetails.Text = "Details about selected app";
            // 
            // lblSort
            // 
            this.lblSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSort.AutoEllipsis = true;
            this.lblSort.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 10.5F);
            this.lblSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSort.Location = new System.Drawing.Point(276, 89);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(52, 21);
            this.lblSort.TabIndex = 256;
            this.lblSort.Text = "Sort";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(260, 217);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(24, 24);
            this.btnRefresh.TabIndex = 248;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Text = "Refresh";
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
            this.btnRemove.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(260, 187);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(24, 24);
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
            this.btnAdd.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(260, 157);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(24, 24);
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
            this.listBoxRemoval.Location = new System.Drawing.Point(290, 157);
            this.listBoxRemoval.Name = "listBoxRemoval";
            this.listBoxRemoval.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxRemoval.Size = new System.Drawing.Size(214, 374);
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
            this.listBoxApps.Location = new System.Drawing.Point(38, 161);
            this.listBoxApps.Name = "listBoxApps";
            this.listBoxApps.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxApps.Size = new System.Drawing.Size(218, 374);
            this.listBoxApps.Sorted = true;
            this.listBoxApps.TabIndex = 252;
            this.listBoxApps.SelectedIndexChanged += new System.EventHandler(this.listBoxApps_SelectedIndexChanged);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.DimGray;
            this.lblHeader.Location = new System.Drawing.Point(33, 21);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(241, 32);
            this.lblHeader.TabIndex = 245;
            this.lblHeader.Text = "Application Dump";
            // 
            // textDetails
            // 
            this.textDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.textDetails.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F);
            this.textDetails.Location = new System.Drawing.Point(530, 63);
            this.textDetails.Multiline = true;
            this.textDetails.Name = "textDetails";
            this.textDetails.ReadOnly = true;
            this.textDetails.Size = new System.Drawing.Size(169, 493);
            this.textDetails.TabIndex = 249;
            // 
            // textStatus
            // 
            this.textStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.textStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textStatus.Font = new System.Drawing.Font("Segoe UI Variable Small Semilig", 9F);
            this.textStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textStatus.Location = new System.Drawing.Point(38, 119);
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(245, 16);
            this.textStatus.TabIndex = 242;
            // 
            // btnUninstall
            // 
            this.btnUninstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUninstall.AutoEllipsis = true;
            this.btnUninstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnUninstall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUninstall.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUninstall.FlatAppearance.BorderSize = 2;
            this.btnUninstall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.btnUninstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUninstall.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F);
            this.btnUninstall.Image = ((System.Drawing.Image)(resources.GetObject("btnUninstall.Image")));
            this.btnUninstall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUninstall.Location = new System.Drawing.Point(530, 562);
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Size = new System.Drawing.Size(169, 27);
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
            this.comboBoxFilters.Location = new System.Drawing.Point(334, 86);
            this.comboBoxFilters.Name = "comboBoxFilters";
            this.comboBoxFilters.Size = new System.Drawing.Size(179, 27);
            this.comboBoxFilters.TabIndex = 243;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(38, 562);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 27);
            this.btnBack.TabIndex = 208;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.25F);
            this.textBoxSearch.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxSearch.Location = new System.Drawing.Point(38, 87);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(216, 26);
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
            this.lblSubHeader.Location = new System.Drawing.Point(35, 53);
            this.lblSubHeader.Name = "lblSubHeader";
            this.lblSubHeader.Size = new System.Drawing.Size(430, 21);
            this.lblSubHeader.TabIndex = 246;
            this.lblSubHeader.Text = "Move apps from the left basket to the right trash can to delete them";
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            this.toolTip.UseAnimation = false;
            this.toolTip.UseFading = false;
            // 
            // AppsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "AppsView";
            this.Size = new System.Drawing.Size(711, 600);
            this.Load += new System.EventHandler(this.MainControl_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox textDetails;
        private System.Windows.Forms.TextBox textStatus;
        private System.Windows.Forms.Button btnUninstall;
        private System.Windows.Forms.ComboBox comboBoxFilters;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label lblSubHeader;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listBoxRemoval;
        private System.Windows.Forms.ListBox listBoxApps;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblSort;
    }
}
