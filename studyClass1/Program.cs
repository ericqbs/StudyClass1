using System;

namespace studyClass1
{
    class Program
    {
        public delegate int DemoDelegate(int num);
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //DemoDelegate dd = new DemoDelegate(Square);
            ////dd += Square;
            //dd += Remainder;
            //dd(11);
            //int ii = Console.Read();
            ////Console.Read()
            //Console.WriteLine(ii);
            Func<int,int,int,int> pp = (x,y,z)=> x + y+z;
            Console.WriteLine(pp(3, 4,1));

            Func<int> kk = () => 123;
            Console.WriteLine(kk());


        }
        static int Square(int num)
        {
            Console.WriteLine(num*num);
            return num * num;
        }
        static int Remainder(int num)
        {
            Console.WriteLine(num%2);
            return num % 2;
        }
        
    }
}
