using System;

namespace TrackerList.Base
{
    [Flags]
    public enum TrackerProtocols
    {
        Http,
        Udp,
        Ws
    }
}
