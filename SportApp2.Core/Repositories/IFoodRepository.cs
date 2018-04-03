using SportApp2.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SportApp2.Core.Repositories
{
    public interface IFoodRepository
    {
        Task<IEnumerable<Food>> GetAllAsync();
        Task<Food> GetAsync(Guid id);
        Task<Food> GetAsync(string name);
        Task<IEnumerable<Food>> BrowseAsync(string name = "");
        Task AddAsync(Food @food);
        Task UpdateAsync(Food @food);
        Task DeleteAsync(Food @food);
    }
}
