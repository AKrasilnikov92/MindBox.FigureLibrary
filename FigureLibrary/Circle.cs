namespace FigureLibrary
{
    public class Circle : SimpleFigure
    {
        public double Radius { get; set; }

        public Circle (string typeName, double radius) : base (typeName)
        {
            Radius = radius;
        }

        ///<summary>
        ///Возвращает площадь круга
        ///</summary>
        public override double Square()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2),2);
        }
    }
}
