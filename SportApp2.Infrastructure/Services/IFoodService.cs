using SportApp2.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SportApp2.Infrastructure.Services
{
    public interface IFoodService
    {
        Task<FoodDto> GetAsync(Guid id);
        Task<FoodDto> GetAsync(string name);
        Task<IEnumerable<FoodDto>> BrowseAsync(string name = null);
        Task CreateAsync(string name, string description);
        Task UpdateAsync(Guid id, string name, string description);
        Task DeleteAsync(Guid id);
    }
}
