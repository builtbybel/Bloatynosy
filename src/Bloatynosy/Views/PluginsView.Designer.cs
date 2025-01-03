namespace BloatynosyNue.Views
{
    partial class PluginsView
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
            this.panelPlugins = new System.Windows.Forms.Panel();
            this.treePlugins = new System.Windows.Forms.TreeView();
            this.lblInstalled = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnDonate = new System.Windows.Forms.Button();
            this.btnPluginStore = new System.Windows.Forms.Button();
            this.lblSubHeader = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnPluginsDir = new System.Windows.Forms.Button();
            this.panelPlugins.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPlugins
            // 
            this.panelPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPlugins.Controls.Add(this.treePlugins);
            this.panelPlugins.Controls.Add(this.lblInstalled);
            this.panelPlugins.Location = new System.Drawing.Point(19, 215);
            this.panelPlugins.Margin = new System.Windows.Forms.Padding(4);
            this.panelPlugins.Name = "panelPlugins";
            this.panelPlugins.Size = new System.Drawing.Size(675, 315);
            this.panelPlugins.TabIndex = 263;
            // 
            // treePlugins
            // 
            this.treePlugins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treePlugins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.treePlugins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treePlugins.CheckBoxes = true;
            this.treePlugins.Font = new System.Drawing.Font("Segoe UI Variable Small Semilig", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treePlugins.FullRowSelect = true;
            this.treePlugins.HotTracking = true;
            this.treePlugins.ItemHeight = 22;
            this.treePlugins.Location = new System.Drawing.Point(19, 56);
            this.treePlugins.Margin = new System.Windows.Forms.Padding(4);
            this.treePlugins.Name = "treePlugins";
            this.treePlugins.ShowLines = false;
            this.treePlugins.ShowNodeToolTips = true;
            this.treePlugins.ShowPlusMinus = false;
            this.treePlugins.Size = new System.Drawing.Size(647, 231);
            this.treePlugins.TabIndex = 256;
            this.treePlugins.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treePlugins_AfterCheck);
            // 
            // lblInstalled
            // 
            this.lblInstalled.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 10F, System.Drawing.FontStyle.Bold);
            this.lblInstalled.ForeColor = System.Drawing.Color.Black;
            this.lblInstalled.Location = new System.Drawing.Point(15, 16);
            this.lblInstalled.Margin = new System.Windows.Forms.Padding(4);
            this.lblInstalled.Name = "lblInstalled";
            this.lblInstalled.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblInstalled.Size = new System.Drawing.Size(109, 20);
            this.lblInstalled.TabIndex = 260;
            this.lblInstalled.Text = "Installed";
            this.lblInstalled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(0)))), ((int)(((byte)(123)))));
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNext.FlatAppearance.BorderSize = 2;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(570, 553);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(115, 31);
            this.btnNext.TabIndex = 262;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(24, 23);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(670, 39);
            this.lblHeader.TabIndex = 266;
            this.lblHeader.Text = "Extensions";
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(199)))), ((int)(((byte)(197)))));
            this.panelTop.Controls.Add(this.btnDonate);
            this.panelTop.Controls.Add(this.btnPluginStore);
            this.panelTop.Controls.Add(this.lblSubHeader);
            this.panelTop.Location = new System.Drawing.Point(26, 66);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(659, 141);
            this.panelTop.TabIndex = 267;
            // 
            // btnDonate
            // 
            this.btnDonate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(239)))), ((int)(((byte)(238)))));
            this.btnDonate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(199)))), ((int)(((byte)(197)))));
            this.btnDonate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonate.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 10.5F);
            this.btnDonate.ForeColor = System.Drawing.Color.Black;
            this.btnDonate.Location = new System.Drawing.Point(217, 79);
            this.btnDonate.Margin = new System.Windows.Forms.Padding(4);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(173, 33);
            this.btnDonate.TabIndex = 270;
            this.btnDonate.TabStop = false;
            this.btnDonate.Text = "Donate";
            this.btnDonate.UseVisualStyleBackColor = false;
            this.btnDonate.Click += new System.EventHandler(this.btnDonate_Click);
            // 
            // btnPluginStore
            // 
            this.btnPluginStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(239)))), ((int)(((byte)(238)))));
            this.btnPluginStore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(199)))), ((int)(((byte)(197)))));
            this.btnPluginStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPluginStore.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 10.5F);
            this.btnPluginStore.ForeColor = System.Drawing.Color.Black;
            this.btnPluginStore.Location = new System.Drawing.Point(36, 79);
            this.btnPluginStore.Margin = new System.Windows.Forms.Padding(4);
            this.btnPluginStore.Name = "btnPluginStore";
            this.btnPluginStore.Size = new System.Drawing.Size(173, 33);
            this.btnPluginStore.TabIndex = 269;
            this.btnPluginStore.TabStop = false;
            this.btnPluginStore.Text = "Visit Store";
            this.btnPluginStore.UseVisualStyleBackColor = true;
            this.btnPluginStore.Click += new System.EventHandler(this.btnPluginStore_Click);
            // 
            // lblSubHeader
            // 
            this.lblSubHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubHeader.AutoEllipsis = true;
            this.lblSubHeader.Font = new System.Drawing.Font("Segoe UI Variable Small Semilig", 13.75F);
            this.lblSubHeader.ForeColor = System.Drawing.Color.Black;
            this.lblSubHeader.Location = new System.Drawing.Point(34, 17);
            this.lblSubHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubHeader.Name = "lblSubHeader";
            this.lblSubHeader.Size = new System.Drawing.Size(616, 49);
            this.lblSubHeader.TabIndex = 267;
            this.lblSubHeader.Text = "More Possibilities with Bloatynosy Nue Plugins";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(640, 23);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(36, 30);
            this.btnRefresh.TabIndex = 268;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Text = "...";
            this.btnRefresh.UseMnemonic = false;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnPluginsDir
            // 
            this.btnPluginsDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPluginsDir.BackColor = System.Drawing.Color.Transparent;
            this.btnPluginsDir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPluginsDir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.btnPluginsDir.FlatAppearance.BorderSize = 0;
            this.btnPluginsDir.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            this.btnPluginsDir.ForeColor = System.Drawing.Color.Black;
            this.btnPluginsDir.Location = new System.Drawing.Point(598, 23);
            this.btnPluginsDir.Name = "btnPluginsDir";
            this.btnPluginsDir.Size = new System.Drawing.Size(36, 30);
            this.btnPluginsDir.TabIndex = 272;
            this.btnPluginsDir.TabStop = false;
            this.btnPluginsDir.Text = "...";
            this.btnPluginsDir.UseMnemonic = false;
            this.btnPluginsDir.UseVisualStyleBackColor = false;
            this.btnPluginsDir.Click += new System.EventHandler(this.btnPluginsDir_Click);
            // 
            // PluginsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.btnPluginsDir);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.panelPlugins);
            this.Controls.Add(this.btnNext);
            this.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PluginsView";
            this.Size = new System.Drawing.Size(711, 600);
            this.Load += new System.EventHandler(this.PluginsView_Load);
            this.panelPlugins.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPlugins;
        private System.Windows.Forms.TreeView treePlugins;
        private System.Windows.Forms.Label lblInstalled;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblSubHeader;
        private System.Windows.Forms.Button btnDonate;
        private System.Windows.Forms.Button btnPluginStore;
        public System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.Button btnPluginsDir;
    }
}
