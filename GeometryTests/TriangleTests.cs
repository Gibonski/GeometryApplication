using Xunit;
using GeometryLib;

namespace GeometryTests
{
    public class TriangleTests
    {
        [Fact]
        public void CalculatePerimeter_ValidRightTriangle_ReturnsCorrectPerimeter()
        {
            var triangle = new Triangle(3, 4, 5);

            var result = triangle.CalculatePerimeter();

            Assert.Equal(12, result);
        }

        [Fact]
        public void CalculatePerimeter_InvalidTriangle_ThrowsException()
        {
            var triangle = new Triangle(1, 2, 5);

            Assert.Throws<ArgumentException>(() => triangle.CalculatePerimeter());
        }

        [Fact]
        public void CalculatePerimeter_EquilateralTriangle_ReturnsCorrectPerimeter()
        {
            var triangle = new Triangle(3, 3, 3);

            var result = triangle.CalculatePerimeter();

            Assert.Equal(9, result);
        }

        [Fact]
        public void CalculatePerimeter_IsoscelesTriangle_ReturnsCorrectPerimeter()
        {
            var triangle = new Triangle(5, 5, 8);

            var result = triangle.CalculatePerimeter();

            Assert.Equal(18, result);
        }

        [Fact]
        public void CalculatePerimeter_ScaleneTriangle_ReturnsCorrectPerimeter()
        {
            var triangle = new Triangle(3, 4, 6);

            var result = triangle.CalculatePerimeter();

            Assert.Equal(13, result);
        }
    }
}
