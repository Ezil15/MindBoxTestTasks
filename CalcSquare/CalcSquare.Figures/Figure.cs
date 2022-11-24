namespace SquareCalculator.Figures
{
    public abstract class Figure
    {
        private readonly Lazy<double> _square; // Отложенная инициализация площади фигуры

        /// <summary>
        /// Площадь фигуры
        /// </summary>
        public double Square => _square.Value; // Публичная переменная для получения значения площади фигуры

        protected Figure()
        {
            _square = new Lazy<double>(CalculateSquare); // Задаем инициализированному Figure параметр _square
        }

        /// <summary>
        /// Вычислить площадь фигуры
        /// </summary>
        protected abstract double CalculateSquare();

    }
}