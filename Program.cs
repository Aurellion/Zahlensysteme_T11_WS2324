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
                Console.WriteLine("3: Dezimalzahl zu Hexadezimalzahl");
                Console.WriteLine("4: Hexadezimalzahl zu Dezimalzahl");


                string binärzahl = "";
                string hexadezimalzahl = "";
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
                    case "3":
                        //Eingabe
                        Console.WriteLine("Dezimalzahl eingeben:");
                        dezimalzahl = Convert.ToInt32(Console.ReadLine());
                        //Verarbeitung
                        hexadezimalzahl = DezimalZuHexadezimal(dezimalzahl);
                        //Ausgabe
                        Console.WriteLine($"[{dezimalzahl}]_10 = [{hexadezimalzahl}]_16");
                        break;
                    case "4":
                        //Eingabe
                        Console.WriteLine("Hexadezimalzahl eingeben:");
                        binärzahl = Console.ReadLine();
                        //Verarbeitung
                        dezimalzahl = HexadezimalZuDezimal(hexadezimalzahl);
                        //Ausgabe
                        Console.WriteLine($"[{hexadezimalzahl}]_16 = [{dezimalzahl}]_10");
                        break;
                }
                Console.WriteLine("Neue Auswahl? (j/n)");
                nochmal= Console.ReadLine();
            } while (nochmal == "j" || nochmal == "J");
            Console.WriteLine("Zahlensysteme:");
        }

        private static int HexadezimalZuDezimal(string hexadezimalzahl)
        {
            int dezimalzahl = 0;
            //...
            return dezimalzahl;
        }

        private static string DezimalZuHexadezimal(int dezimalzahl)
        {
            string hexadezimalzahl = "";
            //...
            return hexadezimalzahl;
        }

        static int BinärZuDezimal(string binärzahl)
        {
            int dezimalzahl = 0;
            for (int i = binärzahl.Length-1; i>=0; i--) //1000
            {
                int bin = Convert.ToInt32(binärzahl[binärzahl.Length-1-i].ToString());                
                dezimalzahl += bin * (int)Math.Pow(2,i);
                //Console.WriteLine(i + " " + bin + " " + dezimalzahl);
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

        static int BuchstabeZuZahl(string Buchstabe)
        {
            int zahl=0;
            //...
            return zahl;
        }

        static string ZahlZuBuchstabe(int zahl)
        {
            string Buchstabe="";
            //...
            return Buchstabe;
        }
    }
}