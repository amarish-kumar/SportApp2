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
    public class FoodRepository : IFoodRepository
    {
        private readonly DatabaseContext _dbContext;

        public FoodRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Food> GetAsync(Guid id)
            => await Task.FromResult(_dbContext.Foods.SingleOrDefault(x => x.Id == id));

        public Task<Food> GetAsync(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Food>> BrowseAsync(string name = "")
        {
            var foods = _dbContext.Foods.AsEnumerable();
            if (!string.IsNullOrWhiteSpace(name))
            {
                foods = foods.Where(x => x.Name.ToLowerInvariant()
                    .Contains(name.ToLowerInvariant()));
            }

            return await Task.FromResult(foods);
        }

        public async Task AddAsync(Food food)
        {
            _dbContext.Foods.Add(@food);
            await Task.CompletedTask;
        }

        public async Task UpdateAsync(Food food)
            => await Task.CompletedTask;


        public async Task DeleteAsync(Food food)
        {
            _dbContext.Foods.Remove(@food);
            await Task.CompletedTask;
        }
    }
}
