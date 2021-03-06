﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SportApp2.Core.Domain;
using SportApp2.Core.Repositories;
using SportApp2.Infrastructure.DbContext;
using SportApp2.Infrastructure.DTO;
using SportApp2.Infrastructure.Extensions;

namespace SportApp2.Infrastructure.Services
{
    public class FoodService : IFoodService
    {
        private readonly IMapper _mapper;
        private readonly IFoodRepository _foodRepository;
        private readonly IFoodTypeRepository _foodTypeRepository;
        private readonly DatabaseContext _db;

        public FoodService(IMapper mapper, IFoodRepository foodRepository, IFoodTypeRepository foodTypeRepository)
        {
            _mapper = mapper;
            _foodRepository = foodRepository;
            _foodTypeRepository = foodTypeRepository;
        }

        public async Task<FoodDto> GetAsync(Guid id)
        {
            var @food = await _foodRepository.GetAsync(id);
            var foodDto = _mapper.Map<FoodDto>(@food);
            var foodType = await Task.FromResult(_foodTypeRepository.GetAsync(@food.FoodTypeId));
            foodDto.FoodTypeName = foodType.Result.Name;
            return foodDto;
        }

        public async Task<FoodDto> GetAsync(string name)
        {
            var @food = await _foodRepository.GetAsync(name);
            return _mapper.Map<FoodDto>(@food);
        }

        public async Task<IEnumerable<FoodDto>> BrowseAsync(string name = null)
        {

            var foods = await _foodRepository.BrowseAsync(name);
            return _mapper.Map<IEnumerable<FoodDto>>(foods);
        }

        public async Task CreateAsync(string name, string description)
        {
            var @food = await _foodRepository.GetAsync(name);
            if(@food != null)
            {
                throw new Exception($"Food named: {name} already exists.");
            }

            @food = new Food(name, description);
            await _foodRepository.AddAsync(@food);
        }

        public async Task UpdateAsync(Guid id, string name, string description)
        {
            var @food = await _foodRepository.GetAsync(name);
            if(@food != null)
            {
                throw new Exception($"Food named: {name} already exists.");
            }

            @food = await _foodRepository.GetOrFailAsync(id);
            @food.SetName(name);
            @food.SetDescription(description);
        }

        public async Task DeleteAsync(Guid id)
        {
            var @food = await _foodRepository.GetOrFailAsync(id);
            await _foodRepository.DeleteAsync(@food);
        }
    }
}
