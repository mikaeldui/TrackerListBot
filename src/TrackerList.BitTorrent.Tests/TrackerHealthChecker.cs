using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace TrackerList.BitTorrent.Tests
{
    [TestClass]
    public class TrackerHealthCheckerTests
    {
        [TestMethod]
        public async Task CheckOpenTrackr()
        {
            const string ipv4HttpTrackerUri = "http://tracker.opentrackr.org:1337/announce";

            Assert.IsTrue(await TrackerHealthChecker.IsTrackerHealthyAsync(ipv4HttpTrackerUri));
        }
    }
}
