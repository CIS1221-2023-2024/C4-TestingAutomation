using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priciples_Assignment_3
{
    //Stack class represents a basic stack data structure 
    class Stack
    {
        //Private list to store stack elements
        private List<int> items = new List<int>();



        // Pop and display the top element from the stack
        public int Pop()
        {
            if (!IsEmpty())
            {
                int poppedItem = items[items.Count - 1];
                items.RemoveAt(items.Count - 1);
                Console.WriteLine($"Popped Element {poppedItem} from the Stack.");
                return poppedItem;
            }
            else
            {
                Console.WriteLine("Nothing to Pop Stack is Empty!");
                return -1;
            }
        }


        // Display and return the index of the specified element in the stack
        public int Index(int item)
        {
            if (!IsEmpty())
            {
                int index = items.Count - items.LastIndexOf(item) - 1;
                Console.WriteLine($"Index of Element {item} in the Stack is: {index}");
                return index;
            }
            else
            {
                Console.WriteLine($"Element {item} NOT found in the Stack!");
                return -1;
            }
        }


        // Display the current contents of the stack
        public void Display()
        {
            if (!IsEmpty())
            {
                Console.WriteLine("Current Contents of the stack are: " + string.Join(", ", items));
            }
            else
            {
                Console.WriteLine("Nothing to Display! Stack is Empty!");
            }
        }

        // Push the specified element onto the top of the stack
        public void Push(int item)
        {
            items.Add(item);
            Console.WriteLine($"Push the specified {item} onto the top of the Stack.");
        }


        // Display and return the top element of the stack
        public void Peek()
        {
            if (!IsEmpty())
            {
                Console.WriteLine($"Top Stack is: {items[items.Count - 1]}");
            }
            else
            {
                Console.WriteLine("Nothing to Peek! Stack is Empty!");
            }
        }



        // Display and return the count of elements in the stack
        public int Length()
        {
            int count = items.Count;
            Console.WriteLine($"Number of Elements in the Stack is: {count}");
            return count;
        }

        //Check if the stack is IsEmpty
        public bool IsEmpty()
        {
            return items.Count == 0;
        }



    }


    // MenuInterface class handles the display of the user menu and user input
    class MenuInterface
    {
        // Display the main user menu for stack operations/functions
        public static void DisplayMenu()
        {
            Console.WriteLine("\nStack Data Structure Operations");
            Console.WriteLine("[1] - Pop");
            Console.WriteLine("[2] - Index");
            Console.WriteLine("[3] - Display");
            Console.WriteLine("[4] - Push");
            Console.WriteLine("[5] - Peek");
            Console.WriteLine("[6] - Length");
            Console.WriteLine("[7] - Is Empty?");
            Console.WriteLine("[X] - Exit");
        }

        // Get user input for stack operation/function selection
        public static string GetUserSelection()
        {
            Console.Write("Select [1-7] for Stack Operations or [X] to Exit Program: ");
            return Console.ReadLine()?.ToUpper();
        }
    }

    // MainProgramLogic class contains the logic coordinating stack operations/functions
    class MainProgramLogic
    {
        // Initialize MainProgramLogic with an instance of the Stack class
        private Stack stack = new Stack();

        // Execute main program logic; display the user menu, and call stack operations, or exit, based on user input
        public void Run()
        {
            while (true)
            {

                // Display the user menu and get user selection
                MenuInterface.DisplayMenu();
                string selection = MenuInterface.GetUserSelection();

                // Handle user selection; call/perform corresponding stack operations/functions
                switch (selection)
                {
                    case "1":
                        // Pop and display the top element from the stack
                        stack.Pop();
                        break;


                    case "2":
                        // Find the index of a specified element in the stack, based on user input
                        while (true)
                        {
                            Console.Write("Enter the (Digit) Element to find its Index or [C] to Cancel Operation: ");
                            string input = Console.ReadLine()?.ToUpper();

                            if (input == "C")
                            {
                                Console.WriteLine("Index Search Operation Cancelled.");
                                break;
                            }

                            if (int.TryParse(input, out int item))
                            {
                                stack.Index(item);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input! Enter the Index or [C] to Cancel.");
                            }
                        }
                        break;


                    case "3":
                        // Display the current contents of the stack
                        stack.Display();
                        break;

                    case "4":
                        // Push a specified element onto the stack, based on user input
                        while (true)
                        {
                            Console.Write("Enter a (Digit) Element to Push or [C] to Cancel Operation: ");
                            string input = Console.ReadLine()?.ToUpper();

                            if (input == "C")
                            {
                                Console.WriteLine("Push Operation Cancelled.");
                                break;
                            }

                            if (int.TryParse(input, out int item))
                            {
                                stack.Push(item);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input! Enter a Digit Element to Push or [C] to Cancel.");
                            }
                        }
                        break;

                    case "5":
                        // Display and return the top element of the stack
                        stack.Peek();
                        break;

                    case "6":
                        //The count of elements in the stack
                        stack.Length();
                        break;


                    case "7":
                        //Check if the stack is IsEmpty
                        if (stack.IsEmpty())
                            Console.WriteLine("Stack is Empty.");
                        else
                            Console.WriteLine("Stack is NOT Empty.");
                        break;

                    case "X":

                        // Exit the program
                        Console.WriteLine("Exiting Stack Operations program....");
                        return;

                    default:

                        // Handle invalid/erroneous user input
                        Console.WriteLine("Invalid Selection! Input [1-7] for Stack Operations or [X] to Exit.");
                        break;
                }
            }
        }
    }


    // Program class - Run the main program logic
    class Program
    {
        static void Main()
        {
            // Run the main program logic
            MainProgramLogic program = new MainProgramLogic();
            program.Run();
        }
    }
}