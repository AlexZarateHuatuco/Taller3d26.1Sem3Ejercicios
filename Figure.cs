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