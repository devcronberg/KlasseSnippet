using System;

namespace KlasseSnippet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class MinKlasse
    {

        // ---------- Felter ----------

        private int mitFelt;
        // Du bør IKKE benytte offentlige felter
        // nej til: public int MitFelt; 

        // Dette felt tilgås gennem egenskab
        private int mitFeltTilKompletEgenskab;

        // ---------- Egenskaber ----------

        // Dette er en fuld egenskab med et tilhørende felt
        // Brug propfull-snippet
        public int MinKompletteEgenskab
        {
            get
            {
                // Sikkerhedskode
                // Logkode
                // Logik
                return mitFeltTilKompletEgenskab;
            }
            set // bemærk at value er implicit
            {
                // Sikkerhedskode
                // Logkode
                // Logik
                // Validering
                mitFeltTilKompletEgenskab = value;
            }
        }

        // Dette er en automatisk egenskab med et 
        // autogenereret felt
        // Brug prop-snippet
        public int MinAutomatiskeEgenskab { get; set; }


        // ---------- Metoder ----------

        // Eksempel på en void metode med et argument
        public void MinTestMetode1(int a)
        {

        }

        // Eksempel på en metoder der returnerer en int 
        // og har en int som argument
        public int MinTestMetode2(int a)
        {
            return a;
        }

        // ---------- Konstruktør ----------

        // Standard konstruktør
        public MinKlasse()
        {
        }

        // Brugerdefineret konstruktør - med argument
        public MinKlasse(int a)
        {
        }


        // ---------- Hændelser ----------

        // Eksempler forskellige hændelser samt brug af dem

        // Under argumenter
        public event Action MinHændelse1;

        // Med en int som argument
        public event Action<int> MinHændelse2;

        // Standard Microsoft hændelse
        public event Action<object, EventArgs> MinHændelse3;

        // Eksempel på brug af hændelser
        public void TestHændelser()
        {
            if (MinHændelse1 != null)
                MinHændelse1();

            if (MinHændelse2 != null)
                MinHændelse2(1);

            if (MinHændelse3 != null)
                MinHændelse3(this, new EventArgs());
        }
    }
}
