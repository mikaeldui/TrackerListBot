using System.Linq;

namespace TrackerList.Base
{
    /// <summary>
    /// Provides permanent storage of tracker information.
    /// </summary>
    public interface ITrackerStorage
    {
        /// <summary>
        /// Should return all known trackers, not caring for their state.
        /// </summary>
        ITracker[] GetAllTrackers();

        /// <summary>
        /// Should save the tracker groups however it wants, could be an XML file, HTTP API, Git, etc.
        /// </summary>
        void StoreTrackers(IGrouping<ITrackerSortation, ITracker> trackerGroups);
    }
}
