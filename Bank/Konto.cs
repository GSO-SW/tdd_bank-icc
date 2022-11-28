using System;

namespace Bank
{
    public class Konto
    {
        private int guthaben;
        private int kontonr;

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
                return kontonr; 
            }
        }
        public Konto(int guthaben)
        {
            this.guthaben = guthaben;
    }
    public void Einzahlen(int betrag)
        {
            guthaben += betrag;
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
