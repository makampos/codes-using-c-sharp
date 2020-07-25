using ABSTRACT.Entities.Enums;

namespace ABSTRACT.Entities
{
    abstract public class Shape
    {
        public Color Color { get; set; }

       
        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}