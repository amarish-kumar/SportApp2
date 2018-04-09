using System;

namespace SportApp2.Infrastructure.DTO
{
    public class FoodDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FoodTypeName { get; set; }
    }
}
