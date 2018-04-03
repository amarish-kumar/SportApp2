using SportApp2.Core.Domain.Base;
using System.Collections.Generic;

namespace SportApp2.Core.Domain
{
    public class UserExercise : Entity
    {
        public List<User> Users { get; set;}
        public List<Exercise> Exercises { get; set; }
                    

        public UserExercise()
        {
            
        }
    }
}