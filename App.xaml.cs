using System;
using System.IO;
using HotelBookingApp.Data;

namespace HotelBookingApp
{
    public partial class App : Application
    {
        static BookingDatabase? database;

        public static BookingDatabase Database
        {
            get
            {
                if (database == null)
                {
                    
                    var folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    var dbPath = Path.Combine(folderPath, "BookingDatabase.db3");

                    Console.WriteLine($"Database Path: {dbPath}");

                    
                    database = new BookingDatabase(dbPath);
                    database.InitializeDatabaseAsync().Wait(); 
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }
    }
}
