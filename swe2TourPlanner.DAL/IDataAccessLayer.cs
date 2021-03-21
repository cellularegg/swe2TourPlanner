using System.Collections.Generic;
using System.Reflection;

namespace swe2TourPlanner.DAL
{
    public interface IDataAccessLayer
    {
        public List<ITour> GetAllTours();
        public List<ITourLog> GetAllTourLogs();

        public ITour GetTourById(int id);
        public ITourLog GetTourLogByID(int id);

        public bool AddTour(ITour tour);
        public bool AddTourLog(TourLog tourLog);
        
        public bool UpdateTour(ITour tour);
        public bool UpdateTourLog(ITourLog tourLog);

        public bool DeleteTour(ITour tour);
        public bool DeleteTourLog(ITourLog tourLog);
    }
}