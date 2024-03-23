public class Program
{
    public class random
    {
        public int idrandom()
        {
            Random id = new Random();
            return id.Next(10000, 99999);
        }
    }
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playcount;

        public SayaTubeVideo(string title)
        {
            random addId = new random();
            this.title = title;
            id = addId.idrandom();
            playcount = 0;
        }

        public void increasePlaycount(int playcount)
        {
            this.playcount = playcount;
            playcount++;
        }
        public void printVideoDetail()
        {
            Console.WriteLine($"id : {id}");
            Console.WriteLine($"Judul : {this.title}");
            Console.WriteLine($"Play Count : {this.playcount}");

        }
    }
    private static void Main(string[] args)
    {
        SayaTubeVideo vid = new SayaTubeVideo("Tutorial Design By Contract - Ragadhitya Janatantra Koeshutama");
        vid.increasePlaycount(1);
        vid.printVideoDetail();
    }
}