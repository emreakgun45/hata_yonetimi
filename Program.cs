using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Bir sayi giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmis oldugunuz sayi: "+sayi);

            }
            catch(Exception ex)
            {
                System.Console.WriteLine("Hata: "+ex.Message.ToString());
            }
            finally
            {
                System.Console.WriteLine("Islem tamamlandi!");
            }

            try
            {
                int a = int.Parse(null);
                int b = int.Parse("test");
                int c = int.Parse("-20000000000");
            }
            catch (ArgumentException ex)
            {
                System.Console.WriteLine("Bos deger girdiniz.");
                System.Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                System.Console.WriteLine("Veri tipi uygun değil.");
                System.Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                System.Console.WriteLine("Cok kucuk ya da cok buyuk bir deger girdiniz. ");
                System.Console.WriteLine(ex);
            }
            finally
            {
                System.Console.WriteLine("Islem basariyla tamamlandi.");
            }


        }
    }
}
