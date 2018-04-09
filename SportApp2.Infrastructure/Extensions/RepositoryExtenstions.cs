using SportApp2.Core.Domain;
using SportApp2.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SportApp2.Infrastructure.Extensions
{
    public static class RepositoryExtenstions
    {
        public static async Task<Food> GetOrFailAsync(this IFoodRepository repository, Guid id)
        {
            var @food = await repository.GetAsync(id);
            if (@food == null)
            {
                throw new Exception($"Food with id: '{id}' does not exist.");
            }

            return @food;
        }

        public static async Task<FoodType> GetFoodTypeOrFailAsync(this IFoodTypeRepository repository, Guid id)
        {
            var @food = await repository.GetAsync(id);
            if (@food == null)
            {
                throw new Exception($"Food type with id: '{id}' does not exist.");
            }

            return @food;
        }
    }
}
