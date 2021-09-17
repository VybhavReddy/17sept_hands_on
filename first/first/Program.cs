using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    public delegate void dele(int a);
    public delegate void delestr(string s);
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            Console.WriteLine("For even integer operation press 0, string operation press 1");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 0)
            {
                dele obj = new dele(check.checkint);
                ArrayList arr = new ArrayList();
                Console.WriteLine("Enter no of elements");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the elements");
                for (int i = 0; i < n; i++)
                {
                    arr.Add((Console.ReadLine()));
                }
                Console.WriteLine("*************************************");

                for (int i = 0; i < arr.Count; i++)
                {

                    obj(Convert.ToInt32(arr[i]));

                }
            }
            if (choice == 1)
            {
                delestr stri = new delestr(check.checkstr);
                Console.WriteLine("Enter no of Words");
                int n = Convert.ToInt32(Console.ReadLine());
                ArrayList arrstr = new ArrayList();
                for (int i = 0; i < n; i++)
                {
                    arrstr.Add((Console.ReadLine()));
                }
                Console.WriteLine("*************************************");
                for (int i = 0; i < arrstr.Count; i++)
                {
                    stri(arrstr[i].ToString());
                }


            }
            Console.Read();
        }
    }
    public class check
    {
        public static void checkint(int a)
        {
            if (a % 2 == 0)
                Console.WriteLine(a);
        }
        public static void checkstr(string a)
        {
            if (a.Length == 5)
            {
                Console.WriteLine(a);
            }
        }
    }
}
