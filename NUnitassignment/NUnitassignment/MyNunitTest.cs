using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitassignment
{
    [TestFixture]
    class MyNunitTest
    {
        [Test]
        // Test case description: Pop method on an empty stack should return -1.
        public void Pop_EmptyStack_ReturnsMinusOne()
        {
            // Arrange
            Stack stack = new Stack();

            // Act
            int result = stack.Pop();

            // Assert
            Assert.AreEqual(-1, result);
        }

        [Test]

        // Test case description: Pushing an element onto the stack and then popping it should return the correct element.
        public void PushAndPop_StackNotEmpty_ReturnsCorrectElement()
        {
            // Arrange
            Stack stack = new Stack();

            // Act
            stack.Push(42);
            int result = stack.Pop();

            // Assert
            Assert.AreEqual(42, result);
        }

        [Test]
        // Test case description: Peek method on an empty stack should return -1.
        public void Peek_EmptyStack_ReturnsMinusOne()
        {
            // Arrange
            Stack stack = new Stack();

            // Act, As Peek only writes to the console, you might need to refactor
            // your code to return values for better testability.
            stack.Peek();
        }

        [Test]
        // Test case description: Index method on a stack with elements should return the correct index.
        public void Index_StackWithElements_ReturnsCorrectIndex()
        {
            // Arrange
            Stack stack = new Stack();

            // Act
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            int result = stack.Index(20);

            // Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        // Test case description: Index method on a stack with elements not containing the specified element should return -1.
        public void Index_ElementNotInStack_ReturnsMinusOne()
        {
            // Arrange
            Stack stack = new Stack();

            // Act
            stack.Push(10);
            stack.Push(20);
            int result = stack.Index(30);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [Test]
        // Test case description: Length method on a stack with elements should return the correct count.
        public void Length_StackWithElements_ReturnsCorrectCount()
        {
            // Arrange
            Stack stack = new Stack();

            // Act
            stack.Push(10);
            stack.Push(20);
            int result = stack.Length();

            // Assert
            Assert.AreEqual(2, result);
        }

        [Test]
        // Test case description: IsEmpty method on an empty stack should return true.
        public void IsEmpty_EmptyStack_ReturnsTrue()
        {
            // Arrange
            Stack stack = new Stack();

            // Act
            bool result = stack.IsEmpty();

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        // Test case description: IsEmpty method on a stack with elements should return false.
        public void IsEmpty_StackWithElements_ReturnsFalse()
        {
            // Arrange
            Stack stack = new Stack();

            // Act
            stack.Push(10);
            bool result = stack.IsEmpty();

            // Assert
            Assert.IsFalse(result);
        }
    }
}
