namespace BloatynosyNue
{
    partial class StoreForm
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
            this.textDescription = new System.Windows.Forms.TextBox();
            this.checkedListBoxPlugins = new System.Windows.Forms.CheckedListBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnUninstall = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.linkPluginsDirectory = new System.Windows.Forms.LinkLabel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // textDescription
            // 
            this.textDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.textDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDescription.Font = new System.Drawing.Font("Segoe UI Variable Small Light", 9.75F);
            this.textDescription.ForeColor = System.Drawing.Color.Black;
            this.textDescription.Location = new System.Drawing.Point(27, 359);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(668, 95);
            this.textDescription.TabIndex = 212;
            // 
            // checkedListBoxPlugins
            // 
            this.checkedListBoxPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxPlugins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.checkedListBoxPlugins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxPlugins.Font = new System.Drawing.Font("Segoe UI Variable Small Semilig", 9.75F);
            this.checkedListBoxPlugins.ForeColor = System.Drawing.Color.Black;
            this.checkedListBoxPlugins.FormattingEnabled = true;
            this.checkedListBoxPlugins.Location = new System.Drawing.Point(41, 87);
            this.checkedListBoxPlugins.Name = "checkedListBoxPlugins";
            this.checkedListBoxPlugins.Size = new System.Drawing.Size(654, 220);
            this.checkedListBoxPlugins.TabIndex = 211;
            this.checkedListBoxPlugins.ThreeDCheckBoxes = true;
            this.checkedListBoxPlugins.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxPlugins_SelectedIndexChanged);
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnDownload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.btnDownload.FlatAppearance.BorderSize = 2;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F);
            this.btnDownload.ForeColor = System.Drawing.Color.Black;
            this.btnDownload.Location = new System.Drawing.Point(574, 8);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(93, 27);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "Install";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(0, 542);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(695, 26);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 213;
            // 
            // btnUninstall
            // 
            this.btnUninstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUninstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnUninstall.FlatAppearance.BorderColor = System.Drawing.Color.DeepPink;
            this.btnUninstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUninstall.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F);
            this.btnUninstall.ForeColor = System.Drawing.Color.Black;
            this.btnUninstall.Location = new System.Drawing.Point(475, 33);
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Size = new System.Drawing.Size(93, 27);
            this.btnUninstall.TabIndex = 5;
            this.btnUninstall.Text = "Uninstall";
            this.btnUninstall.UseVisualStyleBackColor = false;
            this.btnUninstall.Click += new System.EventHandler(this.btnUninstall_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.panelBottom.Controls.Add(this.linkPluginsDirectory);
            this.panelBottom.Controls.Add(this.btnDownload);
            this.panelBottom.Location = new System.Drawing.Point(0, 497);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(695, 45);
            this.panelBottom.TabIndex = 217;
            // 
            // linkPluginsDirectory
            // 
            this.linkPluginsDirectory.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.linkPluginsDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkPluginsDirectory.AutoEllipsis = true;
            this.linkPluginsDirectory.AutoSize = true;
            this.linkPluginsDirectory.Font = new System.Drawing.Font("Segoe UI Variable Small", 8.75F);
            this.linkPluginsDirectory.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkPluginsDirectory.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.linkPluginsDirectory.Location = new System.Drawing.Point(12, 17);
            this.linkPluginsDirectory.Name = "linkPluginsDirectory";
            this.linkPluginsDirectory.Size = new System.Drawing.Size(97, 16);
            this.linkPluginsDirectory.TabIndex = 1;
            this.linkPluginsDirectory.TabStop = true;
            this.linkPluginsDirectory.Text = "Plugins directory";
            this.linkPluginsDirectory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPluginsDirectory_LinkClicked);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 18.25F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(44, 26);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(196, 38);
            this.lblHeader.TabIndex = 267;
            this.lblHeader.Text = "NueEx Store";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F);
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(376, 33);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 27);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Home";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnImport.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F);
            this.btnImport.ForeColor = System.Drawing.Color.Black;
            this.btnImport.Location = new System.Drawing.Point(574, 33);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(93, 27);
            this.btnImport.TabIndex = 300;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Small Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 270;
            this.label1.Text = "Details";
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(695, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUninstall);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.checkedListBoxPlugins);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.panelBottom);
            this.Name = "StoreForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Store";
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.CheckedListBox checkedListBoxPlugins;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnUninstall;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.LinkLabel linkPluginsDirectory;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label label1;
    }
}