using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_20_08.Entities.Enums
{
    internal class Departament
    {
        public string Name { get; set; }

        public Departament()
        {
        }

        public Departament(string name)
        {
            Name = name;
        }
    }
}
