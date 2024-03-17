public class Program
{
    public class HaloGeneric
    {
        public static void SapaUser<x>(x input)
        {
            Console.WriteLine($"Halo user {input}");
        }
    }

    private static void Main(string[] args)
    {
        HaloGeneric.SapaUser("Raga");
    }
}