namespace Prak2_
{

    public class Rectangle
    {
        public int x, y;
        static int z, v;

        public Rectangle()
            {
                x = 5;
                y = 5;
            }

        public Rectangle(int x, int y) 
        {
            this.x = x;
            this.y = y;
        }

        public Rectangle(Rectangle r) { 
            this.x = r.x;
            this.y = r.y;
        }

        static Rectangle()
        {
            z = 3;
            v = 7;
        }
        ~Rectangle() {
            Console.WriteLine("Диструктор");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new ();
            Console.WriteLine($"Длина: {r1.x} Ширина: {r1.y} Площадь: {r1.x * r1.y} ");

            Rectangle r2 = new(3, 4);
            Console.WriteLine($"Длина: {r2.x} Ширина: {r2.y} Площадь: {r2.x * r2.y} ");

        }
    }
}
