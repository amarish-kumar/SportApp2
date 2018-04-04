using SportApp2.Core.Domain.Base;
using System;

namespace SportApp2.Core.Domain
{
    public class Nutrient : Entity
    {
        public Guid FoodId { get; set; }
        public const int UnitWeightGram = 100;
        public float Calories { get; protected set; }
        public float FatSaturated { get; protected set; }
        public float FatTrans { get; protected set; }
        public float Cholesterol { get; protected set; }
        public float Sodium { get; protected set; }
        public float Carbohydrate { get; protected set; }
        public float Proteins { get; protected set; }

        public virtual Food Food { get; set; }
    }
}
