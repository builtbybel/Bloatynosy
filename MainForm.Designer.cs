namespace Bloatynosy;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.rootTable = new Bloatynosy.Glass();
            this.backChip = new System.Windows.Forms.Button();
            this.settingsChip = new System.Windows.Forms.Button();
            this.topCard = new Bloatynosy.Card();
            this.hostPanel = new System.Windows.Forms.Panel();
            this.bottomCard = new Bloatynosy.Card();
            this.footTable = new System.Windows.Forms.TableLayoutPanel();
            this.footPanel = new System.Windows.Forms.Panel();
            this.linksPanel = new System.Windows.Forms.TableLayoutPanel();
            this.detailsLink = new System.Windows.Forms.LinkLabel();
            this.explainLink = new System.Windows.Forms.LinkLabel();
            this.stepStrip = new System.Windows.Forms.TableLayoutPanel();
            this.stepOne = new System.Windows.Forms.Panel();
            this.stepTwo = new System.Windows.Forms.Panel();
            this.stepThree = new System.Windows.Forms.Panel();
            this.workBar = new System.Windows.Forms.ProgressBar();
            this.statusLabel = new System.Windows.Forms.Label();
            this.actionButton = new Bloatynosy.Flat();
            this.footerDetail = new System.Windows.Forms.TextBox();
            this.hintLabel = new System.Windows.Forms.Label();
            this.rootTable.SuspendLayout();
            this.topCard.SuspendLayout();
            this.bottomCard.SuspendLayout();
            this.footTable.SuspendLayout();
            this.footPanel.SuspendLayout();
            this.linksPanel.SuspendLayout();
            this.stepStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // rootTable
            // 
            this.rootTable.ColumnCount = 3;
            this.rootTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.rootTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.rootTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.rootTable.Controls.Add(this.backChip, 0, 0);
            this.rootTable.Controls.Add(this.settingsChip, 2, 0);
            this.rootTable.Controls.Add(this.topCard, 1, 1);
            this.rootTable.Controls.Add(this.bottomCard, 1, 2);
            this.rootTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootTable.Location = new System.Drawing.Point(0, 0);
            this.rootTable.Name = "rootTable";
            this.rootTable.RowCount = 3;
            this.rootTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.rootTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.rootTable.Size = new System.Drawing.Size(906, 532);
            this.rootTable.TabIndex = 0;
            // 
            // backChip
            // 
            this.backChip.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.backChip.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.backChip.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.backChip.Font = new System.Drawing.Font("Segoe Fluent Icons", 11F);
            this.backChip.Location = new System.Drawing.Point(12, 6);
            this.backChip.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.backChip.Name = "backChip";
            this.backChip.Size = new System.Drawing.Size(32, 32);
            this.backChip.TabIndex = 0;
            this.backChip.Text = "";
            this.backChip.Visible = false;
            this.backChip.Click += new System.EventHandler(this.Back);
            // 
            // settingsChip
            // 
            this.settingsChip.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.settingsChip.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.settingsChip.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.settingsChip.Font = new System.Drawing.Font("Segoe Fluent Icons", 11F);
            this.settingsChip.Location = new System.Drawing.Point(862, 6);
            this.settingsChip.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.settingsChip.Name = "settingsChip";
            this.settingsChip.Size = new System.Drawing.Size(32, 32);
            this.settingsChip.TabIndex = 2;
            this.settingsChip.Text = "";
            this.settingsChip.Click += new System.EventHandler(this.Settings);
            // 
            // topCard
            // 
            this.topCard.Controls.Add(this.hostPanel);
            this.topCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topCard.Location = new System.Drawing.Point(90, 44);
            this.topCard.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.topCard.Name = "topCard";
            this.topCard.Padding = new System.Windows.Forms.Padding(28, 20, 28, 22);
            this.topCard.Size = new System.Drawing.Size(724, 348);
            this.topCard.TabIndex = 1;
            // 
            // hostPanel
            // 
            this.hostPanel.BackColor = System.Drawing.Color.White;
            this.hostPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostPanel.Location = new System.Drawing.Point(28, 20);
            this.hostPanel.Name = "hostPanel";
            this.hostPanel.Size = new System.Drawing.Size(668, 306);
            this.hostPanel.TabIndex = 0;
            // 
            // bottomCard
            // 
            this.bottomCard.Controls.Add(this.footTable);
            this.bottomCard.Controls.Add(this.footerDetail);
            this.bottomCard.Controls.Add(this.hintLabel);
            this.bottomCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomCard.Location = new System.Drawing.Point(90, 402);
            this.bottomCard.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.bottomCard.Name = "bottomCard";
            this.bottomCard.Padding = new System.Windows.Forms.Padding(28, 14, 28, 14);
            this.bottomCard.Size = new System.Drawing.Size(724, 114);
            this.bottomCard.TabIndex = 2;
            // 
            // footTable
            // 
            this.footTable.BackColor = System.Drawing.Color.White;
            this.footTable.ColumnCount = 2;
            this.footTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.footTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.footTable.Controls.Add(this.footPanel, 0, 0);
            this.footTable.Controls.Add(this.actionButton, 1, 0);
            this.footTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.footTable.Location = new System.Drawing.Point(28, 40);
            this.footTable.Name = "footTable";
            this.footTable.RowCount = 1;
            this.footTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.footTable.Size = new System.Drawing.Size(668, 0);
            this.footTable.TabIndex = 0;
            // 
            // footPanel
            // 
            this.footPanel.BackColor = System.Drawing.Color.White;
            this.footPanel.Controls.Add(this.linksPanel);
            this.footPanel.Controls.Add(this.stepStrip);
            this.footPanel.Controls.Add(this.workBar);
            this.footPanel.Controls.Add(this.statusLabel);
            this.footPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.footPanel.Location = new System.Drawing.Point(0, 0);
            this.footPanel.Margin = new System.Windows.Forms.Padding(0);
            this.footPanel.Name = "footPanel";
            this.footPanel.Size = new System.Drawing.Size(518, 1);
            this.footPanel.TabIndex = 0;
            // 
            // linksPanel
            // 
            this.linksPanel.BackColor = System.Drawing.Color.White;
            this.linksPanel.ColumnCount = 2;
            this.linksPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.linksPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.linksPanel.Controls.Add(this.detailsLink, 0, 0);
            this.linksPanel.Controls.Add(this.explainLink, 1, 0);
            this.linksPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linksPanel.Location = new System.Drawing.Point(0, -21);
            this.linksPanel.Name = "linksPanel";
            this.linksPanel.RowCount = 1;
            this.linksPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.linksPanel.Size = new System.Drawing.Size(518, 22);
            this.linksPanel.TabIndex = 2;
            // 
            // detailsLink
            // 
            this.detailsLink.BackColor = System.Drawing.Color.White;
            this.detailsLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.detailsLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsLink.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.detailsLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.detailsLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            this.detailsLink.Location = new System.Drawing.Point(0, 0);
            this.detailsLink.Margin = new System.Windows.Forms.Padding(0);
            this.detailsLink.Name = "detailsLink";
            this.detailsLink.Size = new System.Drawing.Size(259, 22);
            this.detailsLink.TabIndex = 2;
            this.detailsLink.TabStop = true;
            this.detailsLink.Text = "Show details";
            this.detailsLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.detailsLink.Visible = false;
            this.detailsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DetailsLinkClicked);
            // 
            // explainLink
            // 
            this.explainLink.BackColor = System.Drawing.Color.White;
            this.explainLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.explainLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explainLink.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.explainLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.explainLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            this.explainLink.Location = new System.Drawing.Point(259, 0);
            this.explainLink.Margin = new System.Windows.Forms.Padding(0);
            this.explainLink.Name = "explainLink";
            this.explainLink.Size = new System.Drawing.Size(259, 22);
            this.explainLink.TabIndex = 3;
            this.explainLink.TabStop = true;
            this.explainLink.Text = "Explain with AI";
            this.explainLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.explainLink.Visible = false;
            this.explainLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ExplainClicked);
            // 
            // stepStrip
            // 
            this.stepStrip.BackColor = System.Drawing.Color.White;
            this.stepStrip.ColumnCount = 3;
            this.stepStrip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.stepStrip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.stepStrip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.stepStrip.Controls.Add(this.stepOne, 0, 0);
            this.stepStrip.Controls.Add(this.stepTwo, 1, 0);
            this.stepStrip.Controls.Add(this.stepThree, 2, 0);
            this.stepStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.stepStrip.Location = new System.Drawing.Point(0, 40);
            this.stepStrip.Margin = new System.Windows.Forms.Padding(0);
            this.stepStrip.Name = "stepStrip";
            this.stepStrip.RowCount = 1;
            this.stepStrip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.stepStrip.Size = new System.Drawing.Size(518, 14);
            this.stepStrip.TabIndex = 0;
            // 
            // stepOne
            // 
            this.stepOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(230)))));
            this.stepOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stepOne.Location = new System.Drawing.Point(0, 8);
            this.stepOne.Margin = new System.Windows.Forms.Padding(0, 8, 8, 2);
            this.stepOne.Name = "stepOne";
            this.stepOne.Size = new System.Drawing.Size(164, 4);
            this.stepOne.TabIndex = 0;
            // 
            // stepTwo
            // 
            this.stepTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(230)))));
            this.stepTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stepTwo.Location = new System.Drawing.Point(172, 8);
            this.stepTwo.Margin = new System.Windows.Forms.Padding(0, 8, 8, 2);
            this.stepTwo.Name = "stepTwo";
            this.stepTwo.Size = new System.Drawing.Size(164, 4);
            this.stepTwo.TabIndex = 1;
            // 
            // stepThree
            // 
            this.stepThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(230)))));
            this.stepThree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stepThree.Location = new System.Drawing.Point(344, 8);
            this.stepThree.Margin = new System.Windows.Forms.Padding(0, 8, 0, 2);
            this.stepThree.Name = "stepThree";
            this.stepThree.Size = new System.Drawing.Size(174, 4);
            this.stepThree.TabIndex = 2;
            // 
            // workBar
            // 
            this.workBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.workBar.Location = new System.Drawing.Point(0, 34);
            this.workBar.MarqueeAnimationSpeed = 25;
            this.workBar.Name = "workBar";
            this.workBar.Size = new System.Drawing.Size(518, 6);
            this.workBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.workBar.TabIndex = 3;
            this.workBar.Visible = false;
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.Color.White;
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.statusLabel.Location = new System.Drawing.Point(0, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(518, 34);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Step 1 of 3 · Check";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // actionButton
            // 
            this.actionButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.actionButton.BackColor = System.Drawing.Color.White;
            this.actionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.actionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.actionButton.Location = new System.Drawing.Point(534, 8);
            this.actionButton.Margin = new System.Windows.Forms.Padding(16, 8, 0, 8);
            this.actionButton.MinimumSize = new System.Drawing.Size(0, 34);
            this.actionButton.Muted = false;
            this.actionButton.Name = "actionButton";
            this.actionButton.OnSky = false;
            this.actionButton.Size = new System.Drawing.Size(134, 34);
            this.actionButton.TabIndex = 1;
            this.actionButton.Text = "Check PC";
            this.actionButton.Click += new System.EventHandler(this.Action);
            // 
            // footerDetail
            // 
            this.footerDetail.BackColor = System.Drawing.Color.White;
            this.footerDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.footerDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerDetail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.footerDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.footerDetail.Location = new System.Drawing.Point(28, 28);
            this.footerDetail.Multiline = true;
            this.footerDetail.Name = "footerDetail";
            this.footerDetail.ReadOnly = true;
            this.footerDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.footerDetail.Size = new System.Drawing.Size(668, 72);
            this.footerDetail.TabIndex = 1;
            this.footerDetail.TabStop = false;
            this.footerDetail.Text = "Select an entry to see its details.";
            this.footerDetail.Visible = false;
            // 
            // hintLabel
            // 
            this.hintLabel.AutoEllipsis = true;
            this.hintLabel.BackColor = System.Drawing.Color.White;
            this.hintLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.hintLabel.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(77)))), ((int)(((byte)(86)))));
            this.hintLabel.Location = new System.Drawing.Point(28, 14);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(668, 26);
            this.hintLabel.TabIndex = 0;
            this.hintLabel.Text = "Checking does not change anything on your PC.";
            this.hintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(906, 532);
            this.Controls.Add(this.rootTable);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(640, 440);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bloatynosy Origin";
            this.rootTable.ResumeLayout(false);
            this.topCard.ResumeLayout(false);
            this.bottomCard.ResumeLayout(false);
            this.bottomCard.PerformLayout();
            this.footTable.ResumeLayout(false);
            this.footPanel.ResumeLayout(false);
            this.linksPanel.ResumeLayout(false);
            this.stepStrip.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    private Bloatynosy.Glass rootTable;
    private System.Windows.Forms.Button backChip;
    private Bloatynosy.Card topCard;
    private System.Windows.Forms.Panel hostPanel;
    private Bloatynosy.Card bottomCard;
    private System.Windows.Forms.Label hintLabel;
    private System.Windows.Forms.TextBox footerDetail;
    private System.Windows.Forms.TableLayoutPanel footTable;
    private System.Windows.Forms.Panel footPanel;
    private System.Windows.Forms.TableLayoutPanel linksPanel;
    private System.Windows.Forms.Button settingsChip;
    private System.Windows.Forms.LinkLabel detailsLink;
    private System.Windows.Forms.LinkLabel explainLink;
    private System.Windows.Forms.Label statusLabel;
    private System.Windows.Forms.TableLayoutPanel stepStrip;
    private System.Windows.Forms.Panel stepOne;
    private System.Windows.Forms.Panel stepTwo;
    private System.Windows.Forms.Panel stepThree;
    private System.Windows.Forms.ProgressBar workBar;
    private Bloatynosy.Flat actionButton;
}

