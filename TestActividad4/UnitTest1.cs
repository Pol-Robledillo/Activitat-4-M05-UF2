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
            string letter = "a";
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
            string letter = "j";
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
            double number = 54.2;
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
            double number = -23;
            bool result;

            //Act
            result = Pt4.ValidateNumber(number);

            //Assert
            Assert.IsFalse(result);
        }
    }
}