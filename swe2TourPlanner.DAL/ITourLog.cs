using System;

namespace swe2TourPlanner.DAL
{
    public interface ITourLog
    {
        public int Id { get; set; }
        public DateTime LogDate { get; set; }
        public string Report { get; set; }
        public double LogDistanceInKm { get; set; }
        public TimeSpan TotalTime { get; set; }
        public int Rating { get; set; }
    }
}