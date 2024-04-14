﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul8_1302223025
{
    public class CovidConfig
    {
        public string satuan_suhu { get; set; }
        public int batas_hari_demam { get; set; }
        public string pesan_ditolak { get; set; }
        public string pesan_diterima { get; set; }

        public CovidConfig() { }

        public CovidConfig(string satuan_suhu, int batas_hari_demam, string pesan_ditolak, string pesan_diterima)
        {
            this.satuan_suhu = satuan_suhu;
            this.batas_hari_demam = batas_hari_demam;
            this.pesan_ditolak = pesan_ditolak;
            this.pesan_diterima = pesan_diterima;
        }
        public void UbahSatuan()
        {
            UIConfig UIconfig = new UIConfig();
            if (UIconfig.config.satuan_suhu == "Celcius")
            {
                UIconfig.config.satuan_suhu = "Fahrenheit";
                UIconfig.WriteNewConfigFile();
            }
            else if (UIconfig.config.satuan_suhu == "Fahrenheit")
            {
                UIconfig.config.satuan_suhu = "Celcius";
                UIconfig.WriteNewConfigFile();

            }
        }
    }
}
