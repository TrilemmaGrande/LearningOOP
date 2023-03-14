namespace Aufgabe.Warenhaus {
    internal class Program {
        static void Main(string[] args) {
            Random random = new Random();
            Warenhaus[] warenhaeuser = new Warenhaus[20];
            int rWarenbestand;
            int rKassenbestand;
            int auswahlWarenhaus;
            int auswahlAktion;
            int auswahlAnzahl;

            for (int i = 0; i < warenhaeuser.Length; i++) {
                rWarenbestand = random.Next(0, 501);
                rKassenbestand = random.Next(0, 1001);
                warenhaeuser[i] = new Warenhaus($"Haus {i+1}", rWarenbestand, rKassenbestand);
            }
            for (int i = 0; i < 100; i++) {
                auswahlWarenhaus = random.Next(0, 20);
                auswahlAktion = random.Next(1, 3);
                auswahlAnzahl = random.Next(1, 32);

                if (auswahlAktion == 1) {
                    warenhaeuser[auswahlWarenhaus].Buy(auswahlAnzahl);
                }
                else if (auswahlAktion == 2) {
                    warenhaeuser[auswahlWarenhaus].Sell(auswahlAnzahl);
                }
            }
            foreach  (Warenhaus haus in warenhaeuser) {
                haus.PrintInfo();
            }
            Warenhaus.PrintInfoAll();
        }
    }
}