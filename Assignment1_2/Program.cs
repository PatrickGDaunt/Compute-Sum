/*
 * Author: Patrick D
 * Created: 27 Sep 2020
 * Description: Computes the sum of declared integer arrays
 */

using System;

namespace Assignment1_2
{
    class Assignment1_2
    {
        static void Main(string[] args)
        {
            Assignment1_2 a12 = new Assignment1_2(); // Create class object

            // Declare integer arrays
            int[] intArray1 = { 2, 7, 12 };
            int[] intArray2 = { 25, 45, 9 };
            int[] intArray3 = { 100, 125, 75, 200 };

            // Pass the declared arrasys through DisplayIntegersAndSum()
            a12.DisplayIntegersAndSum(intArray1);
            a12.DisplayIntegersAndSum(intArray2);
            a12.DisplayIntegersAndSum(intArray3);
        }

        public int ComputeSum(int[] intArray) // Function passes an integer array and returns the sum
        {
            int sum = 0; // Declare sum variable and set to 0

            for (int x = 0; x < intArray.Length; ++x) // Iterate through array
            {
                sum += intArray[x]; // Adds each integer of the array to the sum varaible
            }
            return sum; // Returns the sum of they passed array
        }

        public void DisplayIntegersAndSum(int[] intArray) // Function passes an integer array and writes the sum in the console
        {
            foreach (int i in intArray) // Iterate through each index of the array
            {
                Console.Write("{0} ", i); // Write each index of the array to console
            }
            int sum = ComputeSum(intArray); // Asign return sum value of ComputeSum() to varaible
            Console.WriteLine(Environment.NewLine + "The sum is {0}", sum); // Closing method statement to console
        }
    }
}
