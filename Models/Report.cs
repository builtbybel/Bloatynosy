namespace Bloatynosy;

//what came out of one run of the applier
internal sealed class Report
{
    public int Fixed;                         // settings written
    public int Reset;                         // settings put back
    public int Removed;                       // apps uninstalled
    public int Started;                       // uninstallers called, whose outcome is the maker's own
    public List<string> Failed = new();       // titles, the wording the user just read in the list
    public bool NeedsAdmin;                   // something needed rights this user has not got
    public List<string> Restart = new();      // what the ini wants restarted, each one once
    //how this pc stands after the run, not what this run touched, so a profile saved from
    //a report describes the finished machine even when most of it was already right
    public Profile Reached = new();
}
