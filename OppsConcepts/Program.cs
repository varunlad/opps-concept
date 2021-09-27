using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig(); // Create a Pig object
            myPig.animalSound();  // Call the abstract method
            myPig.sleep();  // Call the regular method
            Console.ReadLine();
        }
        // Abstract class
        abstract class Animal
        {
            // Abstract method (does not have a body)
            public abstract void animalSound();
            
            // Regular method
            public void sleep()
            {
                Console.WriteLine("Sleep Well");
            }
        }

        // Derived class (inherit from Animal)
        class Pig : Animal
        {
            public override void animalSound()
            {
                // The body of animalSound() is provided here
                Console.WriteLine("The pig makes !!!wee!!! sound");
            }
        }
    }
}
