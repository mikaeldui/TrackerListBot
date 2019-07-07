using System;
using System.Linq;
using System.Collections.Generic;
using MonoTorrent.Client.Tracker;
using MonoTorrent.Common;
using System.Threading.Tasks;

namespace TrackerList.BitTorrent
{
    public static class TrackerHealthChecker
    {
        public static async Task<string[]> CheckTrackersAsync(IEnumerable<string> trackerUris)
        {
            List<string> healthyTrackers = new List<string>();

            foreach(var trackerUri in trackerUris)
            {
                if (await IsTrackerHealthyAsync(trackerUri))
                    healthyTrackers.Add(trackerUri);
            }

            return healthyTrackers.ToArray();
        }

        public static async Task<bool> IsTrackerHealthyAsync(string trackerUri)
        {
            var tracker = TrackerFactory.Create(new Uri(trackerUri));

            try
            {
                switch (tracker)
                {
                    case HTTPTracker httpTracker:
                        await httpTracker.AnnounceAsync(new AnnounceParameters(0, 0, 0, TorrentEvent.None, new MonoTorrent.InfoHash(StringToByteArray("4b3dbca85d0f67742bdf4bcece6641799f29efbe")), false, "", "", 0));
                        break;
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }
    }
}
