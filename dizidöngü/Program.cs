// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // 5 sayı için dizi oluşturuluyor
        int[] sayilar = new int[5];
        int toplam = 0;

        // Kullanıcıdan 5 sayı girmesi isteniyor
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Lütfen {i + 1}. sayıyı girin: ");
            sayilar[i] = int.Parse(Console.ReadLine());  // Girilen sayıyı diziye ekliyoruz
        }

        // Döngü ile tüm sayılar toplanıyor
        foreach (int sayi in sayilar)
        {
            toplam += sayi;
        }

        // Ortalama hesaplanıyor
        double ortalama = toplam / 5.0;

        // Sonuç ekrana yazdırılıyor
        Console.WriteLine($"Girdiğiniz sayıların ortalaması: {ortalama}");
    }
}
