using System;

namespace TrackerList
{
    public interface ITracker
    {
        Uri Uri { get; }
        TrackerState State { get; }
        TrackerProtocols Protocols { get; }
    }
}
