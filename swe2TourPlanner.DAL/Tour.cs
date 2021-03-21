using System.Collections.Generic;
using System.Text;

namespace swe2TourPlanner.DAL
{
    public class Tour : ITour
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public double TourDistanceInKm { get; set; }
        public List<ITourLog> Logs { get; set; }

        public Tour(int id, string name, string description, string imagePath, double tourDistanceInKm)
        {
            Id = id;
            Name = name;
            Description = description;
            ImagePath = imagePath;
            TourDistanceInKm = tourDistanceInKm;
            Logs = new List<ITourLog>();
        }

        public Tour(int id, string name, string description, string imagePath, double tourDistanceInKm, List<ITourLog> logs)
        {
            Id = id;
            Name = name;
            Description = description;
            ImagePath = imagePath;
            TourDistanceInKm = tourDistanceInKm;
            Logs = logs;
        }


        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Description)}: {Description}, {nameof(ImagePath)}: {ImagePath}, {nameof(TourDistanceInKm)}: {TourDistanceInKm}, {nameof(Logs)}: {Logs}";
        }
    }
}