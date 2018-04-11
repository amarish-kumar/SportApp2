using AutoMapper;
using SportApp2.Core.Domain;
using SportApp2.Core.Repositories;
using SportApp2.Infrastructure.DTO;
using SportApp2.Infrastructure.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SportApp2.Infrastructure.Services
{
    public class FoodTypeService : IFoodTypeService
    {
        private readonly IMapper _mapper;
        private readonly IFoodTypeRepository _foodTypeRepository;

        public FoodTypeService(IMapper mapper, IFoodTypeRepository foodTypeRepository)
        {
            _mapper = mapper;
            _foodTypeRepository = foodTypeRepository;
        }

        public async Task<FoodTypesDto> GetAsync(Guid id)
        {
            var @food = await _foodTypeRepository.GetAsync(id);
            return _mapper.Map<FoodTypesDto>(@food);
        }

        public async Task<FoodTypesDto> GetAsync(string name)
        {
            var @food = await _foodTypeRepository.GetAsync(name);
            return _mapper.Map<FoodTypesDto>(@food);
        }

        public async Task<IEnumerable<FoodTypesDto>> BrowseAsync(string name = null)
        {
            var foods = await _foodTypeRepository.BrowseAsync(name);
            return _mapper.Map<IEnumerable<FoodTypesDto>>(foods);
        }

        public async Task CreateAsync(string name, string description)
        {
            var @food = await _foodTypeRepository.GetAsync(name);
            if (@food != null)
            {
                throw new Exception($"Food type named: {name} already exists.");
            }

            @food = new FoodType(name, description);
            await _foodTypeRepository.AddAsync(@food);
        }

        public async Task UpdateAsync(Guid id, string name, string description)
        {
            var @food = await _foodTypeRepository.GetAsync(name);
            if (@food != null)
            {
                throw new Exception($"Food type named: {name} already exists.");
            }

            @food = await _foodTypeRepository.GetFoodTypeOrFailAsync(id);
            @food.SetName(name);
            @food.SetDescription(description);
        }

        public async Task DeleteAsync(Guid id)
        {
            var @food = await _foodTypeRepository.GetFoodTypeOrFailAsync(id);
            await _foodTypeRepository.DeleteAsync(@food);
        }
    }
}
