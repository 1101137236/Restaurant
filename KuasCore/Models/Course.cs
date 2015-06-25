using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Models
{
    public class Course
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Tel { get; set; }

        public string Start { get; set; }

        public string End { get; set; }

        public string Here { get; set; }

        public string Rest { get; set; }

        public override string ToString()
        {
            return "Course: Id = " + Id + ", Name = " + Name + ".";
        }
    }
}
