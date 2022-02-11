using System;
namespace KarakterTerstenYazdırma
{
    public class TerstenYazdırma
    {
        public string[] TersCevir(string[] arr)
        {
            string[] yeniKelimeler= new string[arr.Length]; //Yeni kelimelerin son hallerini bu diziye atayacağım.
            int s=0;
            foreach (var kelime in arr) //Konsoldan alınan kelimelere teker teker ulaşıyoruz.
            {
                
                int i=0;
                char[] harfler= new char[kelime.Length]; //ilk kelimenin tüm harflerini "harfler" adlı bir char dizisine atıyorum.
                    foreach (var harf in kelime)
                    {
                        
                        harfler[i]=harf;
                        i++;

                    }
                char ilk=harfler[0]; //ilk harf sona geleceği için bunu ayrı bir char değişkeninde her seferinde tutacağım.
                for (int j = 0; j < harfler.Length-1; j++)
                {
                    harfler[j]=harfler[j+1]; // 1. index 0'a, 2. index 1'e atanacak örüntüde gidiyoruz ancak her atamada bir kelime klonlanmış olacağı için 
                    harfler[j+1]=ilk;        // ilk harfi ön tarafa atanan harfin indexine atıyorum ki teker teker arka tarafa kaysın.
                }
                string yenikelime=""; // yeni bir string değişken oluşturdum ve her kelimenin son halinin harflerini teker teker bu değişkende toplayacağım.
                foreach (var item in harfler)
                {
                    yenikelime+=item;
                }
                yeniKelimeler[s]=yenikelime; // En üstte oluştuduğum diziye yeni kelimeleri atadım.
                s++;

            }
            return yeniKelimeler;
            
        }

        public void KelimeleriYazdırma(string[] arr) // Döndürdüğümüz yeniKelime dizisini kullanarak her yeni oluşan kelimeyi yazdıran metot.
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