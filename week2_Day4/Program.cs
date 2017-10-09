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
            //Cat mittins = new Cat();//pulling info from Cat
            //mittins.Name = "mittins";


            //Cat secondCat = new Cat("oz", 3, "orange and gray");
            //Console.WriteLine(mittins.Name);
            //Console.WriteLine(secondCat.Name);

            Dog firstDoge = new Dog();

            firstDoge.Weight = 60.00;
            firstDoge.Height = 3.2f;
            firstDoge.FurLength = "flowing mane";
            firstDoge.RunningSpeed = "will fetch ... eventually";


            firstDoge.groom();
           // Console.WriteLine(firstDoge.FurLength);

            firstDoge.Run();
            Console.WriteLine("The dog now weighs " + firstDoge.Weight);
            Console.WriteLine(firstDoge.RunningSpeed);

            firstDoge.Bark();
            


        }
    }
}
