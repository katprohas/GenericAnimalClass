using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Generic
{
    class Program
    {
        class Animal <T>
        {
            //1 generic property and a constructor.
            public T info;

            public Animal (T info)
            {
                this.info = info;
                Console.WriteLine("Information passed: " + this.info);
            }
            public T getAnimal()
            {
                return info;
            }

        } //end animal class

        static void Main(string[] args)
        {
            Animal<string> animalName = new Animal<string>("Sumatran Tiger");
            Animal<string> animalHabitat = new Animal<string>("Rainforest");
            Animal<bool> endangered = new Animal<bool>(true);
            Animal<bool> extinct = new Animal<bool>(false);
            Animal<int> averageLifespan = new Animal<int>(15);

            //print out the values using the getAnimal method
            Console.WriteLine();
            Console.WriteLine("Animal Information...");
            Console.WriteLine("Animal Name: " + animalName.getAnimal());
            Console.WriteLine("Animal Habitat: " + animalHabitat.getAnimal());
            Console.WriteLine("Animal Endangered: " + endangered.getAnimal());
            Console.WriteLine("Animal Extinct: " + extinct.getAnimal());
            Console.WriteLine("Average Lifespan: " + averageLifespan.getAnimal());

        }
    }//end program class
}//end namespace
