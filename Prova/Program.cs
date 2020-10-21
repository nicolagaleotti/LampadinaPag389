using System;
using LaSfidaPag389;

namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            Lampadina l1 = new Lampadina("accesa");
            for (int i = 0; i <=10; i++)
            {
                l1.Click();
                Console.WriteLine($"Lampadina {l1.Descrizione()}.");
            }
        }
    }
}
