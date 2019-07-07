using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using TrackerList.Base;

namespace TrackerList.Git
{
    public class GitTrackerStorage : ITrackerStorage
    {
        public static IDictionary<TrackerSortDefinition, Tracker[]> SortTrackers(IList<Tracker> trackers, IEnumerable<TrackerSortDefinition> trackerSortDefinitions)
        {
            // Sort the trackers according to some definition.

            Dictionary<TrackerSortDefinition, Tracker[]> sortations = new Dictionary<TrackerSortDefinition, Tracker[]>();

            foreach(var sortDefinition in trackerSortDefinitions)
            {
                sortations.Add(sortDefinition, trackers.Where(t => sortDefinition.ValidationStatement.Invoke(t)).ToArray());
            }

            return sortations;
        }

        public ITracker[] GetAllTrackers()
        {
            throw new NotImplementedException();
        }

        public void StoreTrackers(IGrouping<ITrackerSortation, ITracker> trackerGroups)
        {
            throw new NotImplementedException();
        }
    }
}
