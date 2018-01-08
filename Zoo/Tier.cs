using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Tier
{
    public string Name;

    public Tier(string name)
    {
        Name = name;
    }

    public void Füttern()
    {
        Console.WriteLine("Ohm Nom Nom");
        Console.WriteLine("Das Tier mit folgendem Namen wurde gefüttert: " + Name);
    }
}
