using SquareCalculator.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalc.Figures.FigureTypes
{
    public class Triangle : Figure
    {
        /// <summary>
        /// Первая сторона
        /// </summary>
        public double A { get; }

        /// <summary>
        /// Вторая сторона
        /// </summary>
        public double B { get; }

        /// <summary>
        /// Третья сторона
        /// </summary>
        public double C { get; }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public bool IsRight { get; }

        /// <summary>
        /// Треугольник
        /// </summary>
        /// <param name="a">Первая сторона</param>
        /// <param name="b">Вторая сторона</param>
        /// <param name="c">Третья сторона</param>
        /// <exception cref="ArgumentException">Одна из сторон имеет отрицательное значение</exception>
        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentException("Все стороны треугольника должны быть положительными"); // Выкидываем ошибку, в случае если были переданны некорректные параметры
            A = a;
            B = b;
            C = c;

            IsRight = (Math.Pow(a,2) + Math.Pow(b, 2) == Math.Pow(c, 2));  // Проверка на то, является ли треугольник прямоугольным
        }


        /// <summary>
        /// Вычислить площадь треугольника
        /// </summary>
        protected override double CalculateSquare()
        {
            double p = (A + B + C) / 2; // Находим полумериметр треугольника
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C)); // Возвращаем значение площади треугольника
        }

    }
}
