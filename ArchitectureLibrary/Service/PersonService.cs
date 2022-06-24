using ArchitectureLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureLibrary.Service
{
    public interface PersonService
    {
        Person Create(Person person);
    }
}
