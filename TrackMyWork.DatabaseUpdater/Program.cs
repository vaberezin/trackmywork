
using Microsoft.EntityFrameworkCore;
using System;
using TrackMyWork.Context;
using TrackMyWork.Migrations;

namespace TrackMyWork.DatabaseUpdater
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--Db-Updater-Module-has-been-Started...--");
            Console.WriteLine("Do You Want to Update Database?");
            Console.WriteLine("Press 'Y' if you sure...");
            Console.WriteLine("<----------------------------------------------->");
            Console.WriteLine("Press Any_button if you don't want to update...");
            string pressedKey = Console.ReadLine();
            DBUpdater(pressedKey);
        }
        static void DBUpdater(string s)
        {
            if (s == "y" || s == "Y")
            {
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("Database will be updated now!");
                Console.WriteLine("Updating the db...");

                ApplicationContextFactory contextFactory = new ApplicationContextFactory();
                ApplicationDbContext db = contextFactory.CreateDbContext(null);
                if (db.Database.CanConnect())
                {
                    try
                    {
                        db.Database.Migrate();
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                    Console.WriteLine("Database has been updated!");
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("------------------------------------------------------------");
                    Console.ReadKey();
                }
                else
                {
                    throw new Exception("Cannot connect to the specified Database.");
                }

            }
            else
            {
                Console.WriteLine("You've chosen not to apply a migration to the DB.");
            }
        }
    }
}


