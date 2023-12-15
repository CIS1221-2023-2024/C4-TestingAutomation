using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priciples_Assignment_2
{
    class Program
    {
        class StackProgram
        {
            //Class reperesenting a Stack
            class Stack
            {
                // Private list to store stack items
                private List<string> items = new List<string>();
                //Method to check if the stack is empty
                public bool IsEmpty()
                {
                    
                    return items.Count == 0;
                }
                //Method to push an item onto the stack
                public void Push(string item)
                {
                    
                    items.Add(item);
                    Console.WriteLine($"Pushed {item} onto the stack.");
                }
                //Method to pop an item from the stack
                public string Pop()
                {
                    
                    if (!IsEmpty())
                    {
                        //Rerieve the top item
                        string poppedItem = items[items.Count - 1];
                        //Remove the top item from the stack
                        items.RemoveAt(items.Count - 1);
                        Console.WriteLine($"Popped {poppedItem} from the stack.");
                        return poppedItem;
                    }
                    else
                    {
                        Console.WriteLine("Stack is empty. Cannot pop.");
                        return null;
                    }
                }
                //Method to peek at the top element of the stack
                public void Peek()
                {
                    
                    if (!IsEmpty())
                    {
                        Console.WriteLine($"Top element of the stack: {items[items.Count - 1]}");
                    }
                    else
                    {
                        Console.WriteLine("Stack is empty. Cannot peek.");
                    }
                }

                //Method to get the count of elements in the stack
                public int Count()
                {
                    
                    int count = items.Count;
                    Console.WriteLine($"Number of elements in the stack: {count}");
                    return count;
                }


            }

            //Another class representing the menu
            class Menu
            {
                // Method to display the stack operation menu
                public static void DisplayMenu()
                {
                    Console.WriteLine("\nStack Operations:");
                    Console.WriteLine("1. Push");
                    Console.WriteLine("2. Pop");
                    Console.WriteLine("3. Peek");
                    Console.WriteLine("4. Count/Length");
                    Console.WriteLine("5. Check if Stack is Empty");
                    Console.WriteLine("6. Exit");
                }
                // Method to get the user is choice
                public static string GetUserChoice()
                {
                    Console.Write("Enter your choice (1-6): ");
                    return Console.ReadLine();
                }
            }

            // MainProgram class to run the stack operations
            class MainProgram
            {
                private Stack stack = new Stack();
                
                //Method to run the main program loop
                public void Run()
                {
                    //The Infinite loop to keep the program running until the user chooses to exit
                    while (true)
                    {
                        //Display the menu for stack operations
                        Menu.DisplayMenu();
                        //Get the user is choice
                        string choice = Menu.GetUserChoice();
                        //Switch statement to excute the chosen operation
                        switch (choice)
                        {
                            case "1":
                                //User choose to push an element onto the stack
                                Console.Write("Enter the element to push: ");
                                string item = Console.ReadLine();
                                stack.Push(item);
                                break;
                            case "2":
                                //User choose to pop an element from the stack
                                stack.Pop();
                                break;
                            case "3":
                                //User choose to peek at the top element of the stack
                                stack.Peek();
                                break;
                            case "4":
                                //User choose to get the count of elements in the stack
                                stack.Count();
                                break;
                            case "5":
                                //User choose to check if the stack is empty
                                if (stack.IsEmpty())
                                {
                                    Console.WriteLine("Stack is empty.");
                                }
                                else
                                {
                                    Console.WriteLine("Stack is not empty.");
                                }
                                break;
                            case "6":
                                // User choose to exit the program
                                Console.WriteLine("Exiting program. Goodbye!");
                                return;
                            default:
                                // Invalid choice
                                Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                                break;
                        }
                    }
                }
            }
            //Entry point of the program
            static void Main()
            {
                // Create an instance of MainProgram and run the program
                MainProgram program = new MainProgram();
                program.Run();
            }
        }
    }
}
