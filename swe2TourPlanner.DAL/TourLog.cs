using System;

namespace swe2TourPlanner.DAL
{
    public class TourLog : ITourLog
    {
        public int Id { get; set; }
        public DateTime LogDate { get; set; }
        public string Report { get; set; }
        public double LogDistanceInKm { get; set; }
        public TimeSpan TotalTime { get; set; }
        public int Rating { get; set; }

        public TourLog(int id, DateTime logDate, string report, double logDistanceInKm, TimeSpan totalTime, int rating)
        {
            Id = id;
            LogDate = logDate;
            Report = report;
            LogDistanceInKm = logDistanceInKm;
            TotalTime = totalTime;
            Rating = rating;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(LogDate)}: {LogDate}, {nameof(Report)}: {Report}, {nameof(LogDistanceInKm)}: {LogDistanceInKm}, {nameof(TotalTime)}: {TotalTime}, {nameof(Rating)}: {Rating}";
        }
    }
}