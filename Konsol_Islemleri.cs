using System;
namespace KarakterTerstenYazdırma
{
    public class Konsol_Islemleri
    {
        public void GirisMesaji() // Talimatları yazdıracak metot.
        {
            System.Console.WriteLine("Lütfen girmek istediğiniz cümleleri aralarında boşluk olacak şekilde yazınız: "); 
        }
        public string[] CumleleriAlma()
        {
            string cumleler= Console.ReadLine();
            return cumleler.Split(" "); // aralarındaki boşluk sayesinde cümleleri birbirinden ayırıp bir string diziye atadım ve bunu döndürdüm. 
            
        }
        
    }
}