namespace Taller3dSemana3
{
    internal class Circle : Figure
    {
        public float Radio { get; set; }
        public Circle(float r) : base("Círculo")
        {
            Radio = r;
        }
        public override float CalculateArea()
        {
            return 3.14f * Radio * Radio;
        }
    }
}