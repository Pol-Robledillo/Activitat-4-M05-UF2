using M05UF2;
namespace Test_Actividad_4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidateOptionTestTrue()
        {
            //Arrange
            const string letter = "a";
            bool result;

            //Act
            result = Pt4.ValidateOption(letter);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidateOptionTestFalse()
        {
            //Arrange
            const string letter = "j";
            bool result;

            //Act
            result = Pt4.ValidateOption(letter);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidateNumberTestTrue()
        {
            //Arrange
            const double number = 54.2;
            bool result;

            //Act
            result = Pt4.ValidateNumber(number);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidateNumberTestFalse()
        {
            //Arrange
            const double number = -23;
            bool result;

            //Act
            result = Pt4.ValidateNumber(number);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AreaSquareRectangleTest1()
        {
            //Arrange
            const double height = 33.3, width = 15, expected = height * width;
            double result;

            //Act
            result = Pt4.AreaSquareRectangle(height, width);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AreaSquareRectangleTest2()
        {
            //Arrange
            const double height = 5, width = 5, expected = height * width;
            double result;

            //Act
            result = Pt4.AreaSquareRectangle(height, width);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AreaCircleTest1()
        {
            //Arrange
            const double radius = 16, expected = Math.PI * (radius * radius);
            double result;

            //Act
            result = Pt4.AreaCircle(radius);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AreaCircleTest2()
        {
            //Arrange
            const double radius = 54.2, expected = Math.PI * (radius * radius);
            double result;

            //Act
            result = Pt4.AreaCircle(radius);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AreaPentagonTest1()
        {
            //Arrange
            const double side = 40.6, apotema = 33.7, expected = ((side * 5) * apotema) / 2;
            double result;

            //Act
            result = Pt4.AreaPentagon(apotema, side);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AreaPentagonTest2()
        {
            //Arrange
            const double side = 6, apotema = 5, expected = ((side * 5) * apotema) / 2;
            double result;

            //Act
            result = Pt4.AreaPentagon(apotema, side);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}