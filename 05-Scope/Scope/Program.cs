namespace Scope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isPlayer = false;

            int age = 30;

            age = OtherScope(age);
            Console.WriteLine(age);
        }

        static int OtherScope(int age)
        {
            //isPlayer = true; //error

            return ++age;
        }
    }
}
