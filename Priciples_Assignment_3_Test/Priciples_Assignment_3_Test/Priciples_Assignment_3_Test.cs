using NUnit.Framework;
using System.Collections.Generic;

namespace Priciples_Assignment_3_Test
{
    [TestFixture]
    private Stack<int> stack;

    // Set up a new stack before each test
    [SetUp]
    public void SetUp()
    {
        stack = new Stack<int>();
    }

    // Test whether the stack is empty after initialization, after pushing and popping elements
    [Test]
    public void TestIsEmpty()
    {
        Assert.IsTrue(stack.IsEmpty());
        stack.Push(1);
        Assert.IsFalse(stack.IsEmpty());
        stack.Pop();
        Assert.IsTrue(stack.IsEmpty());
    }

    // Test the Peek method to get the top element without removing it
    [Test]
    public void TestPeek()
    {
        Assert.IsNull(stack.Peek());
        stack.Push(1);
        Assert.AreEqual(stack.Peek(), 1);
        stack.Pop();
        Assert.IsNull(stack.Peek());
    }

    // Test the CountLength method to get the number of elements in the stack
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

    // Test the Index method to get the position of an element in the stack
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

    // Test the Display method to show the elements in the stack
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

    // Test the Push method to add elements to the stack
    [Test]
    public void TestPush()
    {
        stack.Push(1);
        Assert.AreEqual(stack.Peek(), 1);
        stack.Push(2);
        Assert.AreEqual(stack.Peek(), 2);

        // Note: C# is a statically-typed language, so the type of the stack must be consistent.
        // The following line intentionally contains an error to demonstrate an invalid test case.
        // Assert.AreEqual(stack.Peek(), "abc");
        Assert.AreEqual(stack.Peek(), "abc");
    }

    // Test the Pop method to remove and return the top element from the stack
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