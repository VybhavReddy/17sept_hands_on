using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace third
{
    public interface IShape
    {
        double area();
        double volume();

    }
    class Cube:IShape
    {
        int x = 10;
        public double area()
        {
            return 6 * x * x;
        }
        public double volume()
        {
            return x * x * x;
        }

    }
    class Circle:IShape
    {
        int radius = 10;
        public double area()
        {
            return 3.142 * radius * radius;
        }
        public double volume()
        {
            return 0;
        }
    }
    class PolymorphismTest
    {
        static void Main(string[] args)
        {


            IShape[] obj = { new Cube(), new Circle() };

            for(int i=0;i<obj.Length;i++)
            {
                if(i==0)
                {
                    Console.WriteLine("Area of cube: {0}", obj[i].area());
                    Console.WriteLine("Volume of cube: {0}", obj[i].volume());
                    Console.WriteLine("*****************************************");
                }
                if(i==1)
                {
                    Console.WriteLine("Area of circle: {0}", obj[1].area());
                    Console.WriteLine("Volume of circle: {0}", obj[1].volume());
                }

            }

            
            Console.Read();
        }
    }
}
