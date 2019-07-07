using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using TrackerList.Base;

namespace TrackerList.Git
{
    public class GitTrackerStorage : ITrackerStorage
    {


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
