using Xunit;

namespace DemonstrationApp.Tests
{
    public class DemoTest
    {
        [Fact]
        public void Can_Determine_Incorrect_Values()
        {
            var result = new Demonstration(2, 4, 9).TriangleType;
            Assert.Equal("Неверные значения", result);
        }

        [Fact]
        public void Can_Determine_Right_Triangle()
        {
            var result = new Demonstration(5, 4, 3).TriangleType;
            Assert.Equal("Прямоугольный треугольник", result);
        }

        [Fact]
        public void Can_Determine_Obtuse_Triangle()
        {
            var result = new Demonstration(6, 4, 8).TriangleType;
            Assert.Equal("Тупоугольный треугольник", result);
        }

        [Fact]
        public void Can_Determine_Acute_Triangle()
        {
            var result = new Demonstration(5, 8, 8).TriangleType;
            Assert.Equal("Остроугольный треугольник", result);
        }
    }
}
