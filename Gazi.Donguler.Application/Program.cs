using System.Collections.Concurrent;

namespace Gazi.Donguler.Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("İsminizi giriniz:");
            //string isim = Console.ReadLine();
            //Console.WriteLine("Kaç kere yazılsın?");
            //int tekrar = int.Parse(Console.ReadLine());
            //for (int i=0 ; i < tekrar; i++)
            //{
            //    Console.WriteLine($"{i+1}.{isim}");
            //}
            //------------------------------------------------------

            //Console.WriteLine("Başlangıç değeri:");
            //int ilk =int.Parse(Console.ReadLine());
            //Console.WriteLine("Bitiş değeri:");
            //int son =int.Parse(Console.ReadLine());
            //Console.WriteLine("Tek mi yoksa çift mi yazılsın.");
            //string cevap = Console.ReadLine().ToLower();
            //int top = 0;
            //int temp;
            //if (ilk >son)
            //{
            //    temp = ilk;
            //    ilk = son;
            //    son = temp;
            //}
            //for (int i = ilk; i <= son; i++)
            //{
            //    if (i%2==(cevap=="tek"?1:0))
            //    {
            //        Console.WriteLine(i);
            //        top += i;
            //    }
            //}
            //Console.WriteLine($"Sayıların toplamı:{top}");
            //-------------------------------------------------

            //Console.WriteLine("Taban değeri giriniz.");
            //int taban =int.Parse(Console.ReadLine());
            //Console.WriteLine("Üs değeri giriniz.");
            //int üst =int.Parse(Console.ReadLine());
            //int sonuc = 1;
            //for (int i = 1; i <= üst; i++)
            //{
            //    sonuc = sonuc * taban;

            //}
            //Console.WriteLine($"İşlemin sonucu : {sonuc}");

            //------------------------------------------------
            //Console.WriteLine("--Faktöriyel hesaplama--");
            //Console.WriteLine("Bir sayı giriniz");
            //int sayi = int.Parse(Console.ReadLine());
            //int sonuc = 1;
            //for (int i = 2; i <= sayi; i++)//bir etkisiz olduğu için döngü elemanı olan i yi 2 den başlatabiliriz.
            //{
            //    sonuc *= i;
            //}
            //Console.WriteLine(sonuc);
            //-----------------------------------------------

            //Console.WriteLine("Asallık hesaplama");
            //Console.WriteLine("Bir sayı giriniz.");
            //int sayi = int.Parse(Console.ReadLine());
            //int sayac = 0;

            //if (sayi > 2 && sayi % 2 == 0)
            //{
            //    Console.WriteLine("Asal değil");
            //}
            //else if(sayi<2)
            //{
            //    Console.WriteLine("En küçük asal sayı 2 dir.");
            //}
            //else
            //{
            //    for (int i = 2; i < (sayi / 2); i++)
            //    {
            //        if (sayi % i == 0)
            //        {
            //            sayac++;
            //            break;
            //        }

            //    }
            //    Console.WriteLine(sayac == 0 ? "Asal." : "Asal değil.");
            //}

            //-----------------------------------------------------

            //for(; ;)//sonsuz döngü
            //{
            //    Console.WriteLine("Kullanıcı adı giriniz");
            //    string user = Console.ReadLine();
            //    Console.WriteLine("Şifre giriniz.");
            //    string pass = Console.ReadLine();
            //    if(user=="admin"&&pass=="123")
            //    {
            //        Console.WriteLine("Giriş Başarılı");
            //        break;
            //    }
            //}
            //---------------------------------------------------------------

            //int max = int.MinValue;
            //double top = 0;
            //int aritmetik = 0;
            //double sayac = 0;
            //for (; ; )
            //{
            //    Console.WriteLine("Bir sayı giriniz");
            //    int sayi = int.Parse(Console.ReadLine());
            //    sayac++;
            //    Console.WriteLine("Devam etmek istiyor musunuz?E/H");
            //    string cevap = Console.ReadLine().ToUpper();
            //    if (sayi > max)
            //    {
            //        max = sayi;
            //    }

            //    if (cevap == "H")
            //    {
            //        break;
            //    }
            //    else if (cevap=="E")
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatalı giriş yaptınız.");
            //    }


            //}
            //Console.WriteLine($"Girdiğiniz en büyük sayı :{sayac}\nSayıların Toplamları.{top +=sayi}\nSayıların aritmetik ortalaması:{top/sayac}");


            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write($"{i},{j}\t");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {

            //        Console.Write($"*\t");

            //    }
            //    Console.WriteLine();
            //}

            ////
            //Console.WriteLine("Enter row count");
            //int row = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter column count");
            //int column = int.Parse(Console.ReadLine());
            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < column; j++)
            //    {
            //        Console.Write((i + j) % 2 == 0 ? "*" : " ");
            //    }
            //    Console.WriteLine();
            //}

            //


            //bool control = false;
            //for (int a = 1; a < 10; a++)
            //{
            //    for (int b = 1; b < 10; b++)
            //    {
            //        for (int c = 1; c < 10; c++)
            //        {
            //            for (int d = 1; d <= 10; d++)
            //            {
            //                int abcd = 1000 * a + 100 * b + 10 * c + d;
            //                int dcba = 1000 * d + 100 * c + 10 * b + a;
            //                if (abcd ==4*dcba)
            //                {
            //                    Console.WriteLine($"{a}{b}{c}{d}");
            //                    control = true;
            //                    break;
            //                }

            //            }
            //            if (control) { break; }
            //        }
            //        if (control) { break; }
            //    }
            //    if (control) { break; }
            //}

            //
            //Dik Üçgen bulma
            //for (int i = 1; i < 50; i++)
            //{
            //    for (int  j = 1; j < 50; j++)
            //    {
            //        for (int  k = 1; k < 50; k++)
            //        {

            //            if ((i * i) + (j * j) == (k * k))
            //            {
            //                Console.WriteLine($"{i}-{j}-{k}");
            //            }
            //        }
            //    }
            //}

            //


            //Console.WriteLine("Enter starting number");
            //int start = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter end number");
            //int end = int.Parse(Console.ReadLine());

            //for (int i = start; i <= end; i++)
            //{
            //    int count = 0;
            //    for (int j = 2; j <= (i / 2); j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            count++;
            //            break;
            //        }
            //    }

            //    Console.WriteLine($"{i}{(count == 1 ? "-Is Not prime" : "-Is prime")}");
            //}

            //WHİLE DÖNGÜSÜ
            //int count = 0;
            //while (count<5) { Console.WriteLine("Gazi");count++; }


            //int max = int.MinValue;
            //double top = 0;
            //int aritmetik = 0;
            //double sayac = 0;
            //while (true)
            //{
            //    Console.WriteLine("Bir sayı giriniz");
            //    int sayi = int.Parse(Console.ReadLine());
            //    sayac++;
            //    Console.WriteLine("Devam etmek istiyor musunuz?E/H");
            //    string cevap = Console.ReadLine().ToUpper();
            //    if (sayi > max)
            //    {
            //        max = sayi;
            //    }

            //    if (cevap == "H")
            //    {
            //        break;
            //    }
            //    else if (cevap == "E")
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatalı giriş yaptınız.");
            //    }
            //}

            //    int max = int.MinValue;
            //    double top = 0;
            //    int aritmetik = 0;
            //    double sayac = 0;
            //    string cevap;
            //    int sayi;
            //    do
            //    {
            //        Console.WriteLine("Bir sayı giriniz");
            //        sayi = int.Parse(Console.ReadLine());
            //        sayac++;

            //        if (sayi > max)
            //        {
            //            max = sayi;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Hatalı giriş yaptınız.");
            //        }
            //        Console.WriteLine("Devam etmek istiyor musunuz?E/H");
            //        cevap = Console.ReadLine().ToLower();
            //    } while (cevap!= "h");
            //    Console.WriteLine($"Girdiğiniz en büyük sayı :{sayac}\nSayıların Toplamları.{top += sayi}\nSayıların aritmetik ortalaması:{top / sayac}");
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j=0;j<10 ;j++ )
            //    {
            //        Random rnd = new Random();
            //        int number = rnd.Next(33,127);
            //        Console.Write((char)number);
            //    }
            //    Console.WriteLine();
            //}
            string difficulty;
            int number = 0,guess,count=0,right=0,hintcounter=0,point=100;
            Random rnd = new Random();
            while (true)
            {
                Console.WriteLine("Choose difficulty:easy/medium/hard");
                difficulty = Console.ReadLine().ToLower();
                if (difficulty == "easy" || difficulty == "e")
                {
                    number = rnd.Next(20);
                    right = 5;
                    break;
                }
                else if (difficulty == "medium" || difficulty == "m")
                {
                    number = rnd.Next(100);
                    right = 30;
                    break;
                }
                else if (difficulty == "hard" || difficulty == "h")
                {
                    number = rnd.Next(1000);
                    right = 300;
                    break;
                }
                else
                {
                    Console.WriteLine("You did not choose difficulty");
                }
            }
            do
            {
                string hint;
                if ((difficulty == "easy" || difficulty == "e") && hintcounter == 0)
                {
                    Console.WriteLine("Do you want a hint? (Y/N)(Just a right!)");
                    hint = Console.ReadLine().ToUpper();
                    if (hint == "Y")
                    {
                        if (number <= 10)
                        {
                            Console.WriteLine("It is less than or equal to 10");
                            hintcounter++;
                        }
                        else
                        {
                            Console.WriteLine("It is greater than or equal to 10!");
                            hintcounter++;
                        }
                    }
                    else
                    {
                        hintcounter++;
                    }
                }
                Console.WriteLine("Guess the number.");
                guess = int.Parse(Console.ReadLine());
                if (count < right)
                {
                    Console.WriteLine($"Your number:{guess}");
                    Console.WriteLine(guess == number ? "True! You won" : "Wrong!Try again.");
                    count++;
                }
                else
                {
                    Console.WriteLine($"Game over!\nYou do not have right to guess now.\nAnswer ={number}\nYou should start over! ");
                    break;
                }
            }
            while (guess != number);
            if (count <= 5)
            { Console.WriteLine($"Your scor:{point - (20 * (count-1))}"); }
            else if (5 < count && count <= 30)
            { Console.WriteLine($"Your scor:{(point) - ((10 / 3) * (count-1))}"); }
            else
            { Console.WriteLine($"Your scor:{point - ((count-1) / 3)}"); }
            //seviye ve puan sistemi ekle

        }
    }
}
//asci

