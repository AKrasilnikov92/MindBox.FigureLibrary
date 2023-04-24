namespace FigureLibrary
{
    public class Triangle : SimpleFigure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

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
        /// <see href="https://colibrus.ru/suschestvuyuschie-treugolniki/">Портал о треугольниках</see>
        /// <returns>True, если треугольник существует</returns>
        private bool IsExist(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new Exception("Сторона треугольника не должна быть меньше либо равна нулю.");

            if (a > (b + c) || b > (a + c) || c > (a + b))
                throw new Exception("Одна сторона треугольника не может быть больше суммы двух других сторон");

            return true;
        }

        /// <summary>
        /// Возвращает площадь треугольника. Формула Герона
        /// </summary>
        public override double Square()
        {
            double halfPeimeter = (SideA + SideB + SideC) / 2;
            double square = Math.Sqrt(halfPeimeter * (halfPeimeter - SideA) * (halfPeimeter - SideB) * (halfPeimeter * SideC));
            return Math.Round(square, 2);
        }

        /// <summary>
        /// Проверяет является ли треугольник прямоугольным. 
        /// </summary>
        /// <see href="https://colibrus.ru/priznaki-treugolnikov">Портал о треугольниках</see>
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
