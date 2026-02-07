using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_LibraryManagement.Patterns.Singleton
{
    public class DatabaseConnection
    {
        private static DatabaseConnection _instance;
        private static readonly object _lock = new object();

        private DatabaseConnection()
        {
            Console.WriteLine("Database connection established.");
        }

        public static DatabaseConnection GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DatabaseConnection();
                    }
                }
            }

            return _instance;
        }

        public void ExecuteQuery(string sql)
        {
            Console.WriteLine($"Executing SQL: {sql}");
        }
    }
}
