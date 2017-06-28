using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    abstract class Duck
    {
        public bool floats { get; set; }
        public bool flies { get; set; }
        public bool quacks { get; set; }
        public int legs { get; set; }
        public int eyes {get;set;} 
    }

    // Mallard inherits properties from Duck
    class Mallard : Duck
    {
        // Custom attributes for a Mallard duck
        public string madeOf { get; set; }
    }

    // Wooden inherits properties from Duck
    class Wooden : Duck
    {
        // Custom attributes for a Wooden duck
        public string madeOf { get; set; }
    }

    // Rubber inherits properties from Duck
    class Rubber : Duck
    {
        // Custom attributes for a Rubber duck
        string madeOf { get; set; }
        public string name;
        public string color { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate a new Mallard Duck
            Mallard liveDuck = new Mallard();
            {
                liveDuck.floats = true;
                liveDuck.flies = true;
                liveDuck.quacks = false;
                liveDuck.legs = 2;
                liveDuck.madeOf = "meat";
                liveDuck.eyes = 2;
            }
            Mallard deadDuck = new Mallard();
            {
                deadDuck.eyes = 1;
            }


            
            // Instantiate a new Wooden Duck   
            Wooden woodDuck = new Wooden();
            woodDuck.floats = true;
            woodDuck.flies = false;
            woodDuck.quacks = false;
            woodDuck.legs = 0;
            woodDuck.madeOf = "wood";

            // Instantiate a new Rubber Duck
            Rubber rubberDucky = new Rubber();
            {
                rubberDucky.floats = true;
                rubberDucky.flies = false;
                rubberDucky.quacks = false;
                rubberDucky.legs = 0;
                rubberDucky.name = "George";
                rubberDucky.madeOf = "rubber"; // madeOf is broken because the access modifier is wrong. The access modifier on madeOf is missing. It should be there, and should be public (not private).

            }

            Rubber redRubberDucky = new Rubber();
            {
                redRubberDucky.color = "red";
            }

            // You cant instantiate the class Duck because it is an abstract class.
            Duck newDuck = new Duck();

            
            // What about the eyes? How would you implement giving the ducks eyes?
        }
    }
}
