namespace _06.ReversedList
{
    using System;
    using System.Collections.Generic;

    public static class ReversedListDemo
    {
        public static void Main()
        {
            // LIST
            var list = new List<int>() { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            for (int i = 0; i < 5; i++)
            {
                list.RemoveAt(i);
            }

            Console.WriteLine(string.Join(", ", list));

            // REVERSED LIST
            var rl = new ReversedList<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < 5; i++)
            {
                rl.Remove(i);
            }

            Console.WriteLine(string.Join(", ", rl));

            Console.WriteLine("++++++++++++++++++++++++");
            var reversedList = new ReversedList<int>(6);
            Console.WriteLine("Empty list: " + reversedList);
            reversedList.Add(1);
            reversedList.Add(2);
            reversedList.Add(3);
            reversedList.Add(4);
            reversedList.Add(5);

            reversedList.Remove(0);
            reversedList.Remove(0);
            foreach (var i in reversedList)
            {
                Console.WriteLine(i);
            }

            return;
            reversedList[0] = 169;
            Console.WriteLine("Capacity: " + reversedList.Capacity);
            Console.WriteLine("Element at index 1 (Should be 6): " + reversedList[1]);

            Console.WriteLine(reversedList);
            reversedList.Remove(4);
            Console.WriteLine(reversedList);
            reversedList[3] = 69;
            Console.WriteLine(reversedList);
            Console.WriteLine("Count: " + reversedList.Count);
            Console.WriteLine("Capacity: " + reversedList.Capacity);
        }
    }
}
