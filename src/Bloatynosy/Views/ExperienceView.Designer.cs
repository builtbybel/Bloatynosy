namespace Views
{
    partial class ExperienceView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExperienceView));
            this.featurePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblSubHeader = new System.Windows.Forms.Label();
            this.btnRevert = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.lblWarnAsset = new System.Windows.Forms.Label();
            this.lblSort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // featurePanel
            // 
            this.featurePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.featurePanel.AutoScroll = true;
            this.featurePanel.Location = new System.Drawing.Point(31, 185);
            this.featurePanel.Name = "featurePanel";
            this.featurePanel.Size = new System.Drawing.Size(671, 344);
            this.featurePanel.TabIndex = 232;
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(21, 19);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(540, 31);
            this.lblHeader.TabIndex = 234;
            this.lblHeader.Text = "Customize Experience";
            // 
            // lblSubHeader
            // 
            this.lblSubHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubHeader.AutoEllipsis = true;
            this.lblSubHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(207)))));
            this.lblSubHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubHeader.Font = new System.Drawing.Font("Segoe UI Variable Small", 8F);
            this.lblSubHeader.Location = new System.Drawing.Point(26, 95);
            this.lblSubHeader.Name = "lblSubHeader";
            this.lblSubHeader.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblSubHeader.Size = new System.Drawing.Size(668, 23);
            this.lblSubHeader.TabIndex = 235;
            this.lblSubHeader.Text = "Click \'Enable All\' to apply all changes, or \'Disable All\' to revert to the defaul" +
    "t settings. You can also make individual adjustments as needed.";
            // 
            // btnRevert
            // 
            this.btnRevert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRevert.AutoEllipsis = true;
            this.btnRevert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnRevert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRevert.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRevert.FlatAppearance.BorderSize = 2;
            this.btnRevert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.btnRevert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevert.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F);
            this.btnRevert.Location = new System.Drawing.Point(567, 562);
            this.btnRevert.Name = "btnRevert";
            this.btnRevert.Size = new System.Drawing.Size(132, 27);
            this.btnRevert.TabIndex = 238;
            this.btnRevert.TabStop = false;
            this.btnRevert.Text = "Disable All";
            this.btnRevert.UseVisualStyleBackColor = false;
            this.btnRevert.Click += new System.EventHandler(this.btnRevert_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.AutoEllipsis = true;
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnApply.FlatAppearance.BorderSize = 2;
            this.btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F);
            this.btnApply.Image = ((System.Drawing.Image)(resources.GetObject("btnApply.Image")));
            this.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApply.Location = new System.Drawing.Point(351, 562);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(210, 27);
            this.btnApply.TabIndex = 237;
            this.btnApply.TabStop = false;
            this.btnApply.Text = "Enable All";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoEllipsis = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Text", 8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(512, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 18);
            this.label2.TabIndex = 239;
            this.label2.Text = "LAST UPDATED: November 2024";
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
            this.btnBack.TabIndex = 240;
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
            this.textBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxSearch.Location = new System.Drawing.Point(31, 124);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(387, 26);
            this.textBoxSearch.TabIndex = 241;
            this.textBoxSearch.Text = "Filter";
            this.textBoxSearch.Click += new System.EventHandler(this.searchTextBox_Click);
            this.textBoxSearch.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.25F);
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(529, 123);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(165, 27);
            this.categoryComboBox.TabIndex = 242;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // lblWarnAsset
            // 
            this.lblWarnAsset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(207)))));
            this.lblWarnAsset.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarnAsset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(157)))), ((int)(((byte)(51)))));
            this.lblWarnAsset.Location = new System.Drawing.Point(28, 97);
            this.lblWarnAsset.Name = "lblWarnAsset";
            this.lblWarnAsset.Size = new System.Drawing.Size(29, 18);
            this.lblWarnAsset.TabIndex = 243;
            // 
            // lblSort
            // 
            this.lblSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSort.AutoEllipsis = true;
            this.lblSort.Font = new System.Drawing.Font("Segoe UI Variable Small Semilig", 10F);
            this.lblSort.Location = new System.Drawing.Point(458, 127);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(65, 19);
            this.lblSort.TabIndex = 251;
            this.lblSort.Text = "Sort";
            // 
            // ExperienceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.lblWarnAsset);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRevert);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lblSubHeader);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.featurePanel);
            this.Name = "ExperienceView";
            this.Size = new System.Drawing.Size(711, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel featurePanel;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblSubHeader;
        private System.Windows.Forms.Button btnRevert;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label lblWarnAsset;
        private System.Windows.Forms.Label lblSort;
    }
}
