using System.Collections.Generic;
using System.Threading;
namespace phoneBook
{
    public class RehberMetodlar{

        // 1 - Rehbere Ekleme Yapma
        public void RehbereEkle(List<kisiBilgileri> rehber){
            Console.WriteLine("**** Rehber Kişi Ekleme Menüsü ****");
            Console.Write("Lütfen Kişinin Adını Giriniz: ");
            string ad = Console.ReadLine();
            Console.Write("Lütfen Kişinin Soyadını Giriniz: ");
            string soyad = Console.ReadLine();
            Console.Write("Kişinin Telefon Numarasını Giriniz: ");
            string numara = Console.ReadLine();
            rehber.Add(new kisiBilgileri{Ad = ad, Soyad= soyad, TelefonNo=numara});
            Thread.Sleep(100);
            System.Console.WriteLine("İşleminiz Yapılıyor.");
            Thread.Sleep(100);
            System.Console.WriteLine("İşleminiz Yapılıyor..");
            Thread.Sleep(100);
            System.Console.WriteLine("İşleminiz Yapılıyor...");
            Thread.Sleep(100);
            System.Console.WriteLine("Kişi sisteme eklendi...");
            Thread.Sleep(1500);

        }
// -------------------------------------------------------------------------------------------------------------------

        // 2 - Rehberden Silmek
        public void RehberdenCikar(List<kisiBilgileri> rehber)
        {
                Console.Clear();
                System.Console.WriteLine("**** Rehberden Kişi Silme ****");
	            System.Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
	            
	            kisiBilgileri silinecekKisi;
	            silinecekKisi = arananKisi(rehber);
	           
	            if(silinecekKisi != null){
	                System.Console.WriteLine("---- Silinecek Kişinin Bilgileri ----");
	                kisiyiGoruntule(silinecekKisi);
	                string secim = "";
	                Console.Write("Kişi rehberden silinmek üzere, onaylıyo rmusunuz ?(y/n):");
	                secim = Console.ReadLine().ToLower();
	                while (true)
	                {
	                    if(secim == "y"){
	                        rehber.Remove(silinecekKisi);
	                        System.Console.WriteLine("Kişi rehberden silinmiştir.");
	                        Thread.Sleep(1500);
	                        break;
	                    }else if(secim == "n"){
	                        System.Console.WriteLine("Kişinin rehberden silinmesi reddedildi.");
	                        Thread.Sleep(1500);
	                        break;
	                    }else{
	                        System.Console.WriteLine("Hatalı seçim yaptınız... Tekrar deneyin...");
	                        Thread.Sleep(1500);
	                        Console.Clear();
	                    }
	                }
	            }else{
	               while (true)
                    {
                        System.Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                        System.Console.WriteLine( "* Silmeyi sonlandırmak için: (1)\n* Yeniden denemek için: (2)");
                        System.Console.Write( "Seçiminizi giriniz: ");
                        string cevap = System.Console.ReadLine();

                        if(cevap == "1"){
                            break;
                        }else if(cevap =="2"){
                            RehberdenCikar(rehber);
                            break;
                        }else{
                            System.Console.WriteLine("Hatalı seçim yaptınız...");
                        }

                    }
	            }         
             
        }
// -------------------------------------------------------------------------------------------------------------------

       // 3 - Rehberdeki kişileri güncelleme
        public void rehberiGuncelle(List<kisiBilgileri> rehber){
            Console.Clear();
            System.Console.WriteLine("**** Rehberden Kişi Güncelleme ****");
            System.Console.WriteLine("Güncellenecek kişiyi hangi yönteme göre aramak istersiniz: \n(1) Ada veya Soyada göre arama yapmak\n(2) Numaraya göre arama yapmak\n(0) Arama Menüsünden Çıkmak");
            System.Console.Write("Seçiminiz nedir: ");
            kisiBilgileri silinecekKisi;
            string secim = Console.ReadLine();
            if(secim=="1")
            {
                AdiveyaSoyadRehberGünc(rehber);
            }
            else if(secim=="2")
            {
                NumaraileRehberdeAraGünc(rehber);
            }
            else if(secim=="0")
            {
                System.Console.WriteLine("Arama menüsünden çıkışınız yapılıyor...");
                Thread.Sleep(1500);
            }
        }

        public void AdiveyaSoyadRehberGünc(List<kisiBilgileri> rehber)
        {
            while (true)
            {
	            System.Console.WriteLine("*** Ad veya Soyad ile Arama ***");
	            System.Console.Write("Güncellenecek Kişinin Adını veya Soyadını Giriniz: ");
	            kisiBilgileri kisi;
	            kisi = arananKisi(rehber);
	            if(kisi!=null){
	                kisiGüncelleme(kisi);
                    break;
	            }else{
	                while (true)
                    {
                        System.Console.WriteLine("Belirttiğiniz kriterlerde herhangi biri bulunamadı.\n(1) Tekrar Arama Yapmak\n(2) Güncelleme Menüsünden Çıkmak");
                        System.Console.Write("Seçiminiz nedir: ");
                        string secim = Console.ReadLine();
                        if(secim=="1"){
                            AdiveyaSoyadRehberGünc(rehber);
                            break;
                        }else if(secim=="2"){
                            System.Console.WriteLine("Güncelleme menüsünden çıkışınız yapılmıştır.");
                            Thread.Sleep(1500);
                            break;
                        }else{
                            System.Console.WriteLine("Hatalı giriş yaptınız tekrar deneyiniz.");
                        }
                    }
                    break;
	            }
            }
            

        }

