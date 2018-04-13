using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();    //creates instance of the class
            myCar.Make = "Nissan";
            myCar.Model = "Sentra";
            myCar.Year = 1983;
            myCar.Color = "Yellow";

            Car otherCar = myCar;


            Console.WriteLine("Year of car {0} ", myCar.Year);
            Console.WriteLine("Year of car {0} ", otherCar.Year);

            otherCar.Year = 1;

            Console.WriteLine("Year of car {0} ", myCar.Year);
            Console.WriteLine("Year of car {0} ", otherCar.Year);
            Console.ReadLine();

          /*  int x = 1234;
            string firstName = "Jonathan";
            string lastName = "Manigo";
            char[] Name = firstName.ToCharArray();

            string mystring = String.Format("{0:N}", x);
            Console.WriteLine("The amount of money is {0:N}",x );

           
            Console.Read();

            /*Console.WriteLine("Here is 5 {0}", car[4]);

            foreach (int element in car )
            {
                Console.WriteLine("Count: {0}", element);
            }
            
            Console.Read();*/
          /*  Console.Write("What is your first name");
            string myFirstName = Console.ReadLine();
            char[]  sign = myFirstName.ToCharArray();

            Console.WriteLine(sign[2] + " " + sign[3]);
            Console.Read();*/
        }

    }

    class Car  //new class with functions and data members
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public int value()
        {
            int val = 0;
            if (Year < 2000)
                val = 2000;

            return val;

        }

    }



}
