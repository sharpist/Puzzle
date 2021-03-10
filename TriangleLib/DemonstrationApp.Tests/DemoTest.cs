using Xunit;
using static TriangleLib.Triangle;

namespace DemonstrationApp.Tests
{
    public class DemoTest
    {
        [Fact]
        public void Can_Determine_Incorrect_Values()
        {
            var result = new Demonstration(2, 4, 9);
            Assert.False(result.IsTriangle);
            Assert.Null(result.Type);
        }

        [Fact]
        public void Can_Determine_Right_Triangle()
        {
            var result = new Demonstration(5, 4, 3);
            Assert.True(result.IsTriangle);
            Assert.Equal(TriangleType.Right, result.Type);
        }

        [Fact]
        public void Can_Determine_Obtuse_Triangle()
        {
            var result = new Demonstration(6, 4, 8);
            Assert.True(result.IsTriangle);
            Assert.Equal(TriangleType.Obtuse, result.Type);
        }

        [Fact]
        public void Can_Determine_Acute_Triangle()
        {
            var result = new Demonstration(5, 8, 8);
            Assert.True(result.IsTriangle);
            Assert.Equal(TriangleType.Acute, result.Type);
        }
    }
}
