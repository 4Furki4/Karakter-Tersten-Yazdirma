using System;
namespace KarakterTerstenYazdırma
{
    public class TerstenYazdırma
    {
        public string[] TersCevir(string[] arr)
        {
            string[] yeniKelimeler= new string[arr.Length];
            foreach (var kelime in arr)
            {
                int s=0;
                int i=0;
                char[] harfler= new char[kelime.Length-1];
                    foreach (var harf in kelime)
                    {
                        
                        harfler[i]=harf;
                        i++;

                    }
                char ilk=harfler[0];
                for (int j = 0; j < harfler.Length; j++)
                {
                    harfler[j]=harfler[j+1];
                    harfler[j+1]=ilk;
                }
                foreach (var item in harfler)
                {
                    yeniKelimeler[s]+=item;
                    s++;
                }

            }
            return yeniKelimeler;
            
        }

        public void KelimeleriYazdırma(string[] arr)
        {
            foreach (var kelimeler in arr)
            {
                System.Console.WriteLine(kelimeler+" ");
            }
        }
    }
}
/*Furkan            urkanF
 
Furkan -> uurkan -> uFrkan
uFrkan
urFkan
urkFan
urkaFn
urkamF

*/