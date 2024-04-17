using Xunit;
using GeometryLib;

namespace GeometryTests
{
    public class SquareTests
    {
        [Fact]
        public void CalculateArea_PositiveSide_ReturnsCorrectArea()
        {
            var square = new Square(5);

            var result = square.CalculateArea();

            Assert.Equal(25, result);
        }

        [Fact]
        public void CalculatePerimeter_PositiveSide_ReturnsCorrectPerimeter()
        {
            var square = new Square(5);

            var result = square.CalculatePerimeter();

            Assert.Equal(20, result);
        }

        [Fact]
        public void CalculateArea_ZeroSide_ReturnsZero()
        {
            var square = new Square(0);

            var result = square.CalculateArea();

            Assert.Equal(0, result);
        }

        [Fact]
        public void CalculateArea_NegativeSide_ThrowsArgumentException()
        {
            var side = -5;

            Assert.Throws<ArgumentException>(() => new Square(side));
        }

        [Fact]
        public void CalculatePerimeter_ZeroSide_ReturnsZero()
        {
            var square = new Square(0);

            var result = square.CalculatePerimeter();

            Assert.Equal(0, result);
        }

        [Fact]
        public void CalculatePerimeter_NegativeSide_ThrowsArgumentException()
        {
            var side = -5;

            Assert.Throws<ArgumentException>(() => new Square(side));
        }

        [Theory]
        [InlineData(6, 36)] 
        [InlineData(10, 100)]
        [InlineData(0.5, 0.25)]
        public void CalculateArea_VariousInputs_ReturnsCorrectArea(double side, double expectedArea)
        {
            var square = new Square(side);

            var result = square.CalculateArea();

            Assert.Equal(expectedArea, result);
        }

        [Theory]
        [InlineData(6, 24)] 
        [InlineData(10, 40)]
        [InlineData(0.5, 2)]
        public void CalculatePerimeter_VariousInputs_ReturnsCorrectPerimeter(double side, double expectedPerimeter)
        {
            var square = new Square(side);

            var result = square.CalculatePerimeter();

            Assert.Equal(expectedPerimeter, result);
        }

       [Fact]
        public void SetSide_NullValue_ThrowsArgumentNullException()
        {
            // Arrange
            var square = new Square(4);

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => square.Side = null);
        }
    }
}
