using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Func my_func = new Func(1, 1);
            my_func.show();
            Func.Point point = my_func.GetOXpoint();
            Console.WriteLine("OX : (" + point.x + ", " + point.y + ")");

            point = my_func.GetOYpoint();
            Console.WriteLine("OY : (" + point.x + ", " + point.y + ")");


            Func my_func2 = new Func(10f, 3);
            my_func2.show();
            point = my_func2.GetOXpoint();
            Console.WriteLine("OX : (" + point.x + ", " + point.y + ")");

            point = my_func2.GetOYpoint();
            Console.WriteLine("OY : (" + point.x + ", " + point.y + ")");


            Console.WriteLine("Line1 == Line2 : " + (my_func == my_func2));
            Console.WriteLine("Line1 != Line2 : " + (my_func != my_func2));


            Console.WriteLine("Angle : " + (my_func % my_func2));

            Console.ReadKey();
        }
    }
    public class Func
    {
        public float a;
        public float b;
        public struct Point
        {
            public float x;
            public float y;
        }
        public Func(float a, float b)
        {
            this.a = a;
            this.b = b;
        }
        public Point GetOXpoint()
        {
            Point p;
            p.x = -b/a;
            p.y = 0f;
            return p;
        }
        public Point GetOYpoint()
        {
            Point p;
            p.x = 0f;
            p.y = b;
            return p;
        }
        public static bool operator !=(Func f1, Func f2)
        {
            return f1.a == -1 / f2.a;
        }
        public static bool operator ==(Func f1, Func f2)
        {
            return f1.a == f2.a;
        }
        public void show ()
        {
            Console.WriteLine("y =" + a + "x +" + b);

        }

        public static float operator %(Func f1, Func f2)
        {
            if (!(f1 != f2))
            {
                double tg = Math.Abs((f1.a - f2.a) / (1 + f1.a * f2.a));
                return (float)(Math.Atan(tg) / Math.PI * 180);
            }

            return 90;
        }
    }
    
}

