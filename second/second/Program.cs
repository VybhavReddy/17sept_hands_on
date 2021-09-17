using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second
{
    class TestDemo
    {
        static void Main(string[] args)
        {
            rectangle obj = new rectangle();
            obj.setColour("Blue",20,30);
            obj.getColour();
            double area=obj.Area();
            obj.displayArea();
            Console.Read();
        }
    }
    public abstract class shape
    {
        public string colour;
        public void setColur(string str)
        {
           colour = str;
        }
        public string getColour()
        {
            return colour;
        }
        public abstract double Area();
    }
    public class rectangle:shape
    {
        int length, width;
        public void setColour(string s,int l,int w)
        {
            colour = s;
            length = l;
            width = w;
        }
        public override double Area()
        {
            return length * width;
        }
        public void displayArea()
        {
            Console.WriteLine("Area : {0}", length * width);
        }
    }

}
