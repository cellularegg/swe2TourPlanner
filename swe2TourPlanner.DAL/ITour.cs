using System;
using System.Collections.Generic;

namespace swe2TourPlanner.DAL
{
    public interface ITour
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public double TourDistanceInKm { get; set; }
        public List<ITourLog> Logs { get; set; }
        
    }
}