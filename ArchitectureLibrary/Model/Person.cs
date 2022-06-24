using ArchitectureLibrary.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureLibrary.Model
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public double GPA { get; set; }
        public decimal Asset { get; set; }
        public bool Active { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
    }
}
