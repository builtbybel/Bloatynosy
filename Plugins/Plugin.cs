namespace Bloatynosy;

//one tweak pack the store offers. the repo describes it in json, and a pack is installed when
//its ini lies in the data folder, so the folder itself is the list of what is installed.
internal sealed class Plugin
{
    public string File { get; set; } = "";        // the ini name, in the repo and in the data folder
    public string Name { get; set; } = "";        // what the card calls it
    public string Author { get; set; } = "";      // who stands behind it, shown as the publisher
    public string Category { get; set; } = "";    // the category its tweaks will appear under
    public int Count { get; set; }                // how many settings it brings, for the card
    public string Description { get; set; } = ""; // one line, what the pack is for

    //the ini is the whole state: it is there or it is not
    public bool Installed => System.IO.File.Exists(Path.Combine(AppInfo.DataFolder, File));

    //a name off the network may name a file, never a path to somewhere else
    public bool Sound => File.Length > 0 && File == Path.GetFileName(File)
        && File.EndsWith(".ini", StringComparison.OrdinalIgnoreCase);
}
