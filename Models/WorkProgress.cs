namespace Bloatynosy;

//one update for the command bar: where the work stands and what is happening now.
internal readonly struct WorkProgress
{
    public int Completed { get; }      // steps already done
    public int Total { get; }          // steps counted before the work started
    public string Text { get; }        // the line under the bar
    public bool Indeterminate { get; } // there is nothing to count yet, the bar only moves

    public WorkProgress(int completed, int total, string text, bool indeterminate = false)
    {
        Completed = completed;
        Total = total;
        Text = text;
        Indeterminate = indeterminate;
    }
}
