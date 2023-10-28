
namespace QuickSortAppTests
{
    public class QuickSortTests
    {
        [Fact]
        public void QuickSort_ShouldSortArrayCorrectly()
        {
            // Arrange
            int[] arr = { 12, 4, 5, 6, 7, 3, 1, 15 };
            int[] expected = { 1, 3, 4, 5, 6, 7, 12, 15 };

            // Act
            Program.QuickSort(arr, 0, arr.Length - 1);

            // Assert
            Assert.Equal(expected, arr);
        }
    }
}