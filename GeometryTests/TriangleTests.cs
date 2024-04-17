using Xunit;
using GeometryLib;

namespace GeometryTests
{
    public class TriangleTests
    {
        [Fact]
        public void CalculatePerimeter_ValidRightTriangle_ReturnsCorrectPerimeter()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var result = triangle.CalculatePerimeter();

            // Assert
            Assert.Equal(12, result);
        }

        [Fact]
        public void CalculatePerimeter_InvalidTriangle_ThrowsException()
        {
            // Arrange (triangle with sides that violate the Triangle Inequality Theorem)
            var triangle = new Triangle(1, 2, 5);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => triangle.CalculatePerimeter());
        }

        // Additional tests can be added here for different triangle types (equilateral, isosceles, scalene)
        // For example:
        [Fact]
        public void CalculatePerimeter_EquilateralTriangle_ReturnsCorrectPerimeter()
        {
            // Arrange
            var triangle = new Triangle(3, 3, 3);

            // Act
            var result = triangle.CalculatePerimeter();

            // Assert
            Assert.Equal(9, result);
        }

        [Fact]
        public void CalculatePerimeter_IsoscelesTriangle_ReturnsCorrectPerimeter()
        {
            // Arrange
            var triangle = new Triangle(5, 5, 8);

            // Act
            var result = triangle.CalculatePerimeter();

            // Assert
            Assert.Equal(18, result);
        }

        [Fact]
        public void CalculatePerimeter_ScaleneTriangle_ReturnsCorrectPerimeter()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 6);

            // Act
            var result = triangle.CalculatePerimeter();

            // Assert
            Assert.Equal(13, result);
        }
    }
}
