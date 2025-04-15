namespace Static
{
    internal class Program
    {
        int age;

        static void Main(string[] args)
        {
            // SayHello()는 인스턴스(객체)용 메서드니까,
            // Enemy.SayHello() 이렇게는 안된다. (객체 없이 호출 불가)
            /*
            Enemy GumbaEnemy = new Enemy("Gumba");
            GumbaEnemy.SayHello();
            */

            // 반면 Console.WriteLine()은 Console 클래스의 static 메서드, 
            // public static void WriteLine(string? value)
            // 그래서 객체 없이 Console.WriteLine()처럼 클래스 이름만으로 호출 가능하다.
            Enemy.SayHello();

            //age = 50; // error, static안에는 static 함수 내부에는 static 변수만 접근 가능하다.

            new Enemy("Gumba"); //Creating Enemy Gumba!
            Enemy.SayHello(); //Oh! Gumba~
            new Enemy("Koopa"); //Creating Enemy Koopa!
            Enemy.SayHello(); //Oh! Koopa~
        }

        class Enemy
        {
            //public string m_name = "empty"; // error, SayHello를 Static으로 변경하니, static 함수라 접근 불가능
            public static string m_name = "empty"; // static으로 수정, 

            public Enemy(string name)
            {
                //this.m_name = name; // error, m_name은 static으로 어떤 인스턴스에도 속하지 않습니다.
                Enemy.m_name = name;
                Console.WriteLine($"Creating Enemy {m_name}!");
            }

            // public static void SayHello() 이렇게 한다면 Enemy.SayHello(); 호출 가능
            public static void SayHello()
            {
                Console.WriteLine($"Oh! {m_name}~");
            }
        }
    }
}
