using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EindOpdrachtCSharpTraineeship.Models;

namespace EindOpdrachtCSharpTraineeship
{
    public class Freelancer
    {
        private string Name { get; set; }
        private Skill skills { get; set; }
   
        private double Experience { get; set; }
        private decimal salary { get; set; }
        private Boolean isEmployed { get; set; }

        public List<int> ProjectList
        {
            get => default;
            set
            {
            }
        }

        public int ID
        {
            get => default;
            set
            {
            }
        }
    }
}
