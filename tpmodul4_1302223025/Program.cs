using System;
using static Program.KodePos;
public class Program
{
    public class KodePos
    {
        public enum Kelurahan
        {
            Batununggal,
            Kujangsari,
            Mengger,
            Wates,
            Cijaura,
            Jatisari,
            Margasari,
            Sekajati,
            Kebonwaru,
            Maleer,
            Samoja
        }

        public static string getKodePos(Kelurahan nama)
        {
            string[] kodePos = {
        "40266", "40287", "40267", "40256", "40287", "40286", "40286", "40286", "40272", "40274", "40273" };
            return kodePos[(int)nama];
        }
    }
        public static void Main(String[] args)
        {

        Console.WriteLine("Kelurahan " + Kelurahan.Batununggal + " Memiliki Kode Pos " + getKodePos(Kelurahan.Batununggal));


        }
}