using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfOsztalyzas
{
    public class Osztalyzat
    {
        String nev;
        String datum;
        String tantargy;
        int jegy;
        String CsaladiNev;

        public Osztalyzat(string nev, string datum, string tantargy, int jegy, string CsaladiNev)
        {
            this.nev = nev;
            this.datum = datum;
            this.tantargy = tantargy;
            this.jegy = jegy;
            this.CsaladiNev = CsaladiNev;
        }

        public string Nev { get => nev;  }
        public string Datum { get => datum;  }
        public string Tantargy { get => tantargy; }
        public int Jegy { get => jegy; }
        public string CsaladiNev { get => CsaladiNev; }
    }
        //todo Bővítse az osztályt! Készítsen CsaladiNev néven property-t, ami a névből a családi nevet adja vissza. Feltételezve, hogy a névnek csak az első tagja az.
        static void CsaladiNev(string karakterlanc)
    {
        char aktualisBetu = txtNev[0];
    
        while (aktualisBetu != " "){
            karakterlanc = karakterlanc + aktualisBetu;
            aktualisBetu++;
        }

        return karakterlanc;
    }


        //todo Készítsen metódust ForditottNev néven, ami a két tagból álló nevek esetén megfordítja a névtagokat. Pld. Kiss Ádám => Ádám Kiss
        static void ForditottNev(string vezeteknev, string keresztnev)
    {
        char aktualisBetu = txtNev[0];

        while (aktualisBetu != " ")
	{
        vezeteknev = vezeteknev + aktualisBetu;
        aktualisBetu++

        if (aktualisBetu == " ")
            {
                continue;
                keresztnev = keresztnev + aktualisBetu;
                aktualisBetu++;
            }

        Console.WriteLine(keresztnev + vezeteknev);
	}
    }
}
