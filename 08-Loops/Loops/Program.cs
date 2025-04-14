namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ---------- while ---------- //
            int i = 0;
            while (i < 3) // 0, 1, 2, 3(out)
            {
                Console.WriteLine("Loop..." + i);
                i++;
            }

            // ---------- do-while ---------- //
            // do-while은 "조건이 false여도 한 번은 무조건 실행" 하지만,
            do
            {
                Console.WriteLine("do while Loop..." + i);
                i++;
            } while (i < 3);

            // 두 번째부터는 조건을 검사해서 false면 끝난다.
            i = 0;
            do
            {
                Console.WriteLine("do while Loop..." + i);
                i++;
            } while (i < 3);

            // ---------- for ---------- //
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("for loop: " + j);
            }

            string[] nameArray = new string[]
            {
                "AAA",
                "BBB",
                "CCC",
                "DDD"
            };
            for (int k = 0; k < nameArray.Length; k++) // list라면 count
            {
                Console.WriteLine(k + ": " + nameArray[k]);
            }

            // ---------- foreach ---------- //
            foreach (string name in nameArray)
            {
                Console.WriteLine("foreach: " + name);
            }
        }
    }
}