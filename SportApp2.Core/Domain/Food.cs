using SportApp2.Core.Domain.Base;
using System;

namespace SportApp2.Core.Domain
{
    public class Food : Entity
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }

        public virtual Nutrient Nutrient { get; set; }

        public Food()
        {
        }

        public Food(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void SetName(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new Exception($"Food with id: '{Id}' can not have an empty name.");
            }

            Name = name;
        }

        public void SetDescription(string description)
        {
            if(string.IsNullOrWhiteSpace(description))
            {
                throw new Exception($"Food with id: '{Id}' can not have an empty description.");
            }

            Description = description;           
        }
    }
}
