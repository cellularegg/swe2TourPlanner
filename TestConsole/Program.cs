using System;
using System.Collections.Generic;
using swe2TourPlanner.DAL;
namespace test_console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Separate DAL class or DAO pattern (https://www.baeldung.com/java-dao-pattern)
            PostgresDAL tmp = PostgresDAL.Instance;
            List<ITourLog> myLogs;
            myLogs = PostgresDAL.Instance.GetAllTourLogs();
            foreach (var log in myLogs)
            {
                Console.WriteLine(log);
            }
        }
    }
}