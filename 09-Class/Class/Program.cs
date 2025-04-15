using System;
using System.Xml.Linq;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Player junseobPlayer = new Player();
            junseobPlayer.name = "Junseob";
            junseobPlayer.SayHello();
             
            Player ironManPlayer = new Player();
            ironManPlayer.name = "Iron Man";
            ironManPlayer.SayHello();

            Console.WriteLine(junseobPlayer.GetHashCode() + " " + ironManPlayer.GetHashCode());
            Console.WriteLine(junseobPlayer.name.GetHashCode() + " " + ironManPlayer.name.GetHashCode());

            Enemy GumbaEnemy = new Enemy("Gumba");
            GumbaEnemy.SayHello();
        }

        class Player
        {
            public string name = "Junseob";

            public Player()
            {
                Console.WriteLine($"Creating Player {name}!");
            }

            public void SayHello()
            {
                Console.WriteLine($"Hello! {name}~");
            }
            // SayHello()는 인스턴스(객체)용 메서드니까,
            // Player.SayHello() 이렇게는 안된다. (객체 없이 호출 불가)

            // 반면 Console.WriteLine()은 Console 클래스의 static 메서드, 
            // public static void WriteLine(string? value)
            // 그래서 객체 없이 Console.WriteLine()처럼 클래스 이름만으로 호출 가능하다.

            // public static void SayHello() 이렇게 한다면 Player.SayHello(); 호출 가능
        }

        class Enemy
        {
            public string m_name = "empty";

            public Enemy(string name)
            {
                m_name = name; // == this.m_name = name;
                Console.WriteLine($"Creating Enemy {m_name}!");
            }

            public void SayHello()
            {
                Console.WriteLine($"Oh! {m_name}~");
            }
        }
    }
}
