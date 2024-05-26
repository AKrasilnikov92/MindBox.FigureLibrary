namespace FigureLibrary
{
    public abstract class Figure
    {
        public string TypeName { get; private set; }
        
        public Figure (string type)
        {
            this.TypeName = type;
        }

        public abstract double CalcSquare();

        public string TypeToString()
        {
            return $"Тип фигуры: {TypeName}";
        }
    }
}