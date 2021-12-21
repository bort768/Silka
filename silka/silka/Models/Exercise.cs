using System;
using System.Collections.Generic;
using System.Text;

namespace silka.Models
{
    public class Exercise
    {
        public string Name { get; set;}
        public string Image { get; set; }
        public string[] Muscle_Parties { get; set;}

        public override string ToString()
        {
            return Name;
        }
    }
}