        public void NumaraileRehberdeAraGünc(List<kisiBilgileri> rehber)
        {
            while (true)
            {
                System.Console.WriteLine("*** Numara ile Arama ***");
	            kisiBilgileri kisi;
	            System.Console.Write("Güncellenecek Kişinin Numarasını Giriniz: ");
	            kisi = numarayaGoreArananKisi(rehber);
	            if(kisi!=null)
                {
		                kisiGüncelleme(kisi);
                }
                else
                {
                    while (true)
                    {
                        System.Console.WriteLine("Belirttiğiniz kriterlerde herhangi biri bulunamadı.\n(1) Tekrar Arama Yapmak\n(2) Güncelleme Menüsünden Çıkmak");
                        System.Console.Write("Seçiminiz nedir: ");
                        string secim = Console.ReadLine();
                        if(secim=="1"){
                            NumaraileRehberdeAraGünc(rehber);
                            break;
                        }else if(secim=="2"){
                            System.Console.WriteLine("Güncelleme menüsünden çıkışınız yapılmıştır.");
                            Thread.Sleep(1500);
                            break;
                        }else{
                            System.Console.WriteLine("Hatalı giriş yaptınız tekrar deneyiniz.");
                        }
                    }
                    break;
                }
            }
        }

        public void kisiGüncelleme(kisiBilgileri kisi){
            
            while (true)
            {
                Console.Clear();
	            System.Console.WriteLine("*** Kişiyi Güncelleme Menüsü ***\n");
	            System.Console.WriteLine("Güncellenecek Kişi:");
	            kisiyiGoruntule(kisi);
	
	            System.Console.WriteLine("\n(1) Kişinin Adını Güncelleme\n(2) Kişinin Soydını Güncelleme\n(3) Kişinin Numarasını Güncelleme\n(0) Güncelleme Menüsünden Çıkma");
	            System.Console.Write("Seçiminiz nedir:");
	            string secim = Console.ReadLine();
                Console.Clear();
                System.Console.WriteLine("Güncellenecek Kişi:");
	            kisiyiGoruntule(kisi);
                System.Console.WriteLine("\n");
	            if(secim == "0")
                {
                    System.Console.WriteLine("Güncelleme menüsünden çıkışınız yapılmıştır...");
                    Thread.Sleep(1500);
                    break;
	            }
                else if(secim == "1")
                {
                    System.Console.WriteLine("-- Kişinin Adını Güncelleme --");
                    System.Console.Write("Güncellenecek Kişinin Adı: ");
                    kisi.Ad=Console.ReadLine();
                    System.Console.WriteLine("Kişinin Güncel Bilgileri:");
	                kisiyiGoruntule(kisi);
                    Thread.Sleep(1500);
                    break;
	            }
                else if(secim == "2")
                {
                    System.Console.WriteLine("-- Kişinin Soyadını Güncelleme --");
                    System.Console.Write("Güncellenecek Kişinin Soyadı: ");
                    kisi.Soyad=Console.ReadLine();
                    System.Console.WriteLine("Kişinin Güncel Bilgileri:");
	                kisiyiGoruntule(kisi);
                    Thread.Sleep(1500);
                    break;
	            }
                else if(secim == "3")
                {
                    System.Console.WriteLine("-- Kişinin Numarısını Güncelleme --");
                    System.Console.Write("Güncellenecek Kişinin Numarası: ");
                    kisi.TelefonNo=Console.ReadLine();
                    System.Console.WriteLine("Kişinin Güncel Bilgileri:");
	                kisiyiGoruntule(kisi);
                    Thread.Sleep(1500);
                    break;
	            }
                else
                {
	                System.Console.WriteLine("Hatalı seçim yaptınız. Tekrar deneyiniz.");
                    Thread.Sleep(1500);
	            }
            }
        }  
// -------------------------------------------------------------------------------------------------------------------
        
        // 4 - Rehbere Görüntüleme
        public void RehberiGoruntule(List<kisiBilgileri> rehber){
            int sira = 1;
            System.Console.WriteLine("**** Rehberdeki Kişiler ****");
            foreach(var item in rehber){
                System.Console.WriteLine("{0} - Kişinin Adı ve Soyadı: {1} |   Telefon Numarası: {2}",sira,(item.Ad+" "+item.Soyad).PadRight(23), item.TelefonNo);
                sira++;
            }
            Console.Write("Devam Etmek için herhangi bir tuşa basınız:");
            Console.ReadLine();
        }
// -------------------------------------------------------------------------------------------------------------------

