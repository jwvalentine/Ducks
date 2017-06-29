using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate a new Mallard Duck
            Mallard liveDuck = new Mallard();
            {
                liveDuck.floats = true;
                liveDuck.flies = true;
                liveDuck.quacks = true;
                liveDuck.legs = 2;
                liveDuck.eyes = 2;
                liveDuck.madeOf = "meat";
                
            }
       
            // Instantiate a new Wooden Duck   
            Wooden woodDuck = new Wooden();
            {
                woodDuck.floats = true;
                woodDuck.flies = false;
                woodDuck.quacks = false;
                woodDuck.legs = 0;
                woodDuck.eyes = 0;
                woodDuck.madeOf = "wood";
            }
            

            // Instantiate a new Rubber Duck
            Rubber rubberDucky = new Rubber();
            {
                rubberDucky.floats = true;
                rubberDucky.flies = false;
                rubberDucky.quacks = false;
                rubberDucky.legs = 0;
                rubberDucky.eyes = 0;
                rubberDucky.name = "George";
                rubberDucky.madeOf = "rubber";
                rubberDucky.color = "yellow";
            }

            // Instantiate a new Rubber Duck with a custom color
            Rubber redRubberDucky = new Rubber();
            {
                redRubberDucky.color = "red";
            }

            // You cant instantiate the class Duck because it is an abstract class.
             Duck newDuck = new Duck();

            // Add one of each of the ducks to a List
            var ducks = new List<Duck>();

            ducks.Add(liveDuck);
            ducks.Add(woodDuck);
            ducks.Add(rubberDucky);
            ducks.Add(redRubberDucky);

            // Remove one of the ducks from the List
            ducks.Remove(woodDuck);

           // Iterate through the list
            foreach (var d in ducks)
            {
                bool DoesFloat;
                if (d.floats == true)
                {
                    DoesFloat = true;
                    Console.WriteLine("This Duck Floats!");
                    Console.ReadLine();
                }
                Console.WriteLine("This Duck sinks!");
                Console.ReadLine();
            }

            // What about the eyes? How would you implement giving the ducks eyes?
        }
    }
}
