using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3dSemana3
{
    internal abstract class Figure
    {
        public string Name { get; set; }
        public Figure(string name)
        {
            Name = name;
        }
        public abstract float CalculateArea();
    }
}