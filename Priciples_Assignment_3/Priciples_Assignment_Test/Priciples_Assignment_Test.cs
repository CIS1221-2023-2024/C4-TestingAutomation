using System.Collections.Generic;

namespace Priciples_Assignment_Test
{
    public class Priciples_Assignment_Test
    {
        private Stack<int> stack;

        [SetUp]
        public void SetUp()
        {
            stack = new Stack<int>();
        }

        [Test]
        public void TestIsEmpty()
        {
            Assert.IsTrue(stack.IsEmpty());
            stack.Push(1);
            Assert.IsFalse(stack.IsEmpty());
            stack.Pop();
            Assert.IsTrue(stack.IsEmpty());
        }

        [Test]
        public void TestPeek()
        {
            Assert.IsNull(stack.Peek());
            stack.Push(1);
            Assert.AreEqual(stack.Peek(), 1);
            stack.Pop();
            Assert.IsNull(stack.Peek());
        }

        [Test]
        public void TestCountLength()
        {
            Assert.IsNull(stack.CountLength());
            stack.Push(1);
            Assert.AreEqual(stack.CountLength(), 1);
            stack.Push(2);
            Assert.AreEqual(stack.CountLength(), 2);
            stack.Pop();
            Assert.AreEqual(stack.CountLength(), 1);
        }

        [Test]
        public void TestIndex()
        {
            Assert.IsNull(stack.Index(1));
            stack.Push(1);
            Assert.AreEqual(stack.Index(1), 0);
            Assert.IsNull(stack.Index(2));
            stack.Pop();
            Assert.IsNull(stack.Index(1));
        }

        [Test]
        public void TestDisplay()
        {
            stack.Display();
            stack.Push(1);
            stack.Display();
            stack.Push(2);
            stack.Display();
            stack.Pop();
            stack.Display();
        }

        [Test]
        public void TestPush()
        {
            stack.Push(1);
            Assert.AreEqual(stack.Peek(), 1);
            stack.Push(2);
            Assert.AreEqual(stack.Peek(), 2);

            // Note: C# is a statically-typed language, so the type of the stack must be consistent.
            Assert.AreEqual(stack.Peek(), "abc");
        }

        [Test]
        public void TestPop()
        {
            Assert.IsNull(stack.Pop());
            stack.Push(1);
            stack.Push(2);
            Assert.AreEqual(stack.Pop(), 2);
            Assert.AreEqual(stack.Pop(), 1);
            Assert.IsNull(stack.Pop());
        }
    }
}
