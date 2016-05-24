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
            Person person = new Person();

            Console.WriteLine(person.Name);

            //Set a value in the Name property of the Person class
            person.Name = "Tetiana";

            //get the Name value and print to console
            Console.WriteLine(person.Name);
        }
    }
}
