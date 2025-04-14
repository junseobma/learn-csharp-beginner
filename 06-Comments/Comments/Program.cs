namespace Comments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // My comment
            /*
             * Multi
             * Line 
             * Comment
             * 
             */

            int age = 35; /* Anithing */

            /* comment before */
            Console.WriteLine("Hello, World!"); // Some kind of comment

            // 불필요한 주석
            int a = 1; // Define a as int
            int b = 2; // Define b as int
            if (a < b)
            {
                // Increments a by 2
                a += 1;
            }
        }

        // 불필요한 주석, 함수명과 변수명으로 의미 전달을 해서 주석이 없는게 났다. 
        // Print out a hello to a player
        // p - Player Name
        // a - Age
        static void Say(string p, int a)
        {
            Console.WriteLine($"Hello! {p} you are {a} years old~!");
        }

        // 주석이 없는 이 버전이 훨씬 읽기 쉽고 이해하기 쉽습니다. 
        static void SayHello(string playerName, int age)
        {
            Console.WriteLine($"Hello! {playerName} you are {age} years old~!");
        }

    }
}
