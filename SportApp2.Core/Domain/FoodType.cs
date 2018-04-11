using SportApp2.Core.Domain.Base;
using System;
using System.Collections.Generic;

namespace SportApp2.Core.Domain
{
    public class FoodType : Entity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public virtual ICollection<Food> Foods { get; private set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }

        public FoodType()
        {
            this.Foods = new HashSet<Food>();
        }

        public FoodType(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new Exception($"Food type with id: '{Id}' can not have an empty name.");
            }

            Name = name;
        }

        public void SetDescription(string description)
        {
            if (string.IsNullOrWhiteSpace(description))
            {
                throw new Exception($"Food type with id: '{Id}' can not have an empty description.");
            }

            Description = description;
        }
    }
}
