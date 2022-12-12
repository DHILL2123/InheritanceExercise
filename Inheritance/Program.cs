using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Bird bird1 = new Bird();

            bird1.MustReproduce = true;
            bird1.RequireFood = true;
            bird1.RequireSleep = 8;
            bird1.AdvanceNervousSystem = "Birds have a unique nervous system";

            Console.WriteLine($"It is {bird1.RequireFood} all birds require food.");
            Console.WriteLine($"{bird1.MustReproduce}, every animal must reproduce to avoid exstinction.");
            Console.WriteLine($"{bird1.AdvanceNervousSystem}, along with the amazing ability to fly.");
            Console.WriteLine($"Humans best practice is {bird1.RequireSleep} hours of sleep, not sure if it applies to birds.");


            Reptiles reptiles1 = new Reptiles();

            reptiles1.AdvanceNervousSystem = "A snakes nervous system allows it to do amazing things";
            reptiles1.MustReproduce = true;
            reptiles1.RequireFood = true;
            reptiles1.RequireSleep = 16;

            Console.WriteLine($"{reptiles1.AdvanceNervousSystem}, like strike at very quickly!");
            Console.WriteLine($"Like birds it is {reptiles1.MustReproduce}, reptiles must reproduce.");
            Console.WriteLine($"{reptiles1.RequireFood}, reptiles must eat");
            Console.WriteLine($"Many reptiles get between {reptiles1.RequireSleep} to 22 hours of sleep!");

            

            



        }
    }
}
