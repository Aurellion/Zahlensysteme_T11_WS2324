namespace Zahlensysteme_T11_WS2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nochmal = "";
            string auswahl = "";
            do
            {
                Console.WriteLine("1: Dezimalzahl zu Binärzahl");
                Console.WriteLine("2: Binärzahl zu Dezimalzahl");

                string binärzahl = "";
                int dezimalzahl;

                Console.Write("Auswahl:");
                auswahl=Console.ReadLine();

                switch (auswahl)
                {
                    case "1":
                        //Eingabe
                        Console.WriteLine("Dezimalzahl eingeben:");
                        dezimalzahl = Convert.ToInt32(Console.ReadLine());
                        //Verarbeitung
                        binärzahl = DezimalZuBinär(dezimalzahl);
                        //Ausgabe
                        Console.WriteLine($"[{dezimalzahl}]_10 = [{binärzahl}]_2");
                    break;
                        case "2":
                        //Eingabe
                        Console.WriteLine("Binärzahl eingeben:");
                        binärzahl = Console.ReadLine();
                        //Verarbeitung
                        dezimalzahl = BinärZuDezimal(binärzahl);
                        //Ausgabe
                        Console.WriteLine($"[{binärzahl}]_2 = [{dezimalzahl}]_10");
                        break;
                }
                Console.WriteLine("Neue Auswahl? (j/n)");
                nochmal= Console.ReadLine();
            } while (nochmal == "j" || nochmal == "J");
            Console.WriteLine("Zahlensysteme:");
        }

        static int BinärZuDezimal(string binärzahl)
        {
            int dezimalzahl = 0;
            for (int i = binärzahl.Length-1; i>=0; i--) //1000
            {
                int bin = Convert.ToInt32(binärzahl[?].ToString());                
                dezimalzahl += bin * (int)Math.Pow(2,i);
                Console.WriteLine(i + " " + bin + " " + dezimalzahl);
            }
            return dezimalzahl;
        }

        static string DezimalZuBinär(int dezimalzahl)
        {
            string binärzahl="";
            int rest;
            int dividend = dezimalzahl;
            while (dividend != 0)
            {
                rest = dividend % 2;//Rest der Division
                dividend /= 2;//Neuer Dividend
                binärzahl = rest + binärzahl;//String von links aufbauen 
            }
            return binärzahl;
        }
    }
}