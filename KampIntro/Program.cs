﻿internal class Program
{
    private static void Main(string[] args)
    {
        string kategoriEtiketi = "Kategori";
        int ogrenciSayisi = 32000;
        double faizOrani = 1.45;
        bool sistemeGirisYapmisMi = false;
        double dolarDun = 7.35;
        double dolarBugun = 7.45;

        if (dolarDun>dolarBugun)
        {
            Console.WriteLine("Azalış butonu");
        }
        else if (dolarDun<dolarBugun)
        {
            Console.WriteLine("Artış butonu");
        }
        else
        {
            Console.WriteLine("Değişmedi butonu");
        }

        if (sistemeGirisYapmisMi == true) 
        {
            Console.WriteLine("Kullancı ayarları butonu");
        }
        else
        {
            Console.WriteLine("Giriş yap butonu");
        }

        //Console.WriteLine(kategoriEtiketi);
    }
}