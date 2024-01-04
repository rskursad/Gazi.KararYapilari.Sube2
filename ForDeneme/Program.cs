namespace ForDeneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Başlangıç değeri giriniz.");
            int ilk =int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz.");
            int son =int.Parse(Console.ReadLine());
            Console.WriteLine("Kaç saniye bekleyerek saysın");
            int saniye=int.Parse(Console.ReadLine());
            Console.WriteLine("Tek mi,çift mi yoksa farketmez mi?");
            string cevap = Console.ReadLine().ToLower();
            int temp = 0;
            int top = 0;
            if(ilk>son)
            {
                temp = ilk;
                ilk = son;
                son = temp;
            }
            for (int i = ilk; i <=son; i++)
            {
                if (i%2==(cevap=="tek"?1:0))
                {
                    Console.WriteLine(i);
                    top += i;
                    System.Threading.Thread.Sleep(saniye*1000);
                }
                else if (cevap=="farketmez")
                {
                    Console.WriteLine(i);
                    top += i;
                }
            }
            Console.WriteLine($"Sayıların toplamı :{top}");

        }
    }
}
