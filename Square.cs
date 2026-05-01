using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Taller3dSemana3
{
    internal class Square : Rectangle
    {
        public Square(float side) : base(side, side)
        {
            Name = "Cuadrado";
        }
    }
}