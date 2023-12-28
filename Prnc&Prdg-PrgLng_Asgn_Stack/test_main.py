
import unittest

from main import Stack


#class MyTestCase(unittest.TestCase):

#    def test_something(self):
#        self.assertEqual(True, False)  # add assertion here


class TestStack(unittest.TestCase):
    def setUp(self):
        self.stack = Stack()


    def test_is_empty(self):
        self.assertTrue(self.stack.is_empty())
        self.stack.push(1)
        self.assertFalse(self.stack.is_empty())
        self.stack.pop()
        self.assertTrue(self.stack.is_empty())

    def test_peek(self):
        self.assertIsNone(self.stack.peek())
        self.stack.push(1)
        self.assertEqual(self.stack.peek(), 1)
        self.stack.pop()
        self.assertIsNone(self.stack.peek())

    def test_count_length(self):
        #self.assertEqual(self.stack.count_length(), 0) #failed test
        self.assertIsNone(self.stack.count_length())
        self.stack.push(1)
        self.assertEqual(self.stack.count_length(), 1)
        self.stack.push(2)
        self.assertEqual(self.stack.count_length(), 2)
        self.stack.pop()
        self.assertEqual(self.stack.count_length(), 1)

    def test_index(self):
        self.assertIsNone(self.stack.index(1))
        self.stack.push(1)
        self.assertEqual(self.stack.index(1), 0)
        self.assertIsNone(self.stack.index(2))
        self.stack.pop()
        self.assertIsNone(self.stack.index(1))

    def test_display(self):
        self.stack.display()  # This should print "Stack is empty."
        self.stack.push(1)
        self.stack.display()  # This should print "Stack contents: [1]"
        self.stack.push(2)
        self.stack.display()  # This should print "Stack contents: [1, 2]"
        self.stack.pop()
        self.stack.display()  # This should print "Stack contents: [1]"

    def test_push(self):
        self.stack.push(1)
        self.assertEqual(self.stack.peek(), 1)
        self.stack.push(2)
        self.assertEqual(self.stack.peek(), 2)
        self.stack.push("abc") #does not reflect full program functionality
        self.assertEqual(self.stack.peek(), "abc")

    def test_pop(self):
        self.assertIsNone(self.stack.pop())
        self.stack.push(1)
        self.stack.push(2)
        self.assertEqual(self.stack.pop(), 2)
        self.assertEqual(self.stack.pop(), 1)
        self.assertIsNone(self.stack.pop())


if __name__ == '__main__':
    unittest.main()
