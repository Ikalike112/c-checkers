using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {          
            Console.WriteLine("vvedite x i y");
            double x1= double.Parse(Console.ReadLine());
            double y1 = double.Parse( Console.ReadLine());
            double z = Function.z1(x1, y1); 

            Console.WriteLine("z= "+z); // 0 i 1 = 0 -1*(1-1);
            z = Function.z2(x1, y1);
            Console.WriteLine("z= " + z);//1 i 1 = 1.2247=sqrt 1.5
            Console.WriteLine("vvedite katet 1 i katet 2");
             x1 = double.Parse(Console.ReadLine());
             y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Gipotenyza =" + Triangle.Gip(x1,y1));
            Console.WriteLine("S =" + Triangle.Square(x1, y1));
            Console.ReadLine();
        }
    }
}
