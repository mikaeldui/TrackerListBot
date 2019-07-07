using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerList.Sorting
{
    public class TrackerSorter
    {
        public static IDictionary<TrackerSortDefinition, Tracker[]> SortTrackers(IList<Tracker> trackers, IEnumerable<TrackerSortDefinition> trackerSortDefinitions)
        {
            // Sort the trackers according to some definition.

            Dictionary<TrackerSortDefinition, Tracker[]> sortations = new Dictionary<TrackerSortDefinition, Tracker[]>();

            foreach (var sortDefinition in trackerSortDefinitions)
            {
                sortations.Add(sortDefinition, trackers.Where(t => sortDefinition.ValidationStatement.Invoke(t)).ToArray());
            }

            return sortations;
        }
    }
}
