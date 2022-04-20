using System;
using projeto_poo.src.Entities;

namespace projeto_poo
{
 class Program
{ 
static void Main(string[] args)
    {
            
        Knight arus = new Knight("Arus", 42, "Knight");
        Wizard jennica = new Wizard("Jennica", 42, "White Wizard");
        Mage topapa = new Mage("Topapa", 42, "Black Wizard");
        Ninja wedge = new Ninja("Wedge", 42, "Ninja");
        
           
        
        Console.WriteLine(arus.Attack());
        Console.WriteLine(jennica.Attack());
        Console.WriteLine(topapa.Attack());
        Console.WriteLine(wedge.Attack());
        }
    }
}