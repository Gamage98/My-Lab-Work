using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vote
{
    class Program
    {
        private static string name;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name : ");
                name = Console.ReadLine();
            Console.WriteLine("Enter your age :");
            int age=int.Parse(Console.ReadLine());
            if(age>18)
            {
                Console.WriteLine(name+", you are eligible for voting");
            }
            if(age==18)
            {
                Console.WriteLine(name+",Welcome for voting, this is the first time you vote All the best!");
            }
            else
            {
                Console.WriteLine("Sorry "+name+"\nyou are not eligible for voting");
            }
            Console.ReadKey();
        }
    }
