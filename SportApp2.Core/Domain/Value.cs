using SportApp2.Core.Domain.Base;
using System.ComponentModel.DataAnnotations;

namespace SportApp2.Core.Domain
{
    public class Value : Entity
    {
        [MinLength(5)]
        public string Text { get; set; }
    }
}
