using SquareCalculator.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalc.Figures.FigureTypes
{
    public class Circle : Figure
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Круг
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <exception cref="ArgumentException">Если был передан отрицательный радиус круга</exception>
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Радиус круга должен являться положительным числом"); // Выкидываем ошибку, в случае если радиус круга отрицателен

            Radius = radius;
        }

        /// <summary>
        /// Вычислить площадь круга
        /// </summary>
        protected override double CalculateSquare()
        {
            return Math.PI * Math.Pow(Radius, 2); // Расчет площади круга по радиусу
        }


    }
}
