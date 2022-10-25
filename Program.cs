using System;
using System.Collections.Generic;


namespace phoneBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            List<kisiBilgileri> rehber = new List<kisiBilgileri>
            {
                new kisiBilgileri{Ad ="Yusuf Tolunay", Soyad=  "Çağlar",TelefonNo="0546"},
                new kisiBilgileri{Ad ="Ahmet", Soyad=  "Dağ",TelefonNo="0543"},
                new kisiBilgileri{Ad ="Mustafa", Soyad=  "Koç",TelefonNo="0544"},
                new kisiBilgileri{Ad ="Savaş", Soyad=  "Karhal",TelefonNo="0545"},
                new kisiBilgileri{Ad ="Cemalcan", Soyad=  "Ceylan",TelefonNo="0547"},
            };

            
            
            RehberMetodlar rehberMetod = new RehberMetodlar();

            
            while(true)
            {
                Console.Clear();

                Console.WriteLine("**** Rehber Menü *****");
                Console.WriteLine("***************************");
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak");
                Console.WriteLine("(0) Rehber Uygulamasından Çıkmak");

                Console.Write("\nLütfen yapmak istedeğiniz işlemi giriniz: ");
                int key = int.Parse(Console.ReadLine());
                if(key == 0 )
                {
                    System.Console.WriteLine("Rehber Uygulamasından Çıkışınız Yapılmıştır...");
                    break;
                }else if(key == 1)
                {
                    rehberMetod.RehbereEkle(rehber);
                }else if(key == 2)
                {
                    rehberMetod.RehberdenCikar(rehber);
                }else if(key == 3)
                {   
                    rehberMetod.rehberiGuncelle(rehber);
                }else if(key == 4)
                {
                    rehberMetod.RehberiGoruntule(rehber);
                }else if(key == 5)
                {
                    rehberMetod.RehberdenSorgula(rehber);
                }else
                {
                    System.Console.WriteLine("Hatalı Giriş Yaptınız. Tekrar deneyin...");    
                }
            }
            

        
        }
    }
}