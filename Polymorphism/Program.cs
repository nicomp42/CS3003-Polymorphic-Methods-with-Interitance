/*************************************************************
 * Illustrate Polymorphic Methods.                           *
 * Bill Nicholson  nicholdw@ucmail.uc.edu                    *
 *************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Motor myMotor = new Motor("M1");
            Conveyor myConveyor = new Conveyor("C1");
            ArrayList myFactory = new ArrayList();

            // Put some devices in the ArrayList. NOT homogeneous!
            myFactory.Add(new Conveyor("C2"));
            myFactory.Add(new Motor("M2"));
            myFactory.Add(new Motor("M3"));
            myFactory.Add(new Conveyor("C4"));
            myFactory.Add(new Pump("P1"));

            // No polymorphism here:
            myConveyor.Start();
            myMotor.Start();

            Console.WriteLine("Iterating through the ArrayList...");
            // Ta da! Polymorphism. 
            foreach (Device myDevice in myFactory)
            {
                Console.WriteLine("Starting a Device Object...");
                myDevice.Start();   // Dynamic Binding
            }

        }
    }
}
