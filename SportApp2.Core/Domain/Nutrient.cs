using SportApp2.Core.Domain.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportApp2.Core.Domain
{
    public class Nutrient : Entity
    {
        public int UnitWeightGram { get; }  = 100;
        public float Calories { get; protected set; }
        public float FatSaturated { get; protected set; }
        public float FatTrans { get; protected set; }
        public float Cholesterol { get; protected set; }
        public float Sodium { get; protected set; }
        public float Carbohydrate { get; protected set; }
        public float Proteins { get; protected set; }

        public virtual Food Food { get; set; }

        public Nutrient()
        {
        }

        public Nutrient(float calories, int fatSaturated, int fatTrans, int cholesterol,
            int sodium, int carbohydrate, int proteins)
        {
            Id = Guid.NewGuid();
            Calories = calories;
            FatSaturated = fatSaturated;
            FatTrans = fatTrans;
            Cholesterol = cholesterol;
            Sodium = sodium;
            Carbohydrate = carbohydrate;
            Proteins = proteins;
        }
    }
}
