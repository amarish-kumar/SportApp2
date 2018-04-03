using SportApp2.Core.Domain.Base;

namespace SportApp2.Core.Domain
{
    public class Exercise : Entity
    {
        public string Name { get; set; }
        public int GroupId { get; set; }
        public string PictureStart { get; set; }
        public string PictureStop { get; set; }            

        public Exercise()
        {
            
        }
    }
}