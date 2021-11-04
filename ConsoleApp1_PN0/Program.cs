using System;

namespace ConsoleApp1_PN0
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int Sayi = 0;
            string temp;

            Console.WriteLine("Bir Sayı Giriniz");
            Sayi = int.Parse(Console.ReadLine());

            if(Sayi>0)
            {
                Console.WriteLine("Sayı Pozitif");
            }
            else if(Sayi<0)
            {
                Console.WriteLine("Sayı Negatif");
            }

            else
            {
                Console.WriteLine("Sayı Sıfır '0' dır");
            }
            Console.WriteLine("Çıkmak için bir tuşa basınız"); 
            Console.ReadKey();
        }
    }
}
