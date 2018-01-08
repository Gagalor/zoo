using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Gib einen Buchstaben ein!");
        string buchstabe = Console.ReadLine();
        if (buchstabe == "a")
        {
            Console.WriteLine("Start");
        }
        else if(buchstabe[0] == 'b' && buchstabe.Length == 2)
        {
            Console.WriteLine("Das ist ja toll das du das Program startest!");
        }
        else
        {
            Console.WriteLine("juhu");
        }


        Zoo neuerZoo = new Zoo("Tophs Zoo");

        for (int i = 0; i < 10; i++)
        {
            neuerZoo.NeuesSchwein("Schnauzer" + i);
        }

        neuerZoo.NeuerHai("Haiii");
        neuerZoo.NeuerWal("Walii");
        neuerZoo.NeuerHase("");

        //int j = 0;
        //while (j < 10)
        //{
        //    neuerZoo.NeuesSchwein("Gerlinde " + j);
        //    j++;
        //}

        neuerZoo.FütterAlleTiere();

        while (true)
        {
            Console.WriteLine("Welches Tier möchtest du streicheln?");
            string nameVonDemSchweinDasGestreicheltWerdenSoll = Console.ReadLine();

            if (nameVonDemSchweinDasGestreicheltWerdenSoll == "stop")
            {
                break;
            }
            else
            {
                neuerZoo.StreichelFolgendesTier(nameVonDemSchweinDasGestreicheltWerdenSoll);
            }
        }

        //Console.Read();
    }
}
