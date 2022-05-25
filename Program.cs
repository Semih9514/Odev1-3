using System;

namespace Odev1_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
           Console.Write("Kaç tane kelime gireceksiniz:");
           int sayi = Int32.Parse(Console.ReadLine());
           string[] dizi = new string[sayi];
           Console.WriteLine("---------------------------------");
           for (int i = 0; i < sayi; i++)
           {
               Console.Write("{0}. Kelime Giriniz:",i+1);
               dizi[i]=Console.ReadLine();
           }
           Console.WriteLine("---------------------------------");
           Console.WriteLine("Kelimelerin Ters Çevrilmiş Halleri");
           Console.WriteLine("---------------------------------");
           foreach (var item in dizi)
           {
               for (int i = item.Length; i >0; i--)
               {
                   Console.Write(item.Substring(i-1, 1).ToString());
               }
               Console.WriteLine();
           }
        }
    }
}
