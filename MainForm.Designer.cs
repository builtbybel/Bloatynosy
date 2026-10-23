namespace Bloatynosy;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.rootTable = new Bloatynosy.Glass();
            this.searchField = new Bloatynosy.SearchField();
            this.headerLine = new System.Windows.Forms.Panel();
            this.navView = new Bloatynosy.NavView();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.hostPanel = new System.Windows.Forms.Panel();
            this.footerLine = new System.Windows.Forms.Panel();
            this.footerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.hintLabel = new System.Windows.Forms.Label();
            this.statusStack = new System.Windows.Forms.TableLayoutPanel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.workBar = new System.Windows.Forms.ProgressBar();
            this.actionButton = new Bloatynosy.AppButton();
            this.rootTable.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.statusStack.SuspendLayout();
            this.SuspendLayout();
            // 
            // rootTable
            // 
            this.rootTable.ColumnCount = 2;
            this.rootTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 268F));
            this.rootTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootTable.Controls.Add(this.searchField, 0, 0);
            this.rootTable.Controls.Add(this.headerLine, 0, 1);
            this.rootTable.Controls.Add(this.navView, 0, 2);
            this.rootTable.Controls.Add(this.contentPanel, 1, 2);
            this.rootTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootTable.Location = new System.Drawing.Point(0, 0);
            this.rootTable.Margin = new System.Windows.Forms.Padding(0);
            this.rootTable.Name = "rootTable";
            this.rootTable.RowCount = 3;
            this.rootTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rootTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.rootTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootTable.Size = new System.Drawing.Size(906, 532);
            this.rootTable.TabIndex = 0;
            // 
            // searchField
            // 
            this.searchField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchField.BackColor = System.Drawing.Color.Transparent;
            this.rootTable.SetColumnSpan(this.searchField, 2);
            this.searchField.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            this.searchField.Location = new System.Drawing.Point(263, 6);
            this.searchField.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.searchField.Name = "searchField";
            this.searchField.Padding = new System.Windows.Forms.Padding(3);
            this.searchField.Size = new System.Drawing.Size(380, 32);
            this.searchField.TabIndex = 0;
            // 
            // headerLine
            // 
            this.headerLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rootTable.SetColumnSpan(this.headerLine, 2);
            this.headerLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerLine.Location = new System.Drawing.Point(0, 44);
            this.headerLine.Margin = new System.Windows.Forms.Padding(0);
            this.headerLine.Name = "headerLine";
            this.headerLine.Size = new System.Drawing.Size(906, 1);
            this.headerLine.TabIndex = 3;
            // 
            // navView
            // 
            this.navView.BackColor = System.Drawing.Color.Transparent;
            this.navView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navView.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            this.navView.Location = new System.Drawing.Point(0, 45);
            this.navView.Margin = new System.Windows.Forms.Padding(0);
            this.navView.Name = "navView";
            this.navView.Size = new System.Drawing.Size(268, 487);
            this.navView.TabIndex = 1;
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.hostPanel);
            this.contentPanel.Controls.Add(this.footerLine);
            this.contentPanel.Controls.Add(this.footerPanel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(268, 45);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(638, 487);
            this.contentPanel.TabIndex = 2;
            // 
            // hostPanel
            // 
            this.hostPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.hostPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostPanel.Location = new System.Drawing.Point(0, 0);
            this.hostPanel.Margin = new System.Windows.Forms.Padding(0);
            this.hostPanel.Name = "hostPanel";
            this.hostPanel.Size = new System.Drawing.Size(638, 382);
            this.hostPanel.TabIndex = 0;
            // 
            // footerLine
            // 
            this.footerLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.footerLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerLine.Location = new System.Drawing.Point(0, 382);
            this.footerLine.Margin = new System.Windows.Forms.Padding(0);
            this.footerLine.Name = "footerLine";
            this.footerLine.Size = new System.Drawing.Size(638, 1);
            this.footerLine.TabIndex = 1;
            // 
            // footerPanel
            // 
            this.footerPanel.AutoSize = true;
            this.footerPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.footerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.footerPanel.ColumnCount = 2;
            this.footerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.footerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.footerPanel.Controls.Add(this.hintLabel, 0, 0);
            this.footerPanel.Controls.Add(this.statusStack, 0, 1);
            this.footerPanel.Controls.Add(this.actionButton, 1, 1);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 383);
            this.footerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Padding = new System.Windows.Forms.Padding(28, 14, 28, 14);
            this.footerPanel.RowCount = 2;
            this.footerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.footerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.footerPanel.Size = new System.Drawing.Size(638, 104);
            this.footerPanel.TabIndex = 2;
            // 
            // hintLabel
            // 
            this.hintLabel.AutoEllipsis = true;
            this.footerPanel.SetColumnSpan(this.hintLabel, 2);
            this.hintLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hintLabel.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            this.hintLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.hintLabel.Location = new System.Drawing.Point(28, 14);
            this.hintLabel.Margin = new System.Windows.Forms.Padding(0);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(582, 26);
            this.hintLabel.TabIndex = 0;
            this.hintLabel.Text = "Checking does not change anything on your PC.";
            this.hintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStack
            // 
            this.statusStack.AutoSize = true;
            this.statusStack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.statusStack.ColumnCount = 1;
            this.statusStack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.statusStack.Controls.Add(this.statusLabel, 0, 0);
            this.statusStack.Controls.Add(this.workBar, 0, 1);
            this.statusStack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStack.Location = new System.Drawing.Point(28, 40);
            this.statusStack.Margin = new System.Windows.Forms.Padding(0);
            this.statusStack.Name = "statusStack";
            this.statusStack.RowCount = 2;
            this.statusStack.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statusStack.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statusStack.Size = new System.Drawing.Size(432, 50);
            this.statusStack.TabIndex = 1;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoEllipsis = true;
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 10F);
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.statusLabel.Location = new System.Drawing.Point(0, 0);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(432, 34);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Nothing selected";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // workBar
            // 
            this.workBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workBar.Location = new System.Drawing.Point(0, 34);
            this.workBar.Margin = new System.Windows.Forms.Padding(0);
            this.workBar.MarqueeAnimationSpeed = 25;
            this.workBar.MaximumSize = new System.Drawing.Size(0, 4);
            this.workBar.Name = "workBar";
            this.workBar.Size = new System.Drawing.Size(432, 4);
            this.workBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.workBar.TabIndex = 1;
            this.workBar.Visible = false;
            // 
            // actionButton
            // 
            this.actionButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.actionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.actionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionButton.Filled = true;
            this.actionButton.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            this.actionButton.Location = new System.Drawing.Point(476, 48);
            this.actionButton.Margin = new System.Windows.Forms.Padding(16, 8, 0, 8);
            this.actionButton.MinimumSize = new System.Drawing.Size(0, 34);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(134, 34);
            this.actionButton.TabIndex = 2;
            this.actionButton.Text = "Check PC";
            this.actionButton.Click += new System.EventHandler(this.Action);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(906, 532);
            this.Controls.Add(this.rootTable);
            this.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            this.MinimumSize = new System.Drawing.Size(816, 460);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bloatynosy";
            this.rootTable.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.footerPanel.ResumeLayout(false);
            this.footerPanel.PerformLayout();
            this.statusStack.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    private Bloatynosy.Glass rootTable;
    private Bloatynosy.SearchField searchField;
    private System.Windows.Forms.Panel headerLine;
    private Bloatynosy.NavView navView;
    private System.Windows.Forms.Panel contentPanel;
    private System.Windows.Forms.Panel hostPanel;
    private System.Windows.Forms.Panel footerLine;
    private System.Windows.Forms.TableLayoutPanel footerPanel;
    private System.Windows.Forms.Label hintLabel;
    private System.Windows.Forms.TableLayoutPanel statusStack;
    private System.Windows.Forms.Label statusLabel;
    private System.Windows.Forms.ProgressBar workBar;
    private Bloatynosy.AppButton actionButton;
}
