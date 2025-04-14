using System.Collections.Generic;

namespace ArraysAndLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ---------- Array ---------- //
            int[] numbersArray = { 13, 82, 35, 42, 51, 56, 79 };
            
            int[] numbersArray2 = new int[5];
            Console.WriteLine(numbersArray2.Length);
            Console.WriteLine(numbersArray2[0]); // 할당되지 않은 값은 0으로 초기화 된다.
            numbersArray2[1] = 10;
            Console.WriteLine(numbersArray2[1]); // 10

            //numbersArray.IndexOf(); // error, 없다.
            Console.WriteLine(System.Array.IndexOf(numbersArray, 51)); // 이렇게 쓸 수 있다.

            // ---------- List ---------- //
            List<int> numbersList = new List<int>();

            numbersList.Add(12);
            numbersList.Insert(1, 34);
            Console.WriteLine($"numbersList.Count: {numbersList.Count}");
            Console.WriteLine($"numbersList[0]: {numbersList[0]}");

            numbersList.Insert(1, 56);
            numbersList.Remove(12);
            Console.WriteLine($"numbersList.Count: {numbersList.Count}");
            Console.WriteLine($"numbersList[0]: {numbersList[0]}");

            numbersList.RemoveAt(0);
            Console.WriteLine($"numbersList.Count: {numbersList.Count}");
            Console.WriteLine($"numbersList[0]: {numbersList[0]}");

            Console.WriteLine("numbersList.Contains(56): " + numbersList.Contains(56));
            numbersList.Add(56);
            Console.WriteLine("numbersList.Contains(56): " + numbersList.Contains(56));
            Console.WriteLine("numbersList.IndexOf(56): " + numbersList.IndexOf(56));

            // ---------- List Capacity ---------- //
            List<int> numbersList2 = new List<int>(2); // Capacity 할당 가능
            Console.WriteLine(numbersList2.Capacity); // 2 list.Capacity: 현재 내부 배열 크기, 할당된 버퍼 크기
            Console.WriteLine(numbersList2.Count); // 0 list.Count: 실제 요소 개수, 넣은 데이터 수

            numbersList2.Add(1);
            numbersList2.Add(2);
            Console.WriteLine(numbersList2.Capacity); // 2

            numbersList2.Add(3);
            Console.WriteLine(numbersList2.Capacity); // 4 또는 8 (자동 증가됨)
            Console.WriteLine(numbersList2.Count); // 3

        }
    }
}
