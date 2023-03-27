using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] listarr = new int[] { };
            LinkedList<int> List = new LinkedList<int>(listarr);

            Console.WriteLine("Push : 1");
            List.AddLast(1);
            Console.WriteLine("Push : 2");
            List.AddLast(2);
            Console.WriteLine("Push : 3");
            List.AddLast(3);

            Console.WriteLine();
            Console.Write("List : ");
        
            foreach (int i in List)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("POP : 3");
            List.RemoveLast();
            Console.WriteLine("POP : 2");
            List.RemoveLast();

            Console.WriteLine();
            Console.Write("List : ");
        
            foreach (int i in List)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();

        }

        }
    }
