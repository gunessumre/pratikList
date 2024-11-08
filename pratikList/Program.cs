using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        List<string> ziyaretciler = new List<string>
        {
            "martin eden",
            "raskolnikov",
            "BAL",
            "Duru",
            "Sakatto",
            "Albay Aureliaona"
        };

        
        Console.WriteLine("Ziyaretçi Listesi:");
        foreach (string ziyaretci in ziyaretciler)
        {
            Console.WriteLine(ziyaretci);
        }
    }
}