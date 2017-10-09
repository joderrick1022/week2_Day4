using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat mittins = new Cat();//pulling info from Cat
            mittins.Name = "mittins";


            //Cat secondCat = new Cat("oz", 3, "orange and gray");
            //Console.WriteLine(mittins.Name);
            //Console.WriteLine(secondCat.Name);

            mittins.Eat();
            


        }
    }
}
