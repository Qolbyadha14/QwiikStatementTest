namespace TriangleTypeTests
{
    public class TriangleTypeTests
    {
        [Theory]
        [InlineData(3, 3, 3, "Equilateral Triangle")]
        [InlineData(3, 4, 4, "Isosceles Triangle")]
        [InlineData(6, 8, 10, "Scalene Triangle")]
        public void DetermineTriangleType_ShouldReturnCorrectResult(int side1, int side2, int side3, string expected)
        {
            var result = Program.DetermineTriangleType(side1, side2, side3);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void DetermineTriangleType_ShouldThrowExceptionForInvalidTriangle()
        {
            int side1 = -1, side2 = 2, side3 = 3;

            Assert.Throws<ArgumentException>(() => Program.DetermineTriangleType(side1, side2, side3));
        }
    }
}