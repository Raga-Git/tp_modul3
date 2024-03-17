public class Program
{
    public class HaloGeneric
    {
        public static void SapaUser<x>(x input)
        {
            Console.WriteLine($"Halo user {input}");
        }
    }

    public class DataGeneric<Generic>
    {
        private Generic data;
        public DataGeneric(Generic input) 
        {
            this.data = input;
        }    
        public void PrintData() 
        {
            Console.WriteLine($"Data yang tersimpan adalah: {data}");

        }
    }

    private static void Main(string[] args)
    {

        HaloGeneric.SapaUser("Raga");
        DataGeneric<String> obj = new DataGeneric<String>("1302223025");
        obj.PrintData();
    }
}