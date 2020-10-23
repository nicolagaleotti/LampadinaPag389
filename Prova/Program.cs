using System;
using LaSfidaPag389;

namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            Lampadina l1 = new Lampadina("spenta");
            bool fine = false;
            do
            {
                Console.WriteLine("Che operazione vuoi fare? (Click/Descrizione/Termina)");
                string risposta = Console.ReadLine();
                if (risposta =="Click" || risposta=="click")
                {
                    l1.Click();
                    Console.WriteLine("Cliccato");
                }
                if (risposta == "Descrizione" || risposta == "descrizione")
                {
                    Console.WriteLine(l1.Descrizione());
                }
                if (risposta=="Termina" || risposta=="termina")
                {
                    fine = true;
                    Console.WriteLine("Premi il tasto invio per terminare");
                }
            } while (fine == false);
            Console.ReadLine();
        }
    }
}
