using System;
using System.Collections.Generic;
using System.Text;

namespace SportApp2.Infrastructure.DTO
{
    public class FoodDetailsDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }
        public int Carbohydrate { get; set; }
        public int Cholesterol { get; set; }
        public int FatSaturated { get; set; }
        public int FatTrans { get; set; }
        public int Proteins { get; set; }
        public int Sodium { get; set; }
    }
}
