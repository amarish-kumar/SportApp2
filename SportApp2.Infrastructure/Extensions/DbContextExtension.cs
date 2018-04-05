using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Newtonsoft.Json;
using SportApp2.Infrastructure.DbContext;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using SportApp2.Core.Domain;

namespace SportApp2.Infrastructure.Extensions
{
    public static class DbContextExtension
    {
        public static bool AllMigrationsApplied(this DatabaseContext context)
        {
            var applied = context.GetService<IHistoryRepository>()
                .GetAppliedMigrations()
                .Select(m => m.MigrationId);

            var total = context.GetService<IMigrationsAssembly>()
                .Migrations
                .Select(m => m.Key);

            return !total.Except(applied).Any();
        }

        public static void EnsureSeeded(this DatabaseContext context)
        {
            if (!context.FoodTypes.Any())
            {
                var types = JsonConvert.DeserializeObject<List<FoodType>>(File.ReadAllText("seed" + Path.DirectorySeparatorChar + "foodType.json"));
                context.AddRange(types);
                context.SaveChanges();
            }

            //Ensure we have some status
            if (!context.Nutrients.Any())
            {
                var nutrients = JsonConvert.DeserializeObject<List<Nutrient>>(File.ReadAllText(@"seed" + Path.DirectorySeparatorChar + "nutrient.json"));
                context.AddRange(nutrients);
                context.SaveChanges();
            }

            //Ensure we create initial Threat List
            if (!context.Foods.Any())
            {
                List<Food> foods = JsonConvert.DeserializeObject<List<Food>>(File.ReadAllText(@"seed" + Path.DirectorySeparatorChar + "food.json"));
                context.Foods.AddRange(foods);
                context.SaveChanges();
            }
        }
    }
}