         // 5 - Rehberde Arama İşlemi
        public void RehberdenSorgula(List<kisiBilgileri> rehber){
            while (true)
            {
                Console.Clear();
	            System.Console.WriteLine("**** Rehberden Kişi Arama Menüsü ****");
	            System.Console.WriteLine("(1) Ad veya Soyad'a göre Arama");
	            System.Console.WriteLine("(2) Numaraya göre Arama");
	            System.Console.WriteLine("(0) Arama Menüsünden Çıkış Yapma");
	            System.Console.Write("Seçiminiz Nedir: ");
	            string secim = Console.ReadLine();
	
	            if(secim == "0"){
	                System.Console.WriteLine("Arama Menüsünden Çıkışınız Yapılıyor...");
                    Thread.Sleep(1500);
                    break;
	            }else if(secim =="1"){
                    adsoyadileSorgula(rehber);
                    break;
                }else if(secim =="2"){
                    numaraileSorgula(rehber);
                    break;
                }else{
                    System.Console.WriteLine("Hatalı seçim yaptınız. Tekrar giriş yapınız...");
                }
            }
        }

        // Rehberde ad veya soyad ile kişiyi arama ve getirme
        public void adsoyadileSorgula(List<kisiBilgileri> rehber){
            while (true)
            {
                Console.Clear();
	            System.Console.WriteLine("*** Ad veya Soyad ile Arama ***");
	            System.Console.Write("Aranacak Kişinin Adını veya Soyadını Giriniz: ");
	            kisiBilgileri kisi;
	            kisi = arananKisi(rehber);
	            if(kisi!=null){
	                kisiyiGoruntule(kisi);
                    Console.Write("Sorgulama işlemini sonlandırmak için (Enter) tuşuna basınız..");
                    Console.ReadLine();
                    break;
	            }else{
	                while (true)
                    {
                        System.Console.WriteLine("Belirttiğiniz kriterlerde herhangi biri bulunamadı.\n(1) Tekrar Arama Yapmak\n(2) Arama Menüsünden Çıkmak");
                        System.Console.Write("Seçiminiz nedir: ");
                        string secim = Console.ReadLine();
                        if(secim=="1"){
                            adsoyadileSorgula(rehber);
                            break;
                        }else if(secim=="2"){
                            System.Console.WriteLine("Arama menüsünden çıkışınız yapılmıştır.");
                            Thread.Sleep(1500);
                            break;
                        }else{
                            System.Console.WriteLine("Hatalı giriş yaptınız tekrar deneyiniz...");
                        }
                    }
                    break;
	            }
            }
        }

        // Rehberde telefon numarası ile kişiyi arama ve getirme
        public void numaraileSorgula(List<kisiBilgileri> rehber){
            while (true)
            {
                Console.Clear();
                System.Console.WriteLine("*** Numara ile Arama ***");
	            kisiBilgileri kisi;
	            System.Console.Write("Aranacak Kişinin Numarasını Giriniz: ");
	            kisi = numarayaGoreArananKisi(rehber);
	            if(kisi!=null)
                {
		            kisiyiGoruntule(kisi);
                    Console.Write("Sorgulama işlemini sonlandırmak için (Enter) tuşuna basınız..");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    while (true)
                    {
                        System.Console.WriteLine("Belirttiğiniz kriterlerde herhangi biri bulunamadı.\n(1) Tekrar Arama Yapmak\n(2) Arama Menüsünden Çıkmak");
                        System.Console.Write("Seçiminiz nedir: ");
                        string secim = Console.ReadLine();
                        if(secim=="1"){
                            numaraileSorgula(rehber);
                            break;
                        }else if(secim=="2"){
                            System.Console.WriteLine("Arama menüsünden çıkışınız yapılmıştır.");
                            Thread.Sleep(1500);
                            break;
                        }else{
                            System.Console.WriteLine("Hatalı giriş yaptınız tekrar deneyiniz.");
                        }
                    }
                    break;
                }
            }
        }

// -------------------------------------------------------------------------------------------------------------------

// ----------------------------- Ortak Kullanılan Metodlar --------------------------------

// Genel Arama Metodları
        public kisiBilgileri arananKisi(List<kisiBilgileri> rehber){
            string key= Console.ReadLine();
            
            foreach (var item in rehber)
            {
                if (item.Ad.ToLower().Contains(key.ToLower()) ||item.Soyad.ToLower().Contains(key.ToLower()) )
                {
                    return item;
                }else{
                    
                }
            }
            return null;
        }

        public kisiBilgileri numarayaGoreArananKisi(List<kisiBilgileri> rehber){
            
            string key= Console.ReadLine();
            
            foreach (var item in rehber)
            {
                if (item.TelefonNo.ToLower().Contains(key.ToLower()))
                {
                    return item;
                }else{
                    
                }
            }
            return null;
        }

// Kişiyi Ekrana Yazdırma
        public void kisiyiGoruntule(kisiBilgileri kisi){
            System.Console.WriteLine("Adı: {0}",kisi.Ad);
            System.Console.WriteLine("Soyadı: {0}",kisi.Soyad);
            System.Console.WriteLine("Telefon Numarası: {0}",kisi.TelefonNo);
        }
    }
}