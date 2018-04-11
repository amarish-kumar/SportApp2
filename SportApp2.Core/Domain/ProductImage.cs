using SportApp2.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportApp2.Core.Domain
{
    public class ProductImage : Entity
    {
        public byte[] Image { get; set; }
        public virtual Food Food { get; private set; }
        public virtual FoodType FoodType { get; private set; }
    }
}
