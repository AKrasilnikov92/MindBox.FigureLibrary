namespace FigureLibrary
{
    public class Circle : Figure
    {
        public double Radius { get; private set; }

        public Circle(string typeName, double radius) : base(typeName)
        {
            if (IsExist(radius))
                Radius = radius;
        }

        ///<summary>
        ///Возвращает площадь круга
        ///</summary>
        public override double CalcSquare()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }

        /// <summary>
        /// Проверяет существует ли круг.
        /// </summary>
        private bool IsExist(double radius) => radius > 0 ? true : throw new Exception("Радиус должен быть больше нуля.");
    }
}
