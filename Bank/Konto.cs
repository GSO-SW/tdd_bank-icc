using System;
using System.Security.Cryptography.X509Certificates;

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
            if (guthaben < 0)
            {
                throw new ArgumentOutOfRangeException("Konto kann nicht mit negative Guthaben geoffnet werden");
            }
            else if (guthaben >= 0)
            {
                this.guthaben = guthaben;
                kontonr++;
            }
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
