using SportApp2.Core.Domain.Base;

namespace SportApp2.Core.Domain
{
    public class Food : Entity
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }
    }
}
