using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoopark
{
    public class Mlec : IAnimal
    {
        public string Name { get; set; }
        public string Voice { get; set; }
        public string Eat { get; set; }
        public void Move()
        {
            Console.WriteLine("{0} walks", Name);
        }
        public void MakeSound() => Console.WriteLine("{0}{1} ", Name,Voice);
        public void Diet() => Console.WriteLine("{0} {1} ", Name, Eat);
        public Mlec(string name,string voice,string diet)
        {
            
            Console.WriteLine($"Name:{Name}");
            Move();
            MakeSound();
            Diet();
        }
    }
}
