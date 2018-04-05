using SportApp2.Core.Domain.Base;
using System;
using System.Collections.Generic;

namespace SportApp2.Core.Domain
{
    public class FoodType : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Food> Foods { get; set; }

        public FoodType()
        {

        }

        public FoodType(string name, string description)
        {
            Id = Guid.NewGuid();
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
