using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class Terminator
    {
        public string Id { get; private set; }
        public Terminator(string Id)
        {
            this.Id = Id;
        }
        public abstract void Info();
    }
    class T800 : Terminator
    {
        public T800(string Id) : base(Id)
        {
            Console.WriteLine($"The T800 is created, the Id {Id}");
        }
        public override void Info()
        {
            Console.WriteLine("Arnold Schwarzenegger came to kill russian soldiers");
        }
    }
    class T1000 : Terminator
    {
        public T1000(string Id) : base(Id)
        {
            Console.WriteLine($"The T1000 is created, Id {Id}");
        }
        public override void Info()
        {
            Console.WriteLine("liquid steel is looking for bunker stalin");
        }
    }
    abstract class Factory
    {
        protected Random rand = new Random();
        abstract public Terminator Create();
    }
    class T800Factory : Factory
    {
        public override Terminator Create()
        {
            return new T800(rand.Next().ToString());
        }
    }
    class T1000Factory : Factory
    {
        public override Terminator Create()
        {
            return new T1000(rand.Next().ToString());
        }
    }
}

