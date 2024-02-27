
using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Workaround
{
    public class Program
    {
        static void Main(string[] args)
        {
            SelamVer(isim: "Engin");
            SelamVer(isim: "Ahmet");
            SelamVer(isim: "Ayşe");
            SelamVer();

            int sonuc = Topla(3, 5);

            //Dizilelr / Arrays

            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";
            //ogrenciler=new string[4];
            //ogrenciler[3] = "İlker";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir"};
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler1[0]);

            //int sayi1 = 10;
            //int sayi2 = 20;
            //sayi2 = sayi1;
            //sayi1 = 30;
            //Console.WriteLine(sayi2); 10

            Person person1 = new Person();
            person1.FirstName = "ENGİN";
            person1.LastName = "DEMİROĞ";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdentity = 123;

            foreach (var sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            //MyList 
            List<string> yeniSehirler1 = new List<string> {"Ankara 1","İstanbul 1","İzmir 1" };
            yeniSehirler1.Add("Adana 1");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);



            Console.ReadLine();
        }
        //resharper
        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc);
            return sonuc;
        }



        //private static void Degiskenler()
        //{
        //    string mesaj = "Selam";
        //    double tutar = 100000;//db'den gelir bir veri tabanındar gelir
        //    int sayi = 100;
        //    bool girisYapmisMi = false;

        //    string ad = "Engin";
        //    string soyad = "Demiroğ";
        //    int dogumYili = 1985;
        //    long tcNo = 12345678910;

        //    Console.WriteLine(mesaj);
        //    Console.WriteLine(mesaj);

        //    Console.WriteLine(tutar * 1.18);
        //}
    }

    //public class Vatandas
    //{
    //    //prop
    //    public string Ad { get; set; }
    //    public string Soyad { get; set; }
    //    public int DogumYili { get; set; }
    //    public long TcNo { get; set; }
    //}

}


// SOLID

// S - Single Responsibility Principle (Tek Sorumluluk Prensibi)
// O - Open/Closed Principle (Açık/Kapalı Prensibi)
// L - Liskov Substitution Principle (Liskov'un Yerine Geçme Prensibi)
// I - Interface Segregation Principle (Arayüz Ayrımı Prensibi)
// D - Dependency Inversion Principle (Bağımlılıkların Ters Çevrilmesi Prensibi)

// S - Single Responsibility Principle (Tek Sorumluluk Prensibi)
// Bir sınıfın sadece bir sorumluluğu olmalıdır. Yani bir sınıfın sadece bir işi olmalıdır.
//
//
// O - Open/Closed Principle (Açık/Kapalı Prensibi)
// Yazılım varlıkları (class, modül, fonksiyon vb.) gelişime açık, değişime kapalı olmalıdır.
//
//
// L - Liskov Substitution Principle (Liskov'un Yerine Geçme Prensibi)
// Bir sınıf alt sınıfı ile yer değiştirdiğinde aynı davranışı sergilemelidir.
//
//
// I - Interface Segregation Principle (Arayüz Ayrımı Prensibi)
// Bir sınıfın ihtiyacı olmayan metotları içermemesi gerekmektedir.
//
//
// D - Dependency Inversion Principle (Bağımlılıkların Ters Çevrilmesi Prensibi)
// Yazılım varlıkları (class, modül, fonksiyon vb.) somut sınıflara değil, soyutlamalara bağımlı olmalıdır.
