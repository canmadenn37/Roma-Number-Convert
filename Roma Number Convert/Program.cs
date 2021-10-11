using System;

namespace Roma_Number_Convert
{
    



    class Program
    {
        static void Yıldız()
        {

            Console.WriteLine("---------------------\n");

    }

        static void NumberToRome()
        {
            int girilensayi, birler =0,onlar=0,yüzler=0,binler=0;

            string[] dbirler = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] donlar = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] dyuzler = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] dbinler = { "", "M", "MM", "MMM" , "MV|", "V |"};



            Yıldız();
            Console.WriteLine("Lütfen Dönüştürmek istediğiniz Numerik Sayıyı giriniz !! ");
            Yıldız();
            girilensayi=int.Parse( Console.ReadLine());


            if (girilensayi<9)
            {
                birler = girilensayi;
            }



            if (girilensayi < 100 && girilensayi > 9)
            {
                onlar = girilensayi / 10;
                birler = girilensayi - (onlar * 10);



            }
            else if (girilensayi > 99 && girilensayi < 1000)
            {
                yüzler = girilensayi / 100;
                onlar = (girilensayi - (yüzler * 100)) / 10;
                birler = girilensayi - ((yüzler * 100) + (onlar * 10));

            }
            else if (girilensayi > 999 && girilensayi < 6000)
            {
                binler = girilensayi / 1000;
                yüzler = (girilensayi - (binler * 1000)) / 100;
                onlar = (girilensayi - ((binler * 1000) + (yüzler * 100))) / 10;
                birler = (girilensayi - ((binler * 1000) + (yüzler * 100)+(onlar*10)));
            }
            else
            {
                Console.WriteLine("Değer dışı");
            }


            Yıldız();
            
            Console.WriteLine(dbinler[binler] + dyuzler[yüzler] + donlar[onlar] + dbirler[birler]);

            Yıldız();

            


        }

        

        static void secim() 
        {
            int Secim;


            Yıldız();
            Console.WriteLine("1 - Number To Rome");
            Console.WriteLine("2 - Çıkış");
            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Secin Ve Entere basın.");
            Yıldız();
            Secim = int.Parse(Console.ReadLine());

            switch (Secim)
            {
                case 1:
                    NumberToRome();

                    break;
                case 2:
                    Yıldız();
                    Console.WriteLine("çıkış");
                    Yıldız();
                    break;
                default:

                    Console.WriteLine("lütfen değer gir");

                    break;
            }

        }
    static void Main(string[] args)
        {

            secim();




            Console.ReadLine();



        }
    }
}
