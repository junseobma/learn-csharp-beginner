namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //SayHello();
            var program = new Program();
            program.SayHello("Junseob", 30);
            program.SayHello("Iron Man", 20);

            int number = AddNumbers(1, 2, 3);
            Console.WriteLine(number);
            number = AddNumbers(4, 5);
            Console.WriteLine(number);

            Console.WriteLine(program.IsPositive(10));
            Console.WriteLine(program.IsPositive(0));
            Console.WriteLine(program.IsPositive(-5));
        }

        // 인스턴스 메서드, 인스턴스 = 클래스의 실체(실제로 만든 객체)
        void SayHello(string playerName, int age)
        {
            Console.WriteLine($"Hello {playerName} you are {age} years old!");
        }

        static int AddNumbers(int x, int y)
        {
            return x + y;
        }

        static int AddNumbers(int x, int y, int z)
        {
            return x + y + z;
        }

        bool IsPositive(int x)
        {
            return x > 0;
        }
    }
}
