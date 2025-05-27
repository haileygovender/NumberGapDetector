using System.Runtime.CompilerServices;

namespace MissingNumber
{
     class Program
    {
        static void Main(string[]args)
        {
            int[] numberList = new int[] { 1, 2, 3, 5, 6, 8,10 }; // Can be unsorted
            List<int> missingNumbers = new List<int>(); //the list holds the values which are missing

            Array.Sort(numberList); // sort array always to ensure the count is from 1

            // we use start and end to ensure the full range of numbers should be looped
            /* This ensures no numbers are missed*/
            int start = numberList.First();
            int end = numberList.Last();

            for (int i = start; i <=end; i++)
            {
                //checks if the numberlist contains the number
                if (!numberList.Contains(i))
                {
                    //if not this value will be added to the list
                    missingNumbers.Add(i);
                }
            }

            Console.WriteLine("Missing numbers in the array:");

            // if the list contain a number or numbers
            if (missingNumbers.Count > 0)
            {
                foreach (var item in missingNumbers)
            {
                //display the numbers
                    Console.WriteLine(item);
               
            }
            }
            else
            {//the list holds no numbers
                Console.WriteLine("\n.....There is no missing numbers");
            }

            Console.ReadLine();
        }
    }
}