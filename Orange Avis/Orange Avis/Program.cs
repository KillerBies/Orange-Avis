namespace Orange_Avis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produktNavn = "Loftlampe";
            string produktKategori = "Belysning";
            double produktNyPris = 2500;
            double produktPris = 1000;
            string produktStand = "God";
            Console.WriteLine(FindBesparelse(produktPris, produktNyPris));
        }
        static int FindBesparelse(double pris, double nyPris)
        {
            double doubleBesparelse = 100 - ((pris / nyPris) * 100);
            int besparelse = Convert.ToInt32((double)doubleBesparelse);
            return besparelse;
        }
    }
}
