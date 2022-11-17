using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoopark
{
    public class Bird:IAnimal
    {
    public string Name { get; set; }
    public void Move()
        {
            Console.WriteLine($"{Name} flyes");
        }
    public void MakeSound() => Console.WriteLine("{0} chirikaet",Name);
        public void Diet() => Console.WriteLine("{0} eats worms",Name);
        public Bird(string name)
        {
            Console.WriteLine("Name:{0}",Name);
            
        }

}
}
