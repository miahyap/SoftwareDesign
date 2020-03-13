// Composite Desing Patttern
// Example Idea Courtesy: Navin Reddy - Telusko  
//
using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            IComputerComponent mouse = new ComputerLeaf(10,"mouse");
            IComputerComponent hd = new ComputerLeaf(100, "ssd");
            IComputerComponent kb = new ComputerLeaf(20, "logitech kb");
            
            IComputerComponent laptop = new ComputerComposite("laptop");
            laptop.Add(mouse);
            laptop.Add(hd);
            laptop.Add(kb);

            Console.WriteLine(" The laptop price is " + laptop.GetPrice());
            Console.ReadLine();

        }
    }
}
