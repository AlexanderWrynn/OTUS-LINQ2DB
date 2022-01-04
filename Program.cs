using System;
using System.Linq;

namespace OTUS_LINQ2DB
{
    class Program
    {
        static void Main(string[] args)
        {
            string SqlConnectionString = "User ID=postgres;Password=OtusWrynn;Host=localhost;Port=5432;Database=dvdrental;";

            using (var database = new LinqToDB.Data.DataConnection(LinqToDB.ProviderName.PostgreSQL, SqlConnectionString))
            {
                var actorTable = database.GetTable<Actor>();
                var categoryTable = database.GetTable<Category>();
                var countryTable = database.GetTable<CountryTable>();

                var actorList = actorTable
                    .Where(x => x.First_name.Contains("S"))
                    .OrderByDescending(x => x.First_name)
                    .Take(10)
                    .ToList();

                var categoryList = categoryTable
                    .Where(x => x.Category_id % 2 == 0)
                    .GroupBy(x => x.Name.Contains("z"))
                    .ToList();

                foreach (var actor in actorList)
                {
                    Console.WriteLine(
                        $"ID: {actor.Actor_id}, " +
                        $"first name: {actor.First_name}, " +
                        $"last name: {actor.Last_name}, " +
                        $"last update {actor.Last_update}"
                        );
                }

                Console.WriteLine("-----------------");
                Console.WriteLine(categoryList.Count());
                Console.WriteLine("-----------------");

                var countryList = countryTable
                    .Where(x => x.Country.Contains("United"))
                    .Select(x => x)
                    .Take(5);

                foreach (var country in countryList)
                {
                    Console.WriteLine($"ID: {country.Country_id}, country: {country.Country}");
                }
            }

            Console.ReadLine();
        }
    }
}
