namespace Gazi.KararYapilariAppSube3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if (1 > 1)
            //{
            //    Console.WriteLine("True değer");
            //}
            //else
            //{
            //    Console.WriteLine("False değer");
            //}



            //Console.WriteLine("Dil seçiniz/Select Language(TR/EN):");
            //string cevap = Console.ReadLine().ToUpper();
            //string msg1, msg2, msg3, msg4, msg5;

            //if (cevap=="TR")
            //{
            //    msg1 = "1.Sayıyı giriniz:";
            //    msg2 = "2.Sayıyı giriniz:";
            //    msg3 = "İşlem seçiniz:";
            //    msg4 = "İşlemin sonucu:";
            //    msg5 = "Hatalı işlem seçtiniz!";
            //}
            //else 
            //{
            //    msg1 = "Enter first number:";
            //    msg2 = "Enter second number:";
            //    msg3 = "Select Operation:";
            //    msg4 = "Result:";
            //    msg5 = "Incorrect Operation Selected!";
            //}


            //Console.WriteLine(msg1);
            //double s1 = double.Parse(Console.ReadLine());
            //Console.WriteLine(msg2);
            //double s2 = double.Parse(Console.ReadLine());
            //Console.WriteLine(msg3);
            //char islem = char.Parse(Console.ReadLine());

            //if (islem == '+')
            //{
            //    Console.WriteLine($"{msg4}{s1 + s2}");
            //}
            //else if (islem == '-')
            //{
            //    Console.WriteLine($"{msg4}{s1 - s2}");
            //}
            //else if (islem == '*')
            //{
            //    Console.WriteLine($"{msg4}{s1 * s2}");
            //}
            //else if (islem == '/')
            //{
            //    Console.WriteLine($"{msg4}{s1 / s2}");
            //}
            //else
            //{
            //    Console.WriteLine(msg5);
            //}



            //if (s1>s2)
            //{
            //    Console.WriteLine("1. sayı büyüktür.");
            //}
            //else if(s2> s1) 
            //{
            //    Console.WriteLine("2. sayı büyük.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayılar eşit");
            //}

            Console.WriteLine("Hava nasıl?");
            string durum = Console.ReadLine().ToLower().Trim();
            if (durum == "güzel" || durum == "iyi")
            {
                Console.WriteLine("Kaç derece?");
                sbyte derece = sbyte.Parse(Console.ReadLine());
                if (derece <= 15)
                {
                    Console.WriteLine("Soğuk evde otur");
                }
                else if (derece > 15 && derece <= 35)
                {
                    Console.WriteLine("Dışarı çık");
                }
                else
                {
                    Console.WriteLine("Çok sıcak evde otur");
                }
            }
            else if (durum == "kötü")
            {
                Console.WriteLine("Evde otur");
            }
            else
            {
                Console.WriteLine("Hatalı giriş!");
            }



            //try
            //{
            //    Console.WriteLine("Sayı giriniz:");
            //    byte sayi = byte.Parse(Console.ReadLine());
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Rakamla giriniz");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("0-255 arası değer giriniz");
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Bilinmeyen hata!");
            //}
        }
    }
}

//Exception Handling-try-catch



//Dil Seçiniz/Select Language:TR
//1. sayıyı giriniz: 10
//2. sayıyı giriniz: 5
//İşlem seçiniz: +
//İşlemin sonucu:15

//Dil Seçiniz/Select Language:EN
//Please Enter First Number: 10
//Please Enter Second Number: 5
//Select Operation: +
//Result:15