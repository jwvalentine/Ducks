using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    public abstract class Duck { 
        
            public bool floats { get; set; }
            public bool flies { get; set; }
            public bool quacks { get; set; }
            public int legs { get; set; }
            public int eyes { get; set; }
        
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
        public string madeOf { get; set; }
        public string name;
        public string color { get; set; }
    }


}
