using SportApp2.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SportApp2.Core.Repositories
{
    public interface IFoodTypeRepository
    {
        Task<FoodType> GetAsync(Guid id);
        Task<FoodType> GetAsync(string name);
        Task<IEnumerable<FoodType>> BrowseAsync(string name = "");
        Task AddAsync(FoodType @food);
        Task UpdateAsync(FoodType @food);
        Task DeleteAsync(FoodType @food);
    }
}
