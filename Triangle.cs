namespace Taller3dSemana3
{
    internal class Triangle : Figure
    {
        public float Width { get; set; }
        public float Height { get; set; }

        public Triangle(float width, float height) : base("Triángulo")
        {
            Width = width;
            Height = height;
        }

        public override float CalculateArea()
        {
            return (Width * Height) / 2;
        }
    }
}