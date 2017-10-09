using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_Day4
{
    class Dog
    {
        //fields
        private string furLength;
        private float height;
        private string runningSpeed;
        private double weight;

        //proprties
        public string FurLength
        {
            get { return this.furLength; }
            set { this.furLength = value; }
        }
        public float Height
        {
            get { return this.height; }
            set { this.height = value; }
        }
        public String RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }
        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }

        }

        public Dog()
        {
            //Default
        }

        public Dog(string furLength, float height)

        {
            this.furLength = furLength;
            this.height = height;

        }
        public void Run()
        {
            runningSpeed = "getting faster";
            weight--;
        }

        public void Bark()
        {
            Console.WriteLine("\a" + "\a");
        }

        public void Potty()
        {
            weight = weight - 0.1;
        }
        public void groom()
        {
            furLength = "all cleaned up";
        }

        }
    
    }
