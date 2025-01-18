using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            // 1. 
            var numbers = new int[50];
            

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            // 2.
            Populater(numbers);
            
            

            //TODO: Print the first number of the array
            // 3. 
            Console.WriteLine(numbers[0]);

            //TODO: Print the last number of the array
            // 3.
            Console.WriteLine(numbers[numbers.Length - 1]); 

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter();
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */
            
            Array.Reverse(numbers);

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(numbers);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(numbers);
            NumberPrinter(numbers);
            

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var numbersList = new List<int>();
            

            //TODO: Print the capacity of the list to the console
             Console.WriteLine(numbersList.Capacity);
            
            

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this
            Populater(numbersList);
            

            //TODO: Print the new capacity
            Console.WriteLine(numbersList.Capacity);
            

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            bool isAnumber;
            int searchNumber;

            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                isAnumber = int.TryParse(Console.ReadLine(), out searchNumber);
                
            }
            while (!isAnumber);
            NumberChecker(numbersList, searchNumber);
            
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numbersList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(numbersList);
            
            
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            numbersList.Sort();
            
            NumberPrinter(numbersList);
            
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var listCopy = numbersList.ToArray();
            

            //TODO: Clear the list
            numbersList.Clear();
            

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
            NumberPrinter(numbers);
        }

        private static void OddKiller(List<int> numberList)
        
        {
            for (int i = numberList.Count - 1; i >= 0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.RemoveAt(i);
                }
            }
            
            NumberPrinter(numberList);
            
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine("We have that number!");
            }
            else
            {
                Console.WriteLine("We have that number");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

            while (numberList.Count <= 50)
            {
                numberList.Add(rng.Next(0, 51));
            }

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 51);
            }

        }        

       // This method reverses the order of the elements in an int array.
        private static void ReverseArray(int[] array)
        // 'private' means the method can only be accessed within this class.
        // 'static' this means the method belong to the class itself and not an instance of the class.
        // 'void' is the return tupe, meaning the method dose not return a value.
        // 'ReverseArray' is the methods name, writtin in PascalCase.
        // 'int[] array' is the parameter, which is an array of int to be reversed.
        {
            int start = 0;
            // 'start' is a variable initialized to 0, representing the index of the first element in the array.
            
            int end = array.Length - 1;
            // 'end' is a variable initialized to the index of the last element in the array.
            // 'array.Lenght' gives the total number of elements in the array, moving toward the center.

            while (start < end)
                // The 'while' loop runs as long as the 'start' index is less than the 'end' index.
            // This ensures we only swap elements from the beginning and end of the arrays, moving towards the center.
            {
                //Swap elements at start and end positions
                int temp = array[start];
                // 'temp' temporarily stores the value of the elements at the 'start' index.
                // This prevents the value from being overwritten during the swap.
                
                array[start] = array[end];
                // The value at the 'starts' indec is replaced with the value at the 'end' index
                
                array[end] = temp;
                // The value at the 'end' index is replaced with the original value from the 'start' index, which was saved in 'temp'.
        
                
                
                //Moving the values from the indexes towears each other 
                start++;
                // The 'start' index is incremented by 1, moving to the next elementr from the beggining of the arrys.
                
                end--;
                // The 'end' index is decremented by 1, moving to the next element from the end of the array
            }
            //When the loop completes, all the elemnents in the array have being reversed. 
        }


        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
