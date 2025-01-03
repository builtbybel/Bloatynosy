namespace BloatynosyNue
{
    partial class MainForm
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblHeader = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnExperience = new System.Windows.Forms.Button();
            this.btnDumputer = new System.Windows.Forms.Button();
            this.btnPlugins = new System.Windows.Forms.Button();
            this.btnLogger = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblSteps = new System.Windows.Forms.Label();
            this.lblSubHeader = new System.Windows.Forms.Label();
            this.buttonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 21.25F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(4, 170);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(688, 38);
            this.lblHeader.TabIndex = 246;
            this.lblHeader.Text = "Set up Windows 11";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            this.toolTip.UseAnimation = false;
            this.toolTip.UseFading = false;
            // 
            // btnExperience
            // 
            this.btnExperience.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExperience.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(0)))), ((int)(((byte)(123)))));
            this.btnExperience.FlatAppearance.BorderSize = 0;
            this.btnExperience.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExperience.Font = new System.Drawing.Font("Segoe UI Variable Small", 10.25F);
            this.btnExperience.ForeColor = System.Drawing.Color.White;
            this.btnExperience.Location = new System.Drawing.Point(318, 406);
            this.btnExperience.Name = "btnExperience";
            this.btnExperience.Size = new System.Drawing.Size(169, 37);
            this.btnExperience.TabIndex = 263;
            this.btnExperience.TabStop = false;
            this.btnExperience.Text = "Experience";
            this.toolTip.SetToolTip(this.btnExperience, "Customize Windows 11 settings for enhanced privacy, control, and personalization");
            this.btnExperience.UseVisualStyleBackColor = false;
            // 
            // btnDumputer
            // 
            this.btnDumputer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDumputer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(0)))), ((int)(((byte)(123)))));
            this.btnDumputer.FlatAppearance.BorderSize = 0;
            this.btnDumputer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDumputer.Font = new System.Drawing.Font("Segoe UI Variable Small", 10.25F);
            this.btnDumputer.ForeColor = System.Drawing.Color.White;
            this.btnDumputer.Location = new System.Drawing.Point(493, 406);
            this.btnDumputer.Name = "btnDumputer";
            this.btnDumputer.Size = new System.Drawing.Size(169, 37);
            this.btnDumputer.TabIndex = 1;
            this.btnDumputer.TabStop = false;
            this.btnDumputer.Text = "Dumputer™";
            this.toolTip.SetToolTip(this.btnDumputer, "Remove pre-installed apps on Windows 11 (24H2 and 23H2) to declutter your system");
            this.btnDumputer.UseVisualStyleBackColor = false;
            // 
            // btnPlugins
            // 
            this.btnPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlugins.BackColor = System.Drawing.Color.Transparent;
            this.btnPlugins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlugins.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.btnPlugins.FlatAppearance.BorderSize = 0;
            this.btnPlugins.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            this.btnPlugins.ForeColor = System.Drawing.Color.Black;
            this.btnPlugins.Location = new System.Drawing.Point(544, 12);
            this.btnPlugins.Name = "btnPlugins";
            this.btnPlugins.Size = new System.Drawing.Size(36, 30);
            this.btnPlugins.TabIndex = 107;
            this.btnPlugins.TabStop = false;
            this.btnPlugins.Text = "...";
            this.toolTip.SetToolTip(this.btnPlugins, "Plugins");
            this.btnPlugins.UseMnemonic = false;
            this.btnPlugins.UseVisualStyleBackColor = false;
            // 
            // btnLogger
            // 
            this.btnLogger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogger.BackColor = System.Drawing.Color.Transparent;
            this.btnLogger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogger.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.btnLogger.FlatAppearance.BorderSize = 0;
            this.btnLogger.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogger.ForeColor = System.Drawing.Color.Black;
            this.btnLogger.Location = new System.Drawing.Point(586, 12);
            this.btnLogger.Name = "btnLogger";
            this.btnLogger.Size = new System.Drawing.Size(36, 30);
            this.btnLogger.TabIndex = 106;
            this.btnLogger.TabStop = false;
            this.btnLogger.Text = "...";
            this.toolTip.SetToolTip(this.btnLogger, "Notifications");
            this.btnLogger.UseMnemonic = false;
            this.btnLogger.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            this.btnSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSettings.Location = new System.Drawing.Point(637, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(36, 30);
            this.btnSettings.TabIndex = 108;
            this.btnSettings.TabStop = false;
            this.btnSettings.Text = "...";
            this.toolTip.SetToolTip(this.btnSettings, "About this app");
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.mainPanel.Controls.Add(this.pictureBox2);
            this.mainPanel.Controls.Add(this.lblSteps);
            this.mainPanel.Controls.Add(this.btnDumputer);
            this.mainPanel.Controls.Add(this.lblSubHeader);
            this.mainPanel.Controls.Add(this.lblHeader);
            this.mainPanel.Controls.Add(this.btnExperience);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(696, 505);
            this.mainPanel.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::BloatynosyNue.Properties.Resources.assetWaving;
            this.pictureBox2.Location = new System.Drawing.Point(469, 365);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 25);
            this.pictureBox2.TabIndex = 270;
            this.pictureBox2.TabStop = false;
            // 
            // lblSteps
            // 
            this.lblSteps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSteps.AutoEllipsis = true;
            this.lblSteps.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblSteps.ForeColor = System.Drawing.Color.Black;
            this.lblSteps.Location = new System.Drawing.Point(251, 365);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(212, 28);
            this.lblSteps.TabIndex = 267;
            this.lblSteps.Text = "I would like to";
            this.lblSteps.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubHeader
            // 
            this.lblSubHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubHeader.AutoEllipsis = true;
            this.lblSubHeader.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.lblSubHeader.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubHeader.Location = new System.Drawing.Point(9, 220);
            this.lblSubHeader.Name = "lblSubHeader";
            this.lblSubHeader.Size = new System.Drawing.Size(683, 73);
            this.lblSubHeader.TabIndex = 266;
            this.lblSubHeader.Text = "Level up Windows 11 privacy and personalization, declutter by removing bloatware," +
    " and supercharge functionality with community plugins.";
            this.lblSubHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPanel.Location = new System.Drawing.Point(6, 12);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(528, 30);
            this.buttonPanel.TabIndex = 101;
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.Controls.Add(this.mainPanel);
            this.panelContainer.Location = new System.Drawing.Point(-1, 48);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(696, 505);
            this.panelContainer.TabIndex = 105;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(695, 555);
            this.Controls.Add(this.btnPlugins);
            this.Controls.Add(this.btnLogger);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.buttonPanel);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bloatynosy";
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.Label lblSubHeader;
        private System.Windows.Forms.Button btnDumputer;
        private System.Windows.Forms.Button btnExperience;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel buttonPanel;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btnLogger;
        private System.Windows.Forms.Button btnSettings;
        public System.Windows.Forms.Button btnPlugins;
    }
}

