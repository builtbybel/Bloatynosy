namespace BloatynosyNue.Views
{
    partial class LoggerView
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
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnAppDev = new System.Windows.Forms.Button();
            this.border = new System.Windows.Forms.Label();
            this.btnAppUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbLog
            // 
            this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLog.Font = new System.Drawing.Font("Consolas", 10.75F);
            this.rtbLog.Location = new System.Drawing.Point(36, 183);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(645, 363);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            this.rtbLog.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbLog_LinkClicked);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.25F);
            this.textBoxSearch.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxSearch.Location = new System.Drawing.Point(36, 140);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(645, 26);
            this.textBoxSearch.TabIndex = 245;
            this.textBoxSearch.Text = "Search";
            this.textBoxSearch.Click += new System.EventHandler(this.textBoxSearch_Click);
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Variable Small Semilig", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(31, 14);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(619, 31);
            this.lblHeader.TabIndex = 246;
            this.lblHeader.Text = "Notifications";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAppDev
            // 
            this.btnAppDev.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAppDev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnAppDev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppDev.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAppDev.FlatAppearance.BorderSize = 0;
            this.btnAppDev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppDev.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            this.btnAppDev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(0)))), ((int)(((byte)(123)))));
            this.btnAppDev.Location = new System.Drawing.Point(136, 60);
            this.btnAppDev.Margin = new System.Windows.Forms.Padding(4);
            this.btnAppDev.Name = "btnAppDev";
            this.btnAppDev.Size = new System.Drawing.Size(209, 31);
            this.btnAppDev.TabIndex = 249;
            this.btnAppDev.TabStop = false;
            this.btnAppDev.Text = "Send feedback in GitHub";
            this.btnAppDev.UseVisualStyleBackColor = false;
            this.btnAppDev.Click += new System.EventHandler(this.btnAppDev_Click);
            // 
            // border
            // 
            this.border.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.border.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.border.Location = new System.Drawing.Point(0, 111);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(711, 1);
            this.border.TabIndex = 250;
            // 
            // btnAppUpdate
            // 
            this.btnAppUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAppUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnAppUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppUpdate.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAppUpdate.FlatAppearance.BorderSize = 0;
            this.btnAppUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppUpdate.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            this.btnAppUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(0)))), ((int)(((byte)(123)))));
            this.btnAppUpdate.Location = new System.Drawing.Point(353, 60);
            this.btnAppUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnAppUpdate.Name = "btnAppUpdate";
            this.btnAppUpdate.Size = new System.Drawing.Size(209, 31);
            this.btnAppUpdate.TabIndex = 251;
            this.btnAppUpdate.TabStop = false;
            this.btnAppUpdate.Text = "Check for Updates";
            this.btnAppUpdate.UseVisualStyleBackColor = false;
            // 
            // LoggerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.Controls.Add(this.btnAppUpdate);
            this.Controls.Add(this.border);
            this.Controls.Add(this.btnAppDev);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.rtbLog);
            this.Name = "LoggerView";
            this.Size = new System.Drawing.Size(711, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnAppDev;
        private System.Windows.Forms.Label border;
        private System.Windows.Forms.Button btnAppUpdate;
    }
}
