using System;

namespace LaSfidaPag389
{
    public class Lampadina
    {
        private string stato;
        private const int numeroClickMassimi = 10;
        private int contatore = 0;
        public Lampadina(string stato)
        {
            this.stato = stato;
        }

        public string Descrizione()
        {
            return stato;
        }

        public void Click()
        {
            if (stato != "rotta")
            {
                contatore++;
                if (contatore <= numeroClickMassimi)
                {
                    if (stato == "accesa")
                        stato = "spenta";
                    else if (stato == "spenta")
                        stato = "accesa";
                }
                else stato = "rotta";
            }
        }
    }
}
