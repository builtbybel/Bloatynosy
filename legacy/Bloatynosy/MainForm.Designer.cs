namespace Bloatynosy
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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnLogger = new System.Windows.Forms.Button();
            this.linkAppDev = new System.Windows.Forms.LinkLabel();
            this.btnPlugins = new System.Windows.Forms.Button();
            this.btnDumputer = new System.Windows.Forms.Button();
            this.btnExperience = new System.Windows.Forms.Button();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.assetChevronRight2 = new System.Windows.Forms.Label();
            this.assetChevronRight3 = new System.Windows.Forms.Label();
            this.assetChevronRight4 = new System.Windows.Forms.Label();
            this.assetChevronRight1 = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.linkShare = new System.Windows.Forms.LinkLabel();
            this.border = new System.Windows.Forms.Label();
            this.panelFAQ = new System.Windows.Forms.Panel();
            this.btnCloseFAQ = new System.Windows.Forms.Button();
            this.panelPlugins = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHomeStore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHome = new System.Windows.Forms.Panel();
            this.assetChevronDown = new System.Windows.Forms.Label();
            this.btnDropdown = new System.Windows.Forms.Button();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.btnOption4 = new System.Windows.Forms.Button();
            this.btnOption3 = new System.Windows.Forms.Button();
            this.btnOption2 = new System.Windows.Forms.Button();
            this.btnOption1 = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.assetInfo = new System.Windows.Forms.Label();
            this.lblSubHeader = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelFAQ.SuspendLayout();
            this.panelPlugins.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.panelOptions.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            this.toolTip.UseAnimation = false;
            this.toolTip.UseFading = false;
            // 
            // btnLogger
            // 
            this.btnLogger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogger.AutoEllipsis = true;
            this.btnLogger.BackColor = System.Drawing.Color.Transparent;
            this.btnLogger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogger.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnLogger.FlatAppearance.BorderSize = 0;
            this.btnLogger.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogger.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogger.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLogger.Font = new System.Drawing.Font("Segoe UI Variable Small", 10.25F);
            this.btnLogger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(6)))), ((int)(((byte)(8)))));
            this.btnLogger.Location = new System.Drawing.Point(415, 5);
            this.btnLogger.Name = "btnLogger";
            this.btnLogger.Size = new System.Drawing.Size(115, 31);
            this.btnLogger.TabIndex = 106;
            this.btnLogger.TabStop = false;
            this.btnLogger.Text = "...";
            this.toolTip.SetToolTip(this.btnLogger, "Notifications");
            this.btnLogger.UseVisualStyleBackColor = false;
            // 
            // linkAppDev
            // 
            this.linkAppDev.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.linkAppDev.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkAppDev.AutoEllipsis = true;
            this.linkAppDev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(238)))));
            this.linkAppDev.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.25F, System.Drawing.FontStyle.Bold);
            this.linkAppDev.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkAppDev.LinkColor = System.Drawing.Color.Black;
            this.linkAppDev.Location = new System.Drawing.Point(150, 15);
            this.linkAppDev.Name = "linkAppDev";
            this.linkAppDev.Size = new System.Drawing.Size(181, 23);
            this.linkAppDev.TabIndex = 276;
            this.linkAppDev.TabStop = true;
            this.linkAppDev.Text = "We live on GitHub. ";
            this.linkAppDev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.linkAppDev, "Fork it, tweak it, love it!");
            this.linkAppDev.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAppDev_LinkClicked);
            // 
            // btnPlugins
            // 
            this.btnPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlugins.AutoEllipsis = true;
            this.btnPlugins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnPlugins.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPlugins.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnPlugins.FlatAppearance.BorderSize = 0;
            this.btnPlugins.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnPlugins.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnPlugins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlugins.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12.5F, System.Drawing.FontStyle.Bold);
            this.btnPlugins.ForeColor = System.Drawing.Color.White;
            this.btnPlugins.Location = new System.Drawing.Point(48, 364);
            this.btnPlugins.Name = "btnPlugins";
            this.btnPlugins.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnPlugins.Size = new System.Drawing.Size(498, 43);
            this.btnPlugins.TabIndex = 276;
            this.btnPlugins.TabStop = false;
            this.btnPlugins.Text = "Plugins";
            this.btnPlugins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.btnPlugins, "Plugins");
            this.btnPlugins.UseMnemonic = false;
            this.btnPlugins.UseVisualStyleBackColor = false;
            // 
            // btnDumputer
            // 
            this.btnDumputer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDumputer.AutoEllipsis = true;
            this.btnDumputer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnDumputer.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDumputer.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnDumputer.FlatAppearance.BorderSize = 0;
            this.btnDumputer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnDumputer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnDumputer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDumputer.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12.5F, System.Drawing.FontStyle.Bold);
            this.btnDumputer.ForeColor = System.Drawing.Color.White;
            this.btnDumputer.Location = new System.Drawing.Point(48, 315);
            this.btnDumputer.Name = "btnDumputer";
            this.btnDumputer.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDumputer.Size = new System.Drawing.Size(498, 43);
            this.btnDumputer.TabIndex = 275;
            this.btnDumputer.TabStop = false;
            this.btnDumputer.Text = "Dumputer™";
            this.btnDumputer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.btnDumputer, "Remove pre-installed apps on Windows 11 (24H2 and 23H2) to declutter your system");
            this.btnDumputer.UseVisualStyleBackColor = false;
            // 
            // btnExperience
            // 
            this.btnExperience.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExperience.AutoEllipsis = true;
            this.btnExperience.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnExperience.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExperience.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnExperience.FlatAppearance.BorderSize = 0;
            this.btnExperience.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnExperience.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnExperience.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExperience.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12.5F, System.Drawing.FontStyle.Bold);
            this.btnExperience.ForeColor = System.Drawing.Color.White;
            this.btnExperience.Location = new System.Drawing.Point(48, 266);
            this.btnExperience.Name = "btnExperience";
            this.btnExperience.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnExperience.Size = new System.Drawing.Size(498, 43);
            this.btnExperience.TabIndex = 277;
            this.btnExperience.TabStop = false;
            this.btnExperience.Text = "Experience";
            this.btnExperience.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.btnExperience, "Customize Windows 11 settings for enhanced privacy, control, and personalization");
            this.btnExperience.UseVisualStyleBackColor = false;
            // 
            // btnStore
            // 
            this.btnStore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStore.AutoEllipsis = true;
            this.btnStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnStore.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnStore.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnStore.FlatAppearance.BorderSize = 0;
            this.btnStore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnStore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStore.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12.5F, System.Drawing.FontStyle.Bold);
            this.btnStore.ForeColor = System.Drawing.Color.White;
            this.btnStore.Location = new System.Drawing.Point(48, 413);
            this.btnStore.Name = "btnStore";
            this.btnStore.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnStore.Size = new System.Drawing.Size(498, 43);
            this.btnStore.TabIndex = 278;
            this.btnStore.TabStop = false;
            this.btnStore.Text = "Store";
            this.btnStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.btnStore, "Plugins");
            this.btnStore.UseMnemonic = false;
            this.btnStore.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11.25F);
            this.btnBack.ForeColor = System.Drawing.Color.DarkGray;
            this.btnBack.Location = new System.Drawing.Point(7, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(30, 30);
            this.btnBack.TabIndex = 264;
            this.btnBack.TabStop = false;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHome.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.25F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(48, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(30, 30);
            this.btnHome.TabIndex = 275;
            this.btnHome.Text = "...";
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelMain.Controls.Add(this.assetChevronRight2);
            this.panelMain.Controls.Add(this.assetChevronRight3);
            this.panelMain.Controls.Add(this.assetChevronRight4);
            this.panelMain.Controls.Add(this.assetChevronRight1);
            this.panelMain.Controls.Add(this.panelBottom);
            this.panelMain.Controls.Add(this.border);
            this.panelMain.Controls.Add(this.btnStore);
            this.panelMain.Controls.Add(this.btnPlugins);
            this.panelMain.Controls.Add(this.btnDumputer);
            this.panelMain.Controls.Add(this.btnExperience);
            this.panelMain.Controls.Add(this.panelFAQ);
            this.panelMain.Controls.Add(this.panelPlugins);
            this.panelMain.Controls.Add(this.panelHome);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(584, 621);
            this.panelMain.TabIndex = 0;
            // 
            // assetChevronRight2
            // 
            this.assetChevronRight2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.assetChevronRight2.AutoEllipsis = true;
            this.assetChevronRight2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.assetChevronRight2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assetChevronRight2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10.25F);
            this.assetChevronRight2.ForeColor = System.Drawing.Color.White;
            this.assetChevronRight2.Location = new System.Drawing.Point(500, 321);
            this.assetChevronRight2.Name = "assetChevronRight2";
            this.assetChevronRight2.Size = new System.Drawing.Size(30, 30);
            this.assetChevronRight2.TabIndex = 312;
            this.assetChevronRight2.Text = "...";
            this.assetChevronRight2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // assetChevronRight3
            // 
            this.assetChevronRight3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.assetChevronRight3.AutoEllipsis = true;
            this.assetChevronRight3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.assetChevronRight3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assetChevronRight3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10.25F);
            this.assetChevronRight3.ForeColor = System.Drawing.Color.White;
            this.assetChevronRight3.Location = new System.Drawing.Point(500, 370);
            this.assetChevronRight3.Name = "assetChevronRight3";
            this.assetChevronRight3.Size = new System.Drawing.Size(30, 30);
            this.assetChevronRight3.TabIndex = 311;
            this.assetChevronRight3.Text = "...";
            this.assetChevronRight3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // assetChevronRight4
            // 
            this.assetChevronRight4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.assetChevronRight4.AutoEllipsis = true;
            this.assetChevronRight4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.assetChevronRight4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assetChevronRight4.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10.25F);
            this.assetChevronRight4.ForeColor = System.Drawing.Color.White;
            this.assetChevronRight4.Location = new System.Drawing.Point(500, 419);
            this.assetChevronRight4.Name = "assetChevronRight4";
            this.assetChevronRight4.Size = new System.Drawing.Size(30, 30);
            this.assetChevronRight4.TabIndex = 310;
            this.assetChevronRight4.Text = "...";
            this.assetChevronRight4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // assetChevronRight1
            // 
            this.assetChevronRight1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.assetChevronRight1.AutoEllipsis = true;
            this.assetChevronRight1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.assetChevronRight1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assetChevronRight1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10.25F);
            this.assetChevronRight1.ForeColor = System.Drawing.Color.White;
            this.assetChevronRight1.Location = new System.Drawing.Point(500, 272);
            this.assetChevronRight1.Name = "assetChevronRight1";
            this.assetChevronRight1.Size = new System.Drawing.Size(30, 30);
            this.assetChevronRight1.TabIndex = 309;
            this.assetChevronRight1.Text = "...";
            this.assetChevronRight1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBottom
            // 
            this.panelBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBottom.Controls.Add(this.linkShare);
            this.panelBottom.Controls.Add(this.linkAppDev);
            this.panelBottom.Location = new System.Drawing.Point(48, 1009);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(498, 64);
            this.panelBottom.TabIndex = 280;
            // 
            // linkShare
            // 
            this.linkShare.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.linkShare.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkShare.AutoEllipsis = true;
            this.linkShare.AutoSize = true;
            this.linkShare.BackColor = System.Drawing.Color.Transparent;
            this.linkShare.Font = new System.Drawing.Font("Segoe UI Variable Small", 8.75F);
            this.linkShare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.linkShare.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkShare.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(238)))));
            this.linkShare.Location = new System.Drawing.Point(176, 42);
            this.linkShare.Name = "linkShare";
            this.linkShare.Size = new System.Drawing.Size(123, 16);
            this.linkShare.TabIndex = 277;
            this.linkShare.TabStop = true;
            this.linkShare.Text = "Spread the word on X";
            this.linkShare.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkShare_LinkClicked);
            // 
            // border
            // 
            this.border.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.border.ForeColor = System.Drawing.Color.Transparent;
            this.border.Location = new System.Drawing.Point(48, 7);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(498, 1);
            this.border.TabIndex = 279;
            // 
            // panelFAQ
            // 
            this.panelFAQ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFAQ.AutoScroll = true;
            this.panelFAQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(26)))), ((int)(((byte)(37)))));
            this.panelFAQ.Controls.Add(this.btnCloseFAQ);
            this.panelFAQ.Location = new System.Drawing.Point(48, 475);
            this.panelFAQ.Name = "panelFAQ";
            this.panelFAQ.Size = new System.Drawing.Size(498, 352);
            this.panelFAQ.TabIndex = 274;
            // 
            // btnCloseFAQ
            // 
            this.btnCloseFAQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseFAQ.AutoSize = true;
            this.btnCloseFAQ.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseFAQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseFAQ.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnCloseFAQ.FlatAppearance.BorderSize = 0;
            this.btnCloseFAQ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCloseFAQ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCloseFAQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseFAQ.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseFAQ.ForeColor = System.Drawing.Color.White;
            this.btnCloseFAQ.Location = new System.Drawing.Point(450, 5);
            this.btnCloseFAQ.Name = "btnCloseFAQ";
            this.btnCloseFAQ.Size = new System.Drawing.Size(30, 30);
            this.btnCloseFAQ.TabIndex = 107;
            this.btnCloseFAQ.TabStop = false;
            this.btnCloseFAQ.Text = "...";
            this.btnCloseFAQ.UseMnemonic = false;
            this.btnCloseFAQ.UseVisualStyleBackColor = false;
            this.btnCloseFAQ.Click += new System.EventHandler(this.btnCloseFAQ_Click);
            // 
            // panelPlugins
            // 
            this.panelPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPlugins.AutoScroll = true;
            this.panelPlugins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(203)))));
            this.panelPlugins.Controls.Add(this.label2);
            this.panelPlugins.Controls.Add(this.btnHomeStore);
            this.panelPlugins.Controls.Add(this.label1);
            this.panelPlugins.Location = new System.Drawing.Point(48, 845);
            this.panelPlugins.Name = "panelPlugins";
            this.panelPlugins.Size = new System.Drawing.Size(498, 158);
            this.panelPlugins.TabIndex = 273;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(162)))), ((int)(((byte)(26)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 272;
            this.label2.Text = "NEW";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHomeStore
            // 
            this.btnHomeStore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHomeStore.AutoEllipsis = true;
            this.btnHomeStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(32)))), ((int)(((byte)(59)))));
            this.btnHomeStore.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnHomeStore.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHomeStore.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnHomeStore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnHomeStore.Location = new System.Drawing.Point(153, 104);
            this.btnHomeStore.Margin = new System.Windows.Forms.Padding(4);
            this.btnHomeStore.Name = "btnHomeStore";
            this.btnHomeStore.Size = new System.Drawing.Size(173, 33);
            this.btnHomeStore.TabIndex = 271;
            this.btnHomeStore.TabStop = false;
            this.btnHomeStore.Text = "Browse Store";
            this.btnHomeStore.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Small", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(34, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 57);
            this.label1.TabIndex = 266;
            this.label1.Text = "Discover plugins to unlock Windows 11 installation on unsupported hardware.";
            // 
            // panelHome
            // 
            this.panelHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHome.AutoScroll = true;
            this.panelHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panelHome.Controls.Add(this.assetChevronDown);
            this.panelHome.Controls.Add(this.btnDropdown);
            this.panelHome.Controls.Add(this.panelOptions);
            this.panelHome.Controls.Add(this.btnSettings);
            this.panelHome.Controls.Add(this.assetInfo);
            this.panelHome.Controls.Add(this.lblSubHeader);
            this.panelHome.Location = new System.Drawing.Point(48, 20);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(498, 231);
            this.panelHome.TabIndex = 1;
            this.panelHome.TabStop = true;
            // 
            // assetChevronDown
            // 
            this.assetChevronDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.assetChevronDown.AutoEllipsis = true;
            this.assetChevronDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.assetChevronDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assetChevronDown.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10.25F);
            this.assetChevronDown.ForeColor = System.Drawing.Color.White;
            this.assetChevronDown.Location = new System.Drawing.Point(436, 123);
            this.assetChevronDown.Name = "assetChevronDown";
            this.assetChevronDown.Size = new System.Drawing.Size(30, 30);
            this.assetChevronDown.TabIndex = 308;
            this.assetChevronDown.Text = "...";
            this.assetChevronDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDropdown
            // 
            this.btnDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDropdown.AutoEllipsis = true;
            this.btnDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnDropdown.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDropdown.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnDropdown.FlatAppearance.BorderSize = 0;
            this.btnDropdown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btnDropdown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btnDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDropdown.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 11.5F, System.Drawing.FontStyle.Bold);
            this.btnDropdown.ForeColor = System.Drawing.Color.White;
            this.btnDropdown.Location = new System.Drawing.Point(34, 115);
            this.btnDropdown.Name = "btnDropdown";
            this.btnDropdown.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDropdown.Size = new System.Drawing.Size(440, 43);
            this.btnDropdown.TabIndex = 307;
            this.btnDropdown.TabStop = false;
            this.btnDropdown.Text = "Choose";
            this.btnDropdown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDropdown.UseVisualStyleBackColor = false;
            // 
            // panelOptions
            // 
            this.panelOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOptions.BackColor = System.Drawing.Color.Transparent;
            this.panelOptions.Controls.Add(this.btnOption4);
            this.panelOptions.Controls.Add(this.btnOption3);
            this.panelOptions.Controls.Add(this.btnOption2);
            this.panelOptions.Controls.Add(this.btnOption1);
            this.panelOptions.Location = new System.Drawing.Point(38, 164);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(440, 143);
            this.panelOptions.TabIndex = 305;
            this.panelOptions.Visible = false;
            // 
            // btnOption4
            // 
            this.btnOption4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOption4.AutoEllipsis = true;
            this.btnOption4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnOption4.FlatAppearance.BorderColor = System.Drawing.Color.Orchid;
            this.btnOption4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnOption4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption4.Font = new System.Drawing.Font("Segoe UI Variable Small", 11.25F);
            this.btnOption4.ForeColor = System.Drawing.Color.White;
            this.btnOption4.Location = new System.Drawing.Point(9, 103);
            this.btnOption4.Margin = new System.Windows.Forms.Padding(4);
            this.btnOption4.Name = "btnOption4";
            this.btnOption4.Size = new System.Drawing.Size(427, 30);
            this.btnOption4.TabIndex = 274;
            this.btnOption4.TabStop = false;
            this.btnOption4.Text = "Option4";
            this.btnOption4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOption4.UseVisualStyleBackColor = false;
            // 
            // btnOption3
            // 
            this.btnOption3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOption3.AutoEllipsis = true;
            this.btnOption3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnOption3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOption3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnOption3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption3.Font = new System.Drawing.Font("Segoe UI Variable Small", 11.25F);
            this.btnOption3.ForeColor = System.Drawing.Color.White;
            this.btnOption3.Location = new System.Drawing.Point(9, 70);
            this.btnOption3.Margin = new System.Windows.Forms.Padding(4);
            this.btnOption3.Name = "btnOption3";
            this.btnOption3.Size = new System.Drawing.Size(427, 30);
            this.btnOption3.TabIndex = 273;
            this.btnOption3.TabStop = false;
            this.btnOption3.Text = "Option3";
            this.btnOption3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOption3.UseVisualStyleBackColor = false;
            // 
            // btnOption2
            // 
            this.btnOption2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOption2.AutoEllipsis = true;
            this.btnOption2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnOption2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOption2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnOption2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption2.Font = new System.Drawing.Font("Segoe UI Variable Small", 11.25F);
            this.btnOption2.ForeColor = System.Drawing.Color.White;
            this.btnOption2.Location = new System.Drawing.Point(9, 37);
            this.btnOption2.Margin = new System.Windows.Forms.Padding(4);
            this.btnOption2.Name = "btnOption2";
            this.btnOption2.Size = new System.Drawing.Size(427, 30);
            this.btnOption2.TabIndex = 272;
            this.btnOption2.TabStop = false;
            this.btnOption2.Text = "Option2";
            this.btnOption2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOption2.UseVisualStyleBackColor = false;
            // 
            // btnOption1
            // 
            this.btnOption1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOption1.AutoEllipsis = true;
            this.btnOption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnOption1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOption1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnOption1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption1.Font = new System.Drawing.Font("Segoe UI Variable Small", 11.25F);
            this.btnOption1.ForeColor = System.Drawing.Color.White;
            this.btnOption1.Location = new System.Drawing.Point(9, 4);
            this.btnOption1.Margin = new System.Windows.Forms.Padding(4);
            this.btnOption1.Name = "btnOption1";
            this.btnOption1.Size = new System.Drawing.Size(427, 30);
            this.btnOption1.TabIndex = 271;
            this.btnOption1.TabStop = false;
            this.btnOption1.Text = "Option1";
            this.btnOption1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOption1.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            this.btnSettings.AutoSize = true;
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI Variable Small", 10.25F);
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(238)))));
            this.btnSettings.Location = new System.Drawing.Point(34, 71);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(123, 29);
            this.btnSettings.TabIndex = 303;
            this.btnSettings.TabStop = false;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // assetInfo
            // 
            this.assetInfo.AutoEllipsis = true;
            this.assetInfo.AutoSize = true;
            this.assetInfo.BackColor = System.Drawing.Color.Transparent;
            this.assetInfo.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11.75F);
            this.assetInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(203)))));
            this.assetInfo.Location = new System.Drawing.Point(8, 28);
            this.assetInfo.Name = "assetInfo";
            this.assetInfo.Size = new System.Drawing.Size(16, 16);
            this.assetInfo.TabIndex = 302;
            this.assetInfo.Text = "...";
            this.assetInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubHeader
            // 
            this.lblSubHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubHeader.AutoEllipsis = true;
            this.lblSubHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblSubHeader.Font = new System.Drawing.Font("Segoe UI Variable Small", 9.25F);
            this.lblSubHeader.ForeColor = System.Drawing.Color.White;
            this.lblSubHeader.Location = new System.Drawing.Point(34, 24);
            this.lblSubHeader.Name = "lblSubHeader";
            this.lblSubHeader.Size = new System.Drawing.Size(445, 49);
            this.lblSubHeader.TabIndex = 266;
            this.lblSubHeader.Text = "Level up Windows 11 privacy and personalization, declutter by removing bloatware," +
    " and supercharge functionality with community plugins.";
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Variable Small", 14.5F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(147, 7);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(262, 26);
            this.lblHeader.TabIndex = 301;
            this.lblHeader.Text = "Set up Windows 11";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panelMain);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 40);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(584, 621);
            this.panelContainer.TabIndex = 105;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelTop.Controls.Add(this.btnHome);
            this.panelTop.Controls.Add(this.btnBack);
            this.panelTop.Controls.Add(this.btnLogger);
            this.panelTop.Controls.Add(this.lblHeader);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(584, 40);
            this.panelTop.TabIndex = 277;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(584, 661);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTop);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bloatynosy";
            this.panelMain.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelFAQ.ResumeLayout(false);
            this.panelFAQ.PerformLayout();
            this.panelPlugins.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.panelOptions.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lblSubHeader;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btnLogger;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Panel panelPlugins;
        private System.Windows.Forms.Button btnHomeStore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelFAQ;
        private System.Windows.Forms.LinkLabel linkAppDev;
        public System.Windows.Forms.Button btnStore;
        public System.Windows.Forms.Button btnPlugins;
        private System.Windows.Forms.Button btnDumputer;
        private System.Windows.Forms.Button btnExperience;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label border;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.LinkLabel linkShare;
        private System.Windows.Forms.Label assetInfo;
        private System.Windows.Forms.Button btnCloseFAQ;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnDropdown;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Button btnOption4;
        private System.Windows.Forms.Button btnOption3;
        private System.Windows.Forms.Button btnOption2;
        private System.Windows.Forms.Button btnOption1;
        private System.Windows.Forms.Label assetChevronDown;
        private System.Windows.Forms.Label assetChevronRight1;
        private System.Windows.Forms.Label assetChevronRight2;
        private System.Windows.Forms.Label assetChevronRight3;
        private System.Windows.Forms.Label assetChevronRight4;
    }
}

