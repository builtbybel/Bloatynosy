namespace Bloatynosy;

//one pack on the shelf: name, publisher, what it brings, and the one button that acts on it.
//the row knows nothing about the network, it only says that its button was pressed.
internal sealed class PluginRow : TableLayoutPanel
{
    private readonly Plugin _plugin;
    private readonly AppButton _action = new();
    private readonly Label _title = new();
    private readonly Label _lines = new();

    public PluginRow(Plugin plugin)
    {
        _plugin = plugin;
        ColumnCount = 2;
        ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        RowCount = 2;
        AutoSize = true;
        AutoSizeMode = AutoSizeMode.GrowAndShrink;
        Dock = DockStyle.Top;
        BackColor = Color.White;
        Padding = new Padding(0, 0, 0, LogicalToDeviceUnits(14));

        _title.AutoSize = true;
        _title.Font = new Font("Segoe UI Variable Text Semib", 10.5F);
        _title.ForeColor = Color.FromArgb(26, 26, 26);
        _title.Margin = new Padding(0);

        //the publisher line and the bullets stand in one grey block, the way the browser card does
        _lines.AutoSize = true;
        _lines.Font = new Font("Segoe UI Variable Text Semiligh", 9.5F);
        _lines.ForeColor = Color.FromArgb(96, 100, 110);
        _lines.Margin = new Padding(0, LogicalToDeviceUnits(2), 0, 0);

        _action.Size = new Size(LogicalToDeviceUnits(120), LogicalToDeviceUnits(36));
        _action.Margin = new Padding(LogicalToDeviceUnits(12), 0, 0, 0);
        _action.Click += (_, _) => Pressed?.Invoke(this, EventArgs.Empty);

        Controls.Add(_title, 0, 0);
        Controls.Add(_lines, 0, 1);
        Controls.Add(_action, 1, 0);
        SetRowSpan(_action, 2);
        Fill();
    }

    public event EventHandler? Pressed;          // install or remove, the window knows which

    public Plugin Plugin => _plugin;

    //the button is disabled while the window is working, so a pack cannot be fetched twice
    public bool Busy { set { _action.Enabled = !value; } }

    //writes the pack into the row and sets the button to whatever it would do next
    public void Fill()
    {
        _title.Text = _plugin.Name;
        _lines.Text = Loc.Format("Plugin_By", _plugin.Author)
            + Environment.NewLine + Loc.Format("Plugin_Brings", _plugin.Count, _plugin.Category)
            + Environment.NewLine + _plugin.Description;
        _action.Text = _plugin.Installed ? Loc.Get("Plugin_Remove") : Loc.Get("Plugin_Install");
        _action.Filled = !_plugin.Installed;
        _action.Muted = _plugin.Installed;
        _action.Enabled = true;
    }

    //the shelf sits on white, so the row paints nothing of its own behind the labels
    protected override void OnPaintBackground(PaintEventArgs e) => e.Graphics.Clear(BackColor);
}
