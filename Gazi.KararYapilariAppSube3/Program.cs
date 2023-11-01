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

            Console.WriteLine("1.sayıyı giriniz:");
            double s1 = double.Parse(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz:");
            double s2 = double.Parse(Console.ReadLine());
            Console.WriteLine("İşlem seçiniz:+,-,/,*");
            char islem = char.Parse(Console.ReadLine());
            string msg = "İşlemin Sonucu:";
            if (islem == '+')
            {
                Console.WriteLine($"{msg}{s1 + s2}");
            }
            else if (islem == '-')
            {
                Console.WriteLine($"{msg}{s1 - s2}");
            }
            else if (islem == '*')
            {
                Console.WriteLine($"{msg}{s1 * s2}");
            }
            else if (islem == '/')
            {
                Console.WriteLine($"{msg}{s1 / s2}");
            }
            else
            {
                Console.WriteLine("Hatalı işlem seçtiniz!");
            }





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
        }
    }
}



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