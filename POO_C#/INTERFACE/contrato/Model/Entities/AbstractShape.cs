using contrato.Model.Entities.Enum;

namespace contrato.Model.Entities
{
    public abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}