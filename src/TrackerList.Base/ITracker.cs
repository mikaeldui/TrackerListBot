using System;

namespace TrackerList.Base
{
    public interface ITracker
    {
        Uri Uri { get; }
        TrackerState State { get; }
        TrackerProtocols Protocols { get; }
    }
}
