using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3dSemana3
{
    internal class Rectangle : Figure
    {
        public float Width { get; set; }
        public float Height { get; set; }
        public Rectangle(float width, float height) : base("Rectángulo")
        {
            Width = width;
            Height = height;
        }
        public override float CalculateArea()
        {
            return Width * Height;
        }
    }
}