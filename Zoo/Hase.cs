using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




class Hase : Tier, IStreichelbar
{
    public Hase(string name) : base(name)
    {
        Console.WriteLine("Gib eine Name");
        Name = Console.ReadLine();
        Console.WriteLine("Neuer Hase heißt jetz" + Name);
    }

    public void Streicheln()
    {
        Console.WriteLine("Pff Pff Pff")
    }
}
