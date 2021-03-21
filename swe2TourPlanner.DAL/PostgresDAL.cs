using System;
using System.Collections.Generic;
using System.IO;
using Npgsql;
using IniParser;
using IniParser.Model;
using IniParser.Parser;

namespace swe2TourPlanner.DAL
{
    public class PostgresDAL : IDataAccessLayer, IDisposable
    {
        // Singleton: https://csharpindepth.com/Articles/Singleton
        private static readonly PostgresDAL _instance = new PostgresDAL();
        private NpgsqlConnection _conn;

        static PostgresDAL()
        {
        }

        private PostgresDAL()
        {
            Console.WriteLine("singleton ctor called");
            var parser = new IniDataParser();
            string filepath = "..\\..\\..\\..\\config.ini";
            if (!File.Exists(filepath))
            {
                throw new Exception("Error config file is missing or has not all required settings");
            }

            string content = File.ReadAllText(filepath);
            IniData parsedData = parser.Parse(content);
            string host = parsedData["DbConn"]["host"];
            string user = parsedData["DbConn"]["user"];
            string pw = parsedData["DbConn"]["password"];
            string db = parsedData["DbConn"]["database"];
            _conn = new NpgsqlConnection($"Host={host};Username={user};Password={pw};Database={db}");
            _conn.Open();
        }

        // Read only property
        // See: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/expression-bodied-members
        public static PostgresDAL Instance => _instance;

        public List<ITour> GetAllTours()
        {
            throw new System.NotImplementedException();
        }

        public List<ITourLog> GetAllTourLogs()
        {
            List<ITourLog> tourLogs = new List<ITourLog>();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM TOURLOG", _conn);
            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    ITourLog log = new TourLog(dr.GetInt32(0), dr.GetDateTime(1), dr.GetString(2),
                        dr.GetDouble(3), dr.GetTimeSpan(4), dr.GetInt32(5));
                    tourLogs.Add(log);
                }
            }
            return tourLogs;
        }

        public ITour GetTourById(int id)
        {
            throw new NotImplementedException();
        }

        public ITourLog GetTourLogByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool AddTour(ITour tour)
        {
            throw new NotImplementedException();
        }

        public bool AddTourLog(TourLog tourLog)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTour(ITour tour)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTourLog(ITourLog tourLog)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTour(ITour tour)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTourLog(ITourLog tourLog)
        {
            throw new NotImplementedException();
        }


        // Is this the correct way to do this?
        public void Dispose()
        {
            // Implementing IDisposable allows the using(){} statement
            _conn.Close();
        }

        ~PostgresDAL()
        {
            // Deconstructor is called by the Garbage collector
            this.Dispose();
        }
    }
}