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

                Console.WriteLine("Auswahl:");
                auswahl=Console.ReadLine();
                switch (auswahl)
                {
                    case "1":
                        //Eingabe
                        Console.WriteLine("Dezimalzahl eingeben:");
                        int dezimalzahl = Convert.ToInt32(Console.ReadLine());
                        //Verarbeitung

                        //Ausgabe

                    break;
                }


                Console.WriteLine("Neue Auswahl? (j/n)");
                nochmal= Console.ReadLine();
            } while (nochmal == "j" || nochmal == "J");
            Console.WriteLine("Zahlensysteme:");
        }
    }
}