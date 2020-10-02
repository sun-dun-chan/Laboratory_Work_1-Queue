using System;
using Xunit;

namespace QueueWork.Tests
{
    public class QueueTests
    {
        [Fact]
        public void Enqueue_Items_And_Dequeue_Element_Get_Element()
        {
            // Arrange
            Queue<int> queue = new Queue<int>();
            int expected = 0;

            // Act 
            for (int i = 0; i < 6; i++) queue.Enqueue(i);
            int actual = queue.Dequeue();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Enqueue_Items_And_Peek_Element()
        {
            // Arrange
            Queue<int> queue = new Queue<int>();
            int expected = 0;

            // Act
            for (int i = 0; i < 6; i++) queue.Enqueue(i);
            int actual = queue.Peek();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Dequeue_Element_In_Empty_Queue_Should_Throw_NullReferenceException()
        {   // Arragne
            Queue<int> queue = new Queue<int>();
            int a;
            // Act and Assert
            Assert.Throws<System.NullReferenceException>(() => a = queue.Dequeue());
        }

        [Fact]
        public void Peek_Element_In_Empty_Queue_Should_Throw_NullReferenceException()
        {
            // Arrange
            Queue<int> queue = new Queue<int>();
            int a;
            // Act and Assert
            Assert.Throws<System.NullReferenceException>(() => a = queue.Peek());
        }
    }
}
