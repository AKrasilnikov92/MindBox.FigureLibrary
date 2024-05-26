namespace FigureLibrary
{
    public class Triangle : Figure
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }

        public Triangle(string typeName, double a, double b, double c) : base(typeName)
        {
            if (IsExist(a, b, c))
            {
                SideA = a;
                SideB = b;
                SideC = c;
            }
        }

        /// <summary>
        /// Проверяет существует ли треугольник согласно теореме неравенста треугольника.
        /// Т.е. одна сторона треугольника не может быть больше суммы двух других.
        /// </summary>
        /// <returns>True, если треугольник существует</returns>
        private bool IsExist(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new Exception("Сторона треугольникадолжгп быть больше нуля.");

            if (a > (b + c) || b > (a + c) || c > (a + b))
                throw new Exception("Одна сторона треугольника не может быть больше суммы двух других сторон");

            return true;
        }

        /// <summary>
        /// Возвращает площадь треугольника.
        /// </summary>
        public override double CalcSquare()
        {
            double halfPeimeter = (SideA + SideB + SideC) / 2;
            double square = Math.Sqrt(halfPeimeter * (halfPeimeter - SideA) * (halfPeimeter - SideB) * (halfPeimeter * SideC));
            return Math.Round(square, 2);
        }

        /// <summary>
        /// Проверяет является ли треугольник прямоугольным. 
        /// </summary>
        /// <param name="SideA">SideA</param>
        /// <param name="SideB">SideB</param>
        /// <param name="SideC">SideC</param>
        /// <returns>True, если одну из сторон можно вычислить по Теореме Пифагора</returns>
        public bool IsRectangularTriangle()
        {
            bool isRectangular = (SideA == Math.Sqrt(Math.Pow(SideB, 2) + Math.Pow(SideC, 2))
                               || SideB == Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideC, 2))
                               || SideC == Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2)));
            return isRectangular;
        }
    }
}
