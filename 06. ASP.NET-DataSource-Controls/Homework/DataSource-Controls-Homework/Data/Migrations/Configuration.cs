namespace Countries.Data.Migrations
{
    using Data;
    using Microsoft.AspNet.Identity;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<CountriesDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(CountriesDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            var continentsCount = 7;
            var continents = new Continent[continentsCount];
            for (int i = 1; i <= continentsCount; i++)
            {
                continents[i - 1] = new Continent { Id = i, Name = $"Continent {i}" };
            }

            context.Continents.AddOrUpdate(continents);

            var countriesCount = 50;
            var countries = new Country[countriesCount];
            for (int i = 1; i <= countriesCount; i++)
            {
                countries[i - 1] = new Country
                {
                    Id = i,
                    Name = $"Country {i}",
                    ContinentId = (i % continentsCount) + 1,
                    Language = $"Language {i}",
                    Population = i * ((i % 3) + 1)
                };
            }

            context.Countries.AddOrUpdate(countries);

            var townsCount = 300;
            var towns = new Town[townsCount];
            for (int i = 1; i <= townsCount; i++)
            {
                towns[i - 1] = new Town {Id=i, Name = $"Town {i}", CountryId = (i % countriesCount) + 1, Population = i * ((i % 3) + 1) };
            }

            context.Towns.AddOrUpdate(towns);
        }
    }
}
