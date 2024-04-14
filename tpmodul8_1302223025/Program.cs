using tpmodul8_1302223025;

public class Program
{
    private static void Main(string[] args)
    {
        UIConfig UIconfig = new UIConfig();
        CovidConfig Covidconfig = new CovidConfig();
        UIconfig.ReadConfigFile();
        Console.WriteLine($"Berapa suhu badan anda saat ini? (Dalam nilai {UIconfig.config.satuan_suhu})");
        double inputSuhu = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Berapa hari yang lalu (perkiraan anda terakhir memiliki gejala demam?");
        double hariSakit = Convert.ToInt32(Console.ReadLine());
        if (UIconfig.config.satuan_suhu == "Celcius")
        {
            if ((inputSuhu >= 36.5 && inputSuhu <= 37.5) && hariSakit < UIconfig.config.batas_hari_demam)
            {
                Console.WriteLine(UIconfig.config.pesan_diterima);
            }
            else
            {
                Console.WriteLine(UIconfig.config.pesan_ditolak);
            }
        } else if (UIconfig.config.satuan_suhu == "Fahrenheit")
        {
            if ((inputSuhu >= 97.7 && inputSuhu <= 99.5) && hariSakit < UIconfig.config.batas_hari_demam)
            {
                Console.WriteLine(UIconfig.config.pesan_diterima);
            }
            else
            {
                Console.WriteLine(UIconfig.config.pesan_ditolak);

            }
        }
        Covidconfig.UbahSatuan();
        UIconfig.ReadConfigFile();
        Console.WriteLine($"Berapa suhu badan anda saat ini? (Dalam nilai {UIconfig.config.satuan_suhu})");
        inputSuhu = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Berapa hari yang lalu (perkiraan anda terakhir memiliki gejala demam?");
        hariSakit = Convert.ToDouble(Console.ReadLine());
        if (UIconfig.config.satuan_suhu == "Celcius")
        {
            if ((inputSuhu >= 36.5 && inputSuhu <= 37.5) && hariSakit < UIconfig.config.batas_hari_demam)
            {
                Console.WriteLine(UIconfig.config.pesan_diterima);
            }
            else
            {
                Console.WriteLine(UIconfig.config.pesan_ditolak);
            }
        }
        else if (UIconfig.config.satuan_suhu == "Fahrenheit")
        {
            if ((inputSuhu >= 97.7 && inputSuhu <= 99.5) && hariSakit < UIconfig.config.batas_hari_demam)
            {
                Console.WriteLine(UIconfig.config.pesan_diterima);
            }
            else
            {
                Console.WriteLine(UIconfig.config.pesan_ditolak);

            }
        }

    }
}