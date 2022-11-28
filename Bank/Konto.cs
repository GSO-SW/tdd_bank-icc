using System;

namespace Bank
{
    public class Konto
    {
        private int guthaben;
        private int kontonr;
        static int kontoanzahl;

        

        public int Guthaben
        {
            get
            {
                return guthaben;
            }
        }
        public int KontoNr
        {
            get
            {
                return kontoanzahl;
            }
        }
        
        public Konto(int guthaben)
        {

            if (guthaben < 0)
            {
                throw new ArgumentOutOfRangeException("Konto kann nicht mit negative Guthaben geoffnet werden");
            }
            else 
            {
                this.guthaben = guthaben;
                kontoanzahl++;
            }
            
        }
  
        public void Einzahlen(int betrag)
        { 
            this.guthaben += betrag;
        }
        

        public void Auszahlen(int betrag)
        {
            if (guthaben >= betrag)
            {
                guthaben -= betrag;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Guthaben nicht ausreichend");
            }
        }
    }
}
