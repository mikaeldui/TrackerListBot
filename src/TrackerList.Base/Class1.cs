using System;

namespace TrackerList
{

    /// <summary>
    /// A sorting rule for trackers. E.g. "IPv6 only".
    /// </summary>
    public interface ITrackerSortation
    {
        string Name { get; }
        Func<ITracker, bool> Requirement { get; }
    }
}
