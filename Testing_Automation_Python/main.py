
class Stack:
    # Stack class - main stack functions/operations, for a basic stack data structure

    def __init__(self):
        # Initialize an empty list to represent the stack
        self.items = []

    def is_empty(self):
        # Check if the stack is empty
        return len(self.items) == 0

    def peek(self):
        # Display and return the top element of the stack
        if not self.is_empty():
            print(f"Top Element of the Stack is: {self.items[-1]}")
            return self.items[-1]
        else:
            print("Nothing to Peek at! Stack is Empty!")
            return None

    def count_length(self):
        # Display and return the count/number of elements in the stack
        if not self.is_empty():
            count = len(self.items)
            print(f"Number of Elements in the Stack is: {count}")
            return count
        else:
            print("Nothing to Count here! Stack is Empty!")
            return None

    def index(self, item):
        # Display and return the index of the specified element in the stack
        if not self.is_empty():
            if item in self.items:
                indx = len(self.items) - self.items[::-1].index(item) - 1
                print(f"Index of Element {item} in the Stack is: {indx}")
                return indx
            else:
                print(f"Element {item} NOT found in the Stack!")
                return None
        else:
            print("Cannot find any Index! Stack is Empty!")
            return None

    def display(self):
        # Display the current contents of the stack
        if not self.is_empty():
            print("Current Stack Contents are:", self.items)
        else:
            print("Nothing to Display! Stack is Empty!")

    def push(self, item):
        # Push the specified element onto the top of the stack
        self.items.append(item)
        print(f"Pushed Element {item} onto the top of the Stack.")

    def pop(self):
        # Pop and display the top element from the stack
        if not self.is_empty():
            popped_item = self.items.pop()
            print(f"Popped Element {popped_item} from the top of the Stack.")
            return popped_item
        else:
            print("Nothing to Pop here! Stack is Empty!")
            return None


class MenuInterface:
    # MenuInterface class - display menu and get user input methods, for a basic stack data structure

    @staticmethod
    def display_menu():
        # Display main user menu for stack operations/functions
        print("\nStack Data Structure Operations")
        print("[1] - Is Empty?")
        print("[2] - Peek")
        print("[3] - Count/Length")
        print("[4] - Index")
        print("[5] - Display")
        print("[6] - Push")
        print("[7] - Pop")
        print("[X] - Exit")

    @staticmethod
    def get_user_selection():
        # Get user input for stack operation/function selection
        return input("Select [1-7] for Stack Operations or [X] to Exit Program: ")


class MainProgramLogic:
    # MainProgramLogic class - logic coordinating stack operations/functions, based on user input.

    def __init__(self):
        # Initialize MainProgramLogic with an instance of the Stack class
        self.stack = Stack()

    def run(self):
        # Execute main program logic; display the user menu, and call stack operations, or exit, based on user input

        while True:
            # Display the user menu and get user selection
            MenuInterface.display_menu()
            selection = MenuInterface.get_user_selection()

            # Handle user selection; call/perform corresponding stack operations/functions
            if selection == '1':
                # Check if the stack is empty or not
                if self.stack.is_empty():
                    print("Stack is Empty.")
                else:
                    print("Stack is NOT Empty.")

            elif selection == '2':
                # Peek at the top element of the stack
                self.stack.peek()

            elif selection == '3':
                # Count and display the length (number of elements) in the stack
                self.stack.count_length()

            elif selection == '4':
                # Find the index of a specified element in the stack, based on user input
                while True:
                    item = input("Enter the (Digit) Element to find its Index or [C] to Cancel Operation: ")

                    if item.upper() == 'C':
                        print("Index Search Operation Cancelled.")
                        break

                    if item.isdigit():
                        item = int(item)
                        self.stack.index(item)
                        break

                    else:
                        print("Invalid Input! Enter the Digit Element to identify its Index or [C] to Cancel.")

            elif selection == '5':
                # Display the current contents (elements) of the stack
                self.stack.display()

            elif selection == '6':
                # Push a specified element onto the stack, based on user input
                while True:
                    item = input("Enter a (Digit) Element to Push or [C] to Cancel Operation: ")

                    if item.upper() == 'C':
                        print("Push Operation Cancelled.")
                        break

                    if item.isdigit():
                        item = int(item)
                        self.stack.push(item)
                        break

                    else:
                        print("Invalid Input! Enter a Digit Element to Push or [C] to Cancel.")

            elif selection == '7':
                # Pop and display the top element from the stack
                self.stack.pop()

            elif selection.upper() == 'X':
                # Exit the program
                print("Exiting Stack Operations program....")
                break

            else:
                # Handle invalid/erroneous user input
                print("Invalid Selection! Input [1-7] for Stack Operations or [X] to Exit.")


if __name__ == "__main__":
    # Run the main program logic
    program = MainProgramLogic()
    program.run()
