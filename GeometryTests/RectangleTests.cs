using Xunit;
using GeometryLib;

namespace GeometryTests
{
    public class RectangleTests
    {
        [Fact]
        public void CalculateArea_PositiveSides_ReturnsCorrectArea()
        {
            // Arrange
            var rectangle = new Rectangle(4, 7);

            // Act
            var result = rectangle.CalculateArea();

            // Assert
            Assert.Equal(28, result);
        }

        [Fact]
        public void CalculatePerimeter_PositiveSides_ReturnsCorrectPerimeter()
        {
            // Arrange
            var rectangle = new Rectangle(4, 7);

            // Act
            var result = rectangle.CalculatePerimeter();

            // Assert
            Assert.Equal(22, result);
        }

        [Theory]
        [InlineData(3, 5, 30)]
        [InlineData(0, 10, 0)] 
        [InlineData(2.5, 4, 10)] 
        public void CalculateArea_VariousInputs_ReturnsCorrectArea(double width, double height, double expectedArea)
        {
            // Arrange
            var rectangle = new Rectangle(width, height);

            // Act
            var result = rectangle.CalculateArea();

            // Assert
            Assert.Equal(expectedArea, result);
        }

        [Theory]
        [InlineData(3, 5, 16)]
        [InlineData(0, 10, 20)] 
        [InlineData(2.5, 4, 13)] 
        public void CalculatePerimeter_VariousInputs_ReturnsCorrectPerimeter(double width, double height, double expectedPerimeter)
        {
            // Arrange
            var rectangle = new Rectangle(width, height);

            // Act
            var result = rectangle.CalculatePerimeter();

            // Assert
            Assert.Equal(expectedPerimeter, result);
        }

        [Fact]
        public void CalculateArea_NegativeValues_ThrowsArgumentException()
        {
            // Arrange, Act & Assert
            Assert.Throws<ArgumentException>(() => new Rectangle(-5, 10));
        }

        [Fact]
        public void CalculatePerimeter_NegativeValues_ThrowsArgumentException()
        {
            // Arrange, Act & Assert
            Assert.Throws<ArgumentException>(() => new Rectangle(5, -10));
        }
    }
}
