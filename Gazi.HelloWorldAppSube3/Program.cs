namespace Gazi.HelloWorldAppSube3
{
    internal class Program
    {
        static int oyuncusayi = 500;
        static void Main(string[] args)
        {

            //int sayi = 100;//Değer tipi
            //string isim = "Ahmet";//Referans tipi
            //byte number = 150;
            //Console.WriteLine(sayi);

            //const int sayi = 10;
            //Console.WriteLine(sayi);
            //sayi = 20;
            //Console.WriteLine(sayi);


            //var sayi = 50;

            //string isim = "Ahmet", soyad = "Mehmet";

            //Console.WriteLine("Merhaba " + isim + " " + soyad);
            //Console.WriteLine("Merhaba {0} {1}", isim, soyad);
            //Console.WriteLine($"Merhaba {isim} {soyad}");

            Console.WriteLine("İsminizi giriniz:");
            string isim = Console.ReadLine();

            Console.WriteLine("Soyadınızı giriniz:");
            string soyad = Console.ReadLine();

            Console.WriteLine("Yaşınızı giriniz:");
            byte yas = byte.Parse(Console.ReadLine());            

            Console.WriteLine($"Hoşgeldin {isim} {soyad} Yaşınız:{yas}");

            //TÜR DÖNÜŞÜMLERİ (Type Casting)
            //C# programlama dili, tip güvenliği(type safety) sağlayan bir dildir.Örn. byte bir veriye string bir değer atanamaz.
            //Ancak atadığımız değeri istediğimiz veri tipine dönüştürerek atama gerçekleştirebiliriz.

            //byte sayi = 10;
            //int number = sayi;//Implicit Type Casting


            //checked
            //{
            //    int sayi = 257;
            //    byte number = (byte)sayi;//Explicit Type Casting
            //    Console.WriteLine(number); 
            //}
            //RİSK: Eğer atanmak istenen değer, atanacak veri tipinden büyükse veri kaybı olur. Bunun önüne geçmek için, checked blokları kullanılır. Bu blok risk durumunda hata vererek atama yapılmasını önler.

            //string sayi = "25";
            ////byte number = Convert.ToByte(sayi);
            //int number = int.Parse(sayi);
            //Console.WriteLine(number);  

            Console.ReadKey();
        }
    }
}

//Bit: 0-1
//8Bit = 1 Byte
//1024Byte=1 Kilobyte(KB)
//1024KB = 1 Megabyte(MB)
//1024MB = 1 Gigabyte(GB)
//1024GB = 1 Terabyte(TB)




//Namespace:İçinde classları bulunduran blok yapılarıdır.
//{ }: Blok(Scope) Yapıları
//Class: İçinde metodları bulunduran yapılardır.
//Metod: İş yapan kod bloklarıdır.
//Main Metodu: Console uygulamalarının giriş noktasıdır.
//IntelliSense: Kod yazım yardımcısı penceresi
//IntelliCode: Yapay zeka destekli kod yazım yardımcısı.
//Syntax: Kod yazılım kurallarına denir.
//Solution: İçinde projeleri tutan yapılardır.
//Derleme(Compile): C#->Derleme->MS-IL(exe)->Runtime(Derleme)->Makina Dili(0-1)
//MS-IL: Microsoft Intermediate Language

//.NET: Microsoft tarafından geliştirilmiş bir yazılım geliştirme ortamıdır.(Framework)
//Programlama Dilleri: C#-VB-F#
//Editorler: Visual Studio-Visual Studio Code
//Derleyiciler(Compiler) - Runtime
//Kütüphaneler (Namespace)


//Desktop Applications: Masaüstü uygulamaları. Console,Windows Forms App
//Web Based Applications: Web tabanlı uygulamar
//Mobile Apps: Xamarin->Android ve iOS
//iOT: Internet Of Things (Akıllı cihazlar)
//AI
//Game Development: Unity
