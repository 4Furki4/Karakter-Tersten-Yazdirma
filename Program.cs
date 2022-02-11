using System;

namespace KarakterTerstenYazdırma
{
    class Program
    {
        static void Main(string[] args)
        {
            Konsol_Islemleri konsol= new Konsol_Islemleri();
            TerstenYazdırma terstenYazdırma= new TerstenYazdırma();
            konsol.GirisMesaji();
            string[] cumleler= konsol.CumleleriAlma();
            string[] YeniCumleler=terstenYazdırma.TersCevir(cumleler);
            terstenYazdırma.KelimeleriYazdırma(YeniCumleler);
        }
    }
}
