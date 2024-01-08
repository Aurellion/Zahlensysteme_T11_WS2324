using System;

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
                Console.WriteLine("5: Basis x zu Basis y");


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
                        dezimalzahl = IntEingabe();
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
                        dezimalzahl = IntEingabe();
                        //Verarbeitung
                        hexadezimalzahl = DezimalZuHexadezimal(dezimalzahl);
                        //Ausgabe
                        Console.WriteLine($"[{dezimalzahl}]_10 = [{hexadezimalzahl}]_16");
                        break;
                    case "4":
                        //Eingabe
                        Console.WriteLine("Hexadezimalzahl eingeben:");
                        hexadezimalzahl = Console.ReadLine();
                        //Verarbeitung
                        dezimalzahl = HexadezimalZuDezimal(hexadezimalzahl);
                        //Ausgabe
                        Console.WriteLine($"[{hexadezimalzahl}]_16 = [{dezimalzahl}]_10");
                        break;
                    case "5":
                        //Eingabe
                        Console.WriteLine("Zahl eingeben:");
                        string zahlx = Console.ReadLine();
                        Console.WriteLine("Ausgangsbasis eingeben:");
                        int basisx = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Zielbasis eingeben:");
                        int basisy = Convert.ToInt32(Console.ReadLine());
                        //Verarbeitung
                        string zahly = BasisXZuBasisY(zahlx, basisx, basisy);
                        //Ausgabe
                        Console.WriteLine($"[{zahlx}]_{basisx} = [{zahly}]_{basisy}");
                        break;
                }
                Console.WriteLine("Neue Auswahl? (j/n)");
                nochmal= Console.ReadLine();
            } while (nochmal == "j" || nochmal == "J");
            Console.WriteLine("Zahlensysteme:");
        }

        private static int IntEingabe()
        {
            int Ganzzahl;
            string eingabe = "";
            bool erfolgreich;
            do
            {
                eingabe = Console.ReadLine();
                erfolgreich = int.TryParse(eingabe, out Ganzzahl);
                if (!erfolgreich)
                    Console.Write("Ungültige Eingabe, bitte wiederholen. Eingabe="); 
            } while (!erfolgreich);
            
            return Ganzzahl;
        }

        private static string BasisXZuBasisY(string zahlx, int basisx, int basisy)
        {
            //string zahly = "";
            //int dezimal = BasisXZuDezimal(zahlx, basisx);
            //zahly = DezimalZuBasisY(dezimal, basisy);
            //return zahly;

            return DezimalZuBasisY(BasisXZuDezimal(zahlx, basisx), basisy);
        }

        private static string DezimalZuBasisY(int dezimal, int basisy)
        {
            string zahl = "";
            int rest;
            int dividend = dezimal;
            while (dividend != 0)
            {
                rest = dividend % basisy;//Rest der Division
                dividend /= basisy;//Neuer Dividend
                zahl = ZahlZuBuchstabe(rest) + zahl;//String von links aufbauen 
            }
            return zahl;
        }

        private static int BasisXZuDezimal(string zahlx, int basisx)
        {
            int dezimalzahl = 0;
            for (int i = zahlx.Length - 1; i >= 0; i--)
            {
                int zahl = BuchstabeZuZahl(zahlx[zahlx.Length - 1 - i].ToString());
                dezimalzahl += zahl * (int)Math.Pow(basisx, i);
                Console.WriteLine(i + " " + zahl + " " + dezimalzahl);
            }
            return dezimalzahl;
        }

        private static int HexadezimalZuDezimal(string hexadezimalzahl)
        {
            int dezimalzahl = 0;
            for (int i = hexadezimalzahl.Length - 1; i >= 0; i--) 
            {
                int hex = BuchstabeZuZahl(hexadezimalzahl[hexadezimalzahl.Length - 1 - i].ToString());
                dezimalzahl += hex * (int)Math.Pow(16, i);
                Console.WriteLine(i + " " + hex + " " + dezimalzahl);
            }
            return dezimalzahl;
        }

        private static string DezimalZuHexadezimal(int dezimalzahl)
        {
            string hexadezimalzahl = "";
            int rest;
            int dividend = dezimalzahl;
            while (dividend != 0)
            {
                rest = dividend % 16;//Rest der Division
                dividend /= 16;//Neuer Dividend
                hexadezimalzahl = ZahlZuBuchstabe(rest) + hexadezimalzahl;//String von links aufbauen 
            }
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
            switch(Buchstabe.ToUpper())
            {
                case "A": zahl = 10; break;
                case "B": zahl = 11; break;
                case "C": zahl = 12; break;
                case "D": zahl = 13; break;
                case "E": zahl = 14; break;
                case "F": zahl = 15; break;
                default: zahl = Convert.ToInt32(Buchstabe); break;
            }
            return zahl;
        }

        static string ZahlZuBuchstabe(int zahl)
        {
            string Buchstabe="";
            switch(zahl)
            {
                case 10: Buchstabe = "A"; break;
                case 11: Buchstabe = "B"; break;
                case 12: Buchstabe = "C"; break;
                case 13: Buchstabe = "D"; break;
                case 14: Buchstabe = "E"; break;
                case 15: Buchstabe = "F"; break;
                default: Buchstabe = zahl.ToString(); break;
            }
            return Buchstabe;
        }
    }
}