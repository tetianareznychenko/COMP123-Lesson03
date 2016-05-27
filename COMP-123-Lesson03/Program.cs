using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP_123_Lesson03
{
        /**
         * Theis is a "driver" class for our Program 
         * 
         * @class Program 
         */ 
    public class Program
    {
        /**
         * The main method for our driver class Program 
         * 
         * @method Main 
         * @param {string[]} args
         */ 

        public static void Main(string[] args)
        {
            //create a new istance of the Person class

            Person iryna = new Person();
            iryna.Name = "Iryna";
            iryna.Age = 24;
            iryna.SaysHello();
            iryna.ShowAge();

            Console.WriteLine();

            Person tetiana = new Person("Tetiana");
            tetiana.Age = 23;
            tetiana.SaysHello();
            tetiana.ShowAge();

            Console.WriteLine();

            Person chris = new Person(30);
            chris.Name = "Chris";
            chris.SaysHello();
            chris.ShowAge();


            Console.WriteLine();

            Person adam = new Person("Adam", 16);
            adam.SaysHello();
            adam.ShowAge(); 



            //Console.WriteLine(person.Name);

            //Set a value in the Name property of the Person class
            //person.Name = "Tetiana";

            //get the Name value and print to console
            //Console.WriteLine(person.Name);
        }
    }
}
