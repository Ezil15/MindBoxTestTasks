using SquareCalc.Figures.FigureTypes;

namespace CalcSquare.Tests
{
    [TestClass]
    public class CalcSquareTests
    {
        /// <summary>
        /// Тест вычисления площади треугольника со значениями 3,4,5
        /// </summary>
        [TestMethod]
        public void Triangle_CalculateSquare_3and4and5_6returned()
        {
            //Arrange
            Triangle triangle = new Triangle(3, 4, 5);

            //Act
            double expected = 6;

            //Assert
            Assert.AreEqual(expected, triangle.Square);
        }

        /// <summary>
        /// Тест вычисления площади треугольника со значениями 9,10,17
        /// </summary>
        [TestMethod]
        public void Triangle_CalculateSquare_9and10and17_36returned()
        {
            //Arrange
            Triangle triangle = new Triangle(9, 10, 17);

            //Act
            double expected = 36;

            //Assert
            Assert.AreEqual(expected, triangle.Square);
        }

        /// <summary>
        /// Тест отрицательных сторон треугольника
        /// </summary>
        [TestMethod]
        public void Triangle_NegativeSides_ArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-10, 0, 0));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(0, -10, 0));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(0, 0, -10));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-10, -10, 0));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-10, 0, -10));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(0, -10, -10));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-10, -10, -10));
        }


        /// <summary>
        /// Тест является ли треугольник прямугольный со значениями 16,30,34
        /// </summary>
        [TestMethod]
        public void Triangle_IsRight_16and30and34_true()
        {
            //Arrange
            Triangle triangle = new Triangle(16, 30, 34);

            //Act
            bool expected = true;

            //Assert
            Assert.AreEqual(expected, triangle.IsRight);
        }

        /// <summary>
        /// Тест является ли треугольник прямугольный со значениями 3,4,5
        /// </summary>
        [TestMethod]
        public void Triangle_IsRight_3and4and5_true()
        {
            //Arrange
            Triangle triangle = new Triangle(3, 4, 5);

            //Act
            bool expected = true;

            //Assert
            Assert.AreEqual(expected, triangle.IsRight);
        }

        /// <summary>
        /// Тест Не является ли треугольник прямугольный со значениями 8,12,16
        /// </summary>
        [TestMethod]
        public void Triangle_IsRight_8and12and16_false()
        {
            //Arrange
            Triangle triangle = new Triangle(8, 12, 16);

            //Act
            bool expected = false;

            //Assert
            Assert.AreEqual(expected, triangle.IsRight);
        }

        /// <summary>
        /// Тест Не является ли треугольник прямугольный со значениями 5,6,6
        /// </summary>
        [TestMethod]
        public void Triangle_IsRight_5and6and7_false()
        {
            //Arrange
            Triangle triangle = new Triangle(5, 6, 7);

            //Act
            bool expected = false;

            //Assert
            Assert.AreEqual(expected, triangle.IsRight);
        }

        /// <summary>
        /// Тест отрицательного радиуса круга
        /// </summary>
        [TestMethod]
        public void Circle_NegativeRadius_ArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(-5));            
        }

        /// <summary>
        /// Тест вычисления площади круга с радиусом 5
        /// </summary>
        [TestMethod]
        public void Circle_CalculateSquare_5()
        {
            //Arrange
            Circle сircle = new Circle(5);

            //Act
            double expected = 78.53981633974483;

            //Assert
            Assert.AreEqual(expected, сircle.Square);
        }

        /// <summary>
        /// Тест вычисления площади круга с радиусом 13
        /// </summary>
        [TestMethod]
        public void Circle_CalculateSquare_13()
        {
            //Arrange
            Circle сircle = new Circle(13);

            //Act
            double expected = 530.929158456675;

            //Assert
            Assert.AreEqual(expected, сircle.Square);
        }
    }
}