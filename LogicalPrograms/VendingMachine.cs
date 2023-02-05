using System;

namespace LogicalPrograms
{
    internal class VendingMachine
    {
        public static void GetMinimumNotes()
        {
            Console.WriteLine("Please enter the amout ");
            int amount = Convert.ToInt32(Console.ReadLine());
            int[] notes = { 1, 2, 5, 10, 50, 100, 500, 1000 };
            int noteCount = 0;
            for (int i = 7; i >= 0; i--)
            {
                if (notes[i] <= amount)
                {
                    amount = amount - notes[i];
                    Console.Write(notes[i] + ",");
                    i += 1;
                    noteCount++;
                }
                if (amount == 0)
                {
                    break;
                }
            }
            Console.WriteLine("\nTotal no of minimum notes returned by vending machine:{0} ", noteCount);
        }
    }
}