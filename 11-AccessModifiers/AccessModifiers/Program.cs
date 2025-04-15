// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers

namespace AccessModifiers
{
    //internal class Program
    public class Program
    {
        private static void Main(string[] args)
        {
            Car myCar = new Car("morning", "One of the best cars");
            myCar.SayHello();
        }

        private class Car
        {
            private string m_name;
            private string m_description;

            public Car(string name, string description)
            {
                m_name = name;
                m_description = description;
            }

            public void SayHello()
            {
                Console.WriteLine($"Hi, my name is {m_name}. {m_description}.");
            }
        }
    }
}
