using System;

namespace TrackerList.Bot
{
    class Program
    {
        static void Main(string[] args)
        {

            var allTrackers = TrackerStorage.GetAllTrackers();

            TrackerChecker.CheckTrackers(allTrackers);

            var trackerSortation = TrackerSorter.SortTrackers(allTrackers);

            TrackerStorage.StoreTrackers(trackerSortation);

            Console.WriteLine("Hello World!");
        }
    }
}
