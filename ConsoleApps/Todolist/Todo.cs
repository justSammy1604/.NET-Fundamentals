using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Our TODO list should:
        // - allow us to exit
        // - allow us to add items to our TODO list
        // - allow us to view what's in the list
        // - allow us to remove items from our TODO list

        Console.WriteLine("Welcome to the TODO list!");
        List<string> todoListItems = new List<string>();

        while (true)
        {
            Console.WriteLine("Here are the options you can select:");
            Console.WriteLine("0 - exit");
            Console.WriteLine("1 - view TODO list");
            Console.WriteLine("2 - add to TODO list");
            Console.WriteLine("3 - remove from TODO list");

            string userInput = Console.ReadLine();
            int optionId;
            bool optionParseResult = int.TryParse(userInput, out optionId);
            if (!optionParseResult)
            {
                Console.WriteLine("Input was not an integer!");
                continue;
            }

            // if statements OR switch statements... that's homework!
            if (optionId == 0)
            {
                break;
            }

            if (optionId == 1)
            {
                Console.WriteLine("Your TODO list:");
                // TODO: print better output when list is empty

                //foreach (string item in todoListItems)
                for (int i = 0; i < todoListItems.Count; i++)
                {
                    string item = todoListItems[i];
                    Console.WriteLine("\t" + i + " - " + item);
                }
            }
            else if (optionId == 2)
            {
                Console.WriteLine("Please enter your TODO list item and then press enter:");
                string newTodoListItem = Console.ReadLine();
                // TODO: validate user input

                todoListItems.Add(newTodoListItem);
            }
            else if (optionId == 3) // removing items
            {
                Console.WriteLine("Please enter the index of the TODO list item to remove and then press enter:");

                string userInputForRemoveIndex = Console.ReadLine();
                int removeIndex;
                bool removeIndexParseResult = int.TryParse(userInputForRemoveIndex, out removeIndex);
                if (!removeIndexParseResult)
                {
                    Console.WriteLine("Input was not an integer!");
                    continue;
                }

                // Must be non-negative and less than the size of the collection.
                if (removeIndex < 0 || removeIndex >= todoListItems.Count)
                {
                    Console.WriteLine("Input must be non-negative and less than the size of the collection!");
                    continue;
                }

                todoListItems.RemoveAt(removeIndex);
                // TODO: tell user it worked!
            }
            else
            {
                Console.WriteLine("That option is not valid!");
            }
        }

        Console.WriteLine("Thanks for using the TODO list! Bye!");
    }
}