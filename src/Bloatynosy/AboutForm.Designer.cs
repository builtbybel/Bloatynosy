namespace BloatynosyNue
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.lblHeader = new System.Windows.Forms.Label();
            this.linkAppDev = new System.Windows.Forms.LinkLabel();
            this.linkAppVer = new System.Windows.Forms.LinkLabel();
            this.btnOK = new System.Windows.Forms.Button();
            this.linkDonate = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkRandom = new System.Windows.Forms.LinkLabel();
            this.btnLanguage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 28.25F);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(163)))), ((int)(((byte)(198)))));
            this.lblHeader.Location = new System.Drawing.Point(80, 46);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(203, 55);
            this.lblHeader.TabIndex = 235;
            this.lblHeader.Text = "Bloatynosy";
            // 
            // linkAppDev
            // 
            this.linkAppDev.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.linkAppDev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkAppDev.AutoEllipsis = true;
            this.linkAppDev.AutoSize = true;
            this.linkAppDev.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAppDev.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkAppDev.LinkColor = System.Drawing.Color.Black;
            this.linkAppDev.Location = new System.Drawing.Point(85, 176);
            this.linkAppDev.Name = "linkAppDev";
            this.linkAppDev.Size = new System.Drawing.Size(179, 16);
            this.linkAppDev.TabIndex = 253;
            this.linkAppDev.TabStop = true;
            this.linkAppDev.Text = "(C) GitHub. A Belim app creation.";
            this.linkAppDev.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAppDev_LinkClicked);
            // 
            // linkAppVer
            // 
            this.linkAppVer.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.linkAppVer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkAppVer.AutoSize = true;
            this.linkAppVer.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAppVer.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkAppVer.LinkColor = System.Drawing.Color.Black;
            this.linkAppVer.Location = new System.Drawing.Point(85, 107);
            this.linkAppVer.Name = "linkAppVer";
            this.linkAppVer.Size = new System.Drawing.Size(45, 16);
            this.linkAppVer.TabIndex = 254;
            this.linkAppVer.TabStop = true;
            this.linkAppVer.Text = "Version";
            this.linkAppVer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Location = new System.Drawing.Point(433, 212);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 22);
            this.btnOK.TabIndex = 255;
            this.btnOK.Text = "OK";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // linkDonate
            // 
            this.linkDonate.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.linkDonate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkDonate.AutoEllipsis = true;
            this.linkDonate.AutoSize = true;
            this.linkDonate.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkDonate.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkDonate.LinkColor = System.Drawing.Color.DeepPink;
            this.linkDonate.Location = new System.Drawing.Point(268, 176);
            this.linkDonate.Name = "linkDonate";
            this.linkDonate.Size = new System.Drawing.Size(60, 20);
            this.linkDonate.TabIndex = 256;
            this.linkDonate.TabStop = true;
            this.linkDonate.Text = "Donate";
            this.linkDonate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDonate_LinkClicked);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(274, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 55);
            this.label1.TabIndex = 257;
            this.label1.Text = "Nue";
            // 
            // linkRandom
            // 
            this.linkRandom.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.linkRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkRandom.AutoEllipsis = true;
            this.linkRandom.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRandom.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkRandom.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(181)))));
            this.linkRandom.Location = new System.Drawing.Point(85, 134);
            this.linkRandom.Name = "linkRandom";
            this.linkRandom.Size = new System.Drawing.Size(435, 32);
            this.linkRandom.TabIndex = 258;
            this.linkRandom.TabStop = true;
            this.linkRandom.Text = "...";
            this.linkRandom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLanguage
            // 
            this.btnLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnLanguage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLanguage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanguage.ForeColor = System.Drawing.Color.Black;
            this.btnLanguage.Location = new System.Drawing.Point(284, 212);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(143, 22);
            this.btnLanguage.TabIndex = 259;
            this.btnLanguage.Text = "Install language";
            this.btnLanguage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLanguage.UseVisualStyleBackColor = false;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(542, 246);
            this.Controls.Add(this.btnLanguage);
            this.Controls.Add(this.linkRandom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkDonate);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.linkAppDev);
            this.Controls.Add(this.linkAppVer);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.LinkLabel linkAppDev;
        private System.Windows.Forms.LinkLabel linkAppVer;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.LinkLabel linkDonate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkRandom;
        private System.Windows.Forms.Button btnLanguage;
    }
}