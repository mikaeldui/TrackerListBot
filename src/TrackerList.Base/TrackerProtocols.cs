using System;

namespace TrackerList
{
    [Flags]
    public enum TrackerProtocols
    {
        Http,
        Udp,
        Ws
    }
}
