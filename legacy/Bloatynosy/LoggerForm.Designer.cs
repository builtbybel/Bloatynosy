namespace Bloatynosy
{
    partial class LoggerForm
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
            this.btnAppUpdate = new System.Windows.Forms.Button();
            this.border = new System.Windows.Forms.Label();
            this.btnAppDev = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAppUpdate
            // 
            this.btnAppUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppUpdate.AutoSize = true;
            this.btnAppUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnAppUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppUpdate.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAppUpdate.FlatAppearance.BorderSize = 0;
            this.btnAppUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnAppUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAppUpdate.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            this.btnAppUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(238)))));
            this.btnAppUpdate.Location = new System.Drawing.Point(308, 1);
            this.btnAppUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnAppUpdate.Name = "btnAppUpdate";
            this.btnAppUpdate.Size = new System.Drawing.Size(143, 30);
            this.btnAppUpdate.TabIndex = 258;
            this.btnAppUpdate.TabStop = false;
            this.btnAppUpdate.Text = "Check for Updates";
            this.btnAppUpdate.UseVisualStyleBackColor = false;
            this.btnAppUpdate.Click += new System.EventHandler(this.btnAppUpdate_Click);
            // 
            // border
            // 
            this.border.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(203)))));
            this.border.ForeColor = System.Drawing.Color.Transparent;
            this.border.Location = new System.Drawing.Point(-8, 34);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(513, 1);
            this.border.TabIndex = 257;
            // 
            // btnAppDev
            // 
            this.btnAppDev.AutoSize = true;
            this.btnAppDev.BackColor = System.Drawing.Color.Transparent;
            this.btnAppDev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppDev.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAppDev.FlatAppearance.BorderSize = 0;
            this.btnAppDev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnAppDev.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAppDev.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            this.btnAppDev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnAppDev.Location = new System.Drawing.Point(17, 86);
            this.btnAppDev.Margin = new System.Windows.Forms.Padding(4);
            this.btnAppDev.Name = "btnAppDev";
            this.btnAppDev.Size = new System.Drawing.Size(185, 29);
            this.btnAppDev.TabIndex = 256;
            this.btnAppDev.TabStop = false;
            this.btnAppDev.Text = "Send feedback in GitHub";
            this.btnAppDev.UseVisualStyleBackColor = false;
            this.btnAppDev.Click += new System.EventHandler(this.btnAppDev_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 10F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.lblHeader.Location = new System.Drawing.Point(12, 6);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(289, 24);
            this.lblHeader.TabIndex = 255;
            this.lblHeader.Text = "Notifications";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F);
            this.textBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.textBoxSearch.Location = new System.Drawing.Point(17, 53);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(450, 27);
            this.textBoxSearch.TabIndex = 254;
            this.textBoxSearch.Text = "Search";
            this.textBoxSearch.Click += new System.EventHandler(this.textBoxSearch_Click);
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // rtbLog
            // 
            this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLog.AutoWordSelection = true;
            this.rtbLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLog.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.25F, System.Drawing.FontStyle.Bold);
            this.rtbLog.ForeColor = System.Drawing.Color.White;
            this.rtbLog.Location = new System.Drawing.Point(17, 122);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(468, 458);
            this.rtbLog.TabIndex = 253;
            this.rtbLog.Text = "";
            this.rtbLog.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbLog_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11.25F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(456, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 265;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // LoggerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(498, 596);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAppUpdate);
            this.Controls.Add(this.border);
            this.Controls.Add(this.btnAppDev);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.rtbLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "LoggerForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAppUpdate;
        private System.Windows.Forms.Label border;
        private System.Windows.Forms.Button btnAppDev;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Button btnClose;
    }
}