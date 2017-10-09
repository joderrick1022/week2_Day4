using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_Day4
{
    class Cat
    {

        //states
        //fileds
        //fields are almost always private
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;

        //properties
        //properties are usually public
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }


        // behaviors
        //constructors
        public Cat()
        {
            //default constructor because it takes no
            //parameters in parentheses
        }


        public Cat(string name, int age, string furColor)

        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }


        public void Eat()
        {
            if(isHungry)
            {
                isHungry = false;
            }

            Console.WriteLine("Is the cat hungry? " + isHungry);
        }
    
    }
}
