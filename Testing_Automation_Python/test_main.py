
# Import the necessary modules for unit testing

# Import the unittest module for creating and running unit tests
import unittest

# Import the sys module for interacting with the Python interpreter
import sys
# Import the StringIO class from the io module to capture and manipulate standard output
from io import StringIO


# Import the Stack class from the main module, to enable testing of its functions/operations
from main import Stack


class TestStack(unittest.TestCase):
    # TestStack class - tests on stack functions/operations, inherits from unittest.TestCase
    def setUp(self):
        # Set up a stack instance/object for testing before each test case
        print("Setting up stack instance/object for testing...")
        self.stack = Stack()

    def test_is_empty(self):
        # Test the is_empty function
        print("Initiating is_empty function tests...")
        # Assert that the stack is empty initially
        self.assertTrue(self.stack.is_empty(), "Stack should be empty initially.")
        # Push an element and check that the stack is not empty
        self.stack.push(1)
        self.assertFalse(self.stack.is_empty(), "Stack should not be empty after pushing an element.")
        # Pop the element and check that the stack is empty again
        self.stack.pop()
        self.assertTrue(self.stack.is_empty(), "Stack should be empty after popping all elements.")
        print("Finished executing is_empty function tests...")
        print("*  *  *  *  *")

    def test_peek(self):
        # Test the peek function
        print("Initiating peek function tests...")
        # Assert that peek on an empty stack should return None
        self.assertIsNone(self.stack.peek(), "Peek on an empty stack should return None.")
        # Push an element, then peek and check if it returns the correct value
        self.stack.push(1)
        self.assertEqual(self.stack.peek(), 1, "Peek should return the top element without removing it.")
        # Pop the element and check if peek on an empty stack returns None
        self.stack.pop()
        self.assertIsNone(self.stack.peek(), "Peek on an empty stack should return None after popping.")
        print("Finished executing peek function tests...")
        print("*  *  *  *  *")

    def test_count_length(self):
        # Test the count_length function
        print("Initiating count/length function tests...")
        ## Example of failed test. Implementation returns none and a message, on count/length, when stack is empty (not 0)
        ## self.assertEqual(self.stack.count_length(), 0)
        # Assert that count/length on an empty stack should return None
        self.assertIsNone(self.stack.count_length(), "Count/length on an empty stack should return None.")
        # Push an element and check if count reflects the number of elements
        self.stack.push(1)
        self.assertEqual(self.stack.count_length(), 1, "Count should reflect the number of elements after pushing.")
        # Push another element and check if count reflects the total number of elements
        self.stack.push(2)
        self.assertEqual(self.stack.count_length(), 2, "Count should reflect the total number of elements after subsequent pushes.")
        # Pop an element and check if count reflects the correct number of elements
        self.stack.pop()
        self.assertEqual(self.stack.count_length(), 1, "Count should reflect the correct number of elements after popping.")
        print("Finished executing count/length function tests...")
        print("*  *  *  *  *")

    def test_index(self):
        # Test the index function
        print("Initiating index function tests...")
        # Assert that index on an empty stack should return None
        self.assertIsNone(self.stack.index(1), "Index on an empty stack should return None.")
        # Push an element and check if index returns the correct index of the element
        self.stack.push(1)
        self.assertEqual(self.stack.index(1), 0, "Index should return the correct index of the element.")
        # Check if index returns None for an element not in the stack
        self.assertIsNone(self.stack.index(2), "Index should return None for an element not in the stack.")
        # Push another element and check if index returns the correct index of the element after pushing multiple elements
        self.stack.push(2)
        self.assertEqual(self.stack.index(2), 1, "Index should return the correct index of the element after pushing multiple elements.")
        # Pop an element and check if index returns None for an element popped from the stack
        self.stack.pop()
        self.assertIsNone(self.stack.index(2), "Index should return None for an element popped from the stack.")
        # Pop remaining element and check if index on an empty stack returns None
        self.stack.pop()
        self.assertIsNone(self.stack.index(1), "Index on an empty stack should return None after popping all elements.")
        print("Finished executing index function tests...")
        print("*  *  *  *  *")

    def test_display_base_initial(self):
        # Test the display function (base/initial tests)
        print("Initiating display function base/initial tests...")
        # Display on an empty stack should print "Nothing to Display! Stack is Empty!"
        self.stack.display()
        # Push an element and check if display prints the correct stack contents
        # This should print "Current Stack Contents are: [1]"
        self.stack.push(1)
        self.stack.display()
        # Push another element and check if display prints the correct stack contents after pushing multiple elements
        # This should print "Current Stack Contents are: [1, 2]"
        self.stack.push(2)
        self.stack.display()
        # Pop an element and check if display prints the correct stack contents after popping an element
        # This should print "Current Stack Contents are: [1]"
        self.stack.pop()
        self.stack.display()
        print("Finished executing display function base/initial tests...")
        print("*  *  *  *  *")

    def test_display_capture(self):
        # Test the display function (capturing output tests)
        print("Initiating display function capture tests...")
        ## Save the original standard output
        original_stdout = sys.stdout

        # Display on an empty stack, capturing the output and checking if it matches the expected message
        ## Create a StringIO object to capture output
        captured_output1 = StringIO()
        ## Redirect standard output to the StringIO object, to capture print statements
        sys.stdout = captured_output1
        self.stack.display()
        self.assertEqual(captured_output1.getvalue().strip(), "Nothing to Display! Stack is Empty!",
                         "Display on an empty stack should print 'Nothing to Display! Stack is Empty!'")
        ## Restore the original standard output
        sys.stdout = original_stdout

        # Display after pushing an element, capturing the output and checking if it matches the expected value
        captured_output2 = StringIO()
        sys.stdout = captured_output2
        self.stack.push(1)
        self.stack.display()
        self.assertEqual(captured_output2.getvalue().strip(), "Pushed Element 1 onto the top of the Stack.\nCurrent Stack Contents are: [1]",
                         "Display should print the correct stack contents after pushing an element: 'Current Stack Contents are: [1]'")
        sys.stdout = original_stdout

        # Display after pushing multiple elements, capturing the output and checking if it matches the expected value
        captured_output3 = StringIO()
        sys.stdout = captured_output3
        self.stack.push(2)
        self.stack.display()
        self.assertEqual(captured_output3.getvalue().strip(), "Pushed Element 2 onto the top of the Stack.\nCurrent Stack Contents are: [1, 2]",
                         "Display should print the correct stack contents after pushing multiple elements: 'Current Stack Contents are: [1, 2]'")
        sys.stdout = original_stdout

        # Display after popping an element, capturing the output and checking if it matches the expected value
        captured_output4 = StringIO()
        sys.stdout = captured_output4
        self.stack.pop()
        self.stack.display()
        self.assertEqual(captured_output4.getvalue().strip(), "Popped Element 2 from the top of the Stack.\nCurrent Stack Contents are: [1]",
                         "Display should print the correct stack contents after popping an element: 'Current Stack Contents are: [1]'")
        sys.stdout = original_stdout

        print("Finished executing display function capture tests...")
        print("*  *  *  *  *")

    def test_push(self):
        # Test the push function
        print("Initiating push function tests...")
        # Push an element and check if it is at the top of the stack
        self.stack.push(1)
        self.assertEqual(self.stack.peek(), 1, "Pushed element should be at the top of the stack.")
        # Push another element and check if the last pushed element is at the top of the stack
        self.stack.push(2)
        self.assertEqual(self.stack.peek(), 2, "Last pushed element should be at the top of the stack.")
        ## Demonstrate pushing a different data type, but does not reflect final program functionality,
        ## as input validation at the inputting stage (through the menu) ensure only valid input is accepted.
        self.stack.push("abc")
        self.assertEqual(self.stack.peek(), "abc", "Last pushed element (different data type) should be at the top of the stack.")
        print("Finished executing push function tests...")
        print("*  *  *  *  *")

    def test_pop(self):
        # Test the pop function
        print("Initiating pop function tests...")
        # Pop on an empty stack should return None
        self.assertIsNone(self.stack.pop(), "Pop on an empty stack should return None.")
        # Push multiple elements, then pop and check if it returns the correct popped element at each stage
        self.stack.push(1)
        self.stack.push(2)
        self.assertEqual(self.stack.pop(), 2, "Pop should return the popped element from the top of the stack.")
        self.assertEqual(self.stack.pop(), 1, "Pop should return the popped element from the top of the stack.")
        # Pop on an empty stack should return None after popping all elements
        self.assertIsNone(self.stack.pop(), "Pop on an empty stack should return None after popping all elements.")
        print("Finished executing pop function tests...")
        print("*  *  *  *  *")


if __name__ == '__main__':
    # Run the unit tests
    unittest.main()
