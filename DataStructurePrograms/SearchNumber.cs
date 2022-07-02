using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
    internal class SearchNumber
    {
        public static List<int>[] FillHashtable(int[] inputArray)

        {
            List<int>[] slot = new List<int>[11];

            //creating Objects of  List
            for (int i = 0; i < slot.Length; i++)
            {
                slot[i] = new List<int>();
            }
            //Filling the Objects
            for (int i = 0; i < inputArray.Length; i++)
            {
                int Index = inputArray[i] % 11;
                slot[Index].Add(inputArray[i]);
            }
            return slot;
        }
        public static bool search(List<int>[] slot, int number)
        {
            int Index = number % 11;
            return slot[Index].Contains(number);
        }
        public static void DisplayHashTable(List<int>[] slot)
        {
            Console.WriteLine("Elements at each index.....");
            for (int i = 0; i < slot.Length; i++)
            {
                Console.Write(i + " --> " + slot[i] + "\n");
            }

        }

    }
}
