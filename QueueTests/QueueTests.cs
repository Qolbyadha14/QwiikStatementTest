namespace QueueTests
{
    public class QueueTests
    {
        [Fact]
        public void Enqueue_ShouldAddItemToQueue()
        {
            // Arrange
            var myQueue = new Program();

            // Act
            myQueue.Enqueue(42);

            // Assert
            Assert.Equal(1, myQueue.Count);
        }

        [Fact]
        public void Dequeue_ShouldRemoveItemFromQueue()
        {
            // Arrange
            var myQueue = new Program();

            // Act
            myQueue.Enqueue(42);
            myQueue.Dequeue();

            // Assert
            Assert.Equal(0, myQueue.Count);
        }

        [Fact]
        public void Dequeue_ShouldThrowExceptionForEmptyQueue()
        {
            // Arrange
            var myQueue = new Program();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => myQueue.Dequeue());
        }
    }

}