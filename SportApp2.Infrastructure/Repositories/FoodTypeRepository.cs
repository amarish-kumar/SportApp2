using SportApp2.Core.Domain;
using SportApp2.Core.Repositories;
using SportApp2.Infrastructure.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportApp2.Infrastructure.Repositories
{
    public class FoodTypeRepository : IFoodTypeRepository
    {
        private readonly DatabaseContext _dbContext;

        public FoodTypeRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<FoodType> GetAsync(Guid id)
            => await Task.FromResult(_dbContext.FoodTypes.SingleOrDefault(x => x.Id == id));

        public Task<FoodType> GetAsync(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<FoodType>> BrowseAsync(string name = "")
        {
            var foods = _dbContext.FoodTypes.AsEnumerable();
            if (!string.IsNullOrWhiteSpace(name))
            {
                foods = foods.Where(x => x.Name.ToLowerInvariant()
                    .Contains(name.ToLowerInvariant()));
            }

            return await Task.FromResult(foods);
        }

        public async Task AddAsync(FoodType foodType)
        {
            _dbContext.FoodTypes.Add(@foodType);
            await Task.CompletedTask;
        }

        public async Task UpdateAsync(FoodType foodType)
            => await Task.CompletedTask;


        public async Task DeleteAsync(FoodType foodType)
        {
            _dbContext.FoodTypes.Remove(@foodType);
            await Task.CompletedTask;
        }
    }
}
