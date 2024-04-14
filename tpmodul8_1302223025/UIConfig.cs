using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul8_1302223025
{
    
    public class UIConfig
    {
        public CovidConfig config;
        public const string filepath = "D:\\Tel U\\Semester 4\\KPL\\tpmodul8_1302223025\\tpmodul8_1302223025\\covid_config.json";
        

        public UIConfig() 
        { 
            try
            {
                config = ReadConfigFile();
            }
            catch(Exception) 
            {
                SetDefault();
                WriteNewConfigFile();
            }
        }

        private void SetDefault()
        {
            config.satuan_suhu = "Celcius";
            config.batas_hari_demam = 14;
            config.pesan_ditolak = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
            config.pesan_diterima = "Anda dipersilahkan masuk ke dalam gedung ini";
        }
        public CovidConfig ReadConfigFile()
        {
            string jsonData = File.ReadAllText(filepath);
            config = JsonSerializer.Deserialize<CovidConfig>(jsonData);
            return config;
        }

        public void WriteNewConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            String jsonString = JsonSerializer.Serialize(config, options);
            File.WriteAllText(filepath, jsonString);
        }

    }
}
