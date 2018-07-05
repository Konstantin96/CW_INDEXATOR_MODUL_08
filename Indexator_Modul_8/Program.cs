using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexator_Modul_8
{
    class Program
    {
        public class MyArray
        {
            int[] numbers;
            int[,] numbers2;
            public int Lenght;
            public MyArray(int size)
            {
                numbers = new int[size];
                Lenght = size;
            }
            public int this[int index]
            {
                get { return numbers[index]; }
                set { numbers[index] = value; }
            }
            public int this[int x,int y]
            {
                get { return numbers2[x,y]; }
                set { numbers2[x,y] = value; }
            }
            public void test(out string massage)
            {
                massage = "";
            }
            public int x, y, z;
            public MyArray(int x = 0, int y = 0, int z = 0)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
            public static bool operator ==(MyArray a, MyArray b)
            {
                if ((a.x == b.x) || (a.y == b.y))
                    return true;
                else
                    return false;
            }
            public static bool operator !=(MyArray a, MyArray b)
            {
                if ((a.x != b.x) || (a.y != b.y))
                    return true;
                else
                    return false;
            }
            public static bool operator true(MyArray a)
            {
                if ((a.x < 0))
                    return true;
                else
                    return false;
            }
            public static bool operator false(MyArray a)
            {
                if ((a.x > 0))
                    return true;
                else
                    return false;
            }
        }
        public class Triangle
        {
            
            public Triangle(int a = 0, int b = 0, int c = 0)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            public int a { get; set; }
            public int b { get; set; }
            public int c { get; set; }

            public static Triangle operator ++(Triangle a)
            {
                return new Triangle(a.a + 1, a.b + 1, a.c + 1);
            }
            public static Triangle operator --(Triangle a)
            {
                return new Triangle(a.a - 1, a.b - 1, a.c - 1);
            }
            public static bool operator true(Triangle a)
            {
                if (a.a == a.b && a.c == a.a)
                {
                    return true;
                }
                else return false;
            }
            public static bool operator false(Triangle a)
            {
                if (a.a == a.b && a.c == a.a)
                {
                    return false;
                }
                else return true;
            }
            public static Triangle operator *(Triangle a, Triangle b)
            {
                return new Triangle(a.a * a.b);
            }
            public override string ToString()
            {
                return string.Format("Triangle {0},{1},{2}", a, b, c);
            }
        }
        static void Main(string[] args)
        {
            MyArray arr = new MyArray(30,30,30);
            arr[5,5] = 100;
            int val = arr[5,5];
            Console.WriteLine(val);
        }
    }
}
