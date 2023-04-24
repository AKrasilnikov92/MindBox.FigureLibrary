namespace FigureLibrary
{
    public abstract class SimpleFigure
    {
        public string TypeName { get; set; }

        public SimpleFigure (string type)
        {
            TypeName = type;
        }

        public abstract double Square();

        public string TypeToString()
        {
            return $"Тип фигуры: {TypeName}";
        }
    }
}