using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KitaplikProjesi
{
    /// <summary>
    /// Proje detayı
    /// </summary>
    /// Projemizde yerli ve yabancı olmak üzere 2 kategoriden oluşan kitap listesi bulunacak.
    /// Sistemi kullanan öğrenci kitap listesini görebilicek, yazarlar ile ilgili bilgi alabilicek.
    /// Öğrenci sistem üzerinden kitap alabilicek.
    /// Kendi bilgilerini sisteme kaydedebilicek.

    internal class Program
    {
        static void Main(string[] args)
        {
            int topfiyat = 0;
            string secim;
            #region Kategorilenmiş kitap tablosu
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("***  Türkçe Kitaplar Kategorisi       ***  Yabancı Kitaplar Kategorisi   ***");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("***  1-Çalıkuşu: Reşat Nuri Güntekin  ***  11-Tuna Kılavuzu: Jules Verne ***");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("***  2-Kuyucaklı:Yusuf Sabahattin Ali ***  12-Olasılıksız: Adam Fawer    ***");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("***  3-Kırk Güzeller Çeşmesi:İskender ***  13-Yetenek: Kristin Cashore   ***");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("***  4-Suç ve Ceza: Hasan Ali Yücel   ***  14:Ateş: Kristin Cashore      ***");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("***  5-Aşkın Sanal Halleri:Canan TAN  ***  15-Sır:Kristin Cashore        ***");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("***  6-Kiralık Konak: Yakup Kadri     ***  16-Şeker Portakalı:Jose Mauro ***");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("***  7-Ateşten Gömlek: Halide Edip    ***  17-Simyacı: Paulo Coelho      ***");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("***  8-İnanç: Falih Rıfkı Atay        ***  18-Yabancı: Albert Camus      ***");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("***  9-Huzur: Ahmet Hamdi Tanpınar    ***  19-Büyük Yalnızlık: Kristin   ***");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("***  10-Aydaki Kadın: Ahmet Hamdi     ***  20-Çirkin Aşk: Colleen Hoover ***");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine();
            Console.WriteLine();
            #endregion
            #region İşlem numraları
            Console.WriteLine("***************************** İşlemler Menüsü ******************************");
            Console.WriteLine();
            Console.WriteLine("1-Fiyat Sorgulama");
            Console.WriteLine("2-Yeni Okur");
            Console.WriteLine("3-Günün Kitabı");
            Console.WriteLine("4-Kitap Arşivi");
            Console.WriteLine("5-Kitap Satın Alma");
            Console.WriteLine("6-Oyun");
            Console.WriteLine();
            Console.Write("Lütfen Yapmak İstediğniz İşlem Numarasını Giriniz: ");
            #endregion
            char islem;
            islem = Convert.ToChar(Console.ReadLine());
            #region Fiyat sorgulama 
            if (islem == '1')

            {
                Console.WriteLine();
                Console.Write("Lütfen fiyatını öğrenmek istediğniz kitabın numarasını girin: ");

                string numara;
                numara = Console.ReadLine();
                Console.WriteLine("***** Öğrenmek İstediğiniz Kitabın Ücreti *****");
                switch (numara)
                {

                    case "1": Console.Write("Çalıkuşu: 12 TL"); break;
                    case "2": Console.Write("Kuyucaklı: 20 TL"); break;
                    case "3": Console.Write("Kırk Güzeller Çeşmesi: 18 TL"); break;
                    case "4": Console.Write("Suç ve Ceza: 30 TL"); break;
                    case "5": Console.Write("Aşkın Sanal Halleri: 20 TL"); break;
                    case "6": Console.Write("Kiralık Konak: 22 TL"); break;
                    case "7": Console.Write("Ateşten Gömlek: 20 TL"); break;
                    case "8": Console.Write("İnanç: 11 TL"); break;
                    case "9": Console.Write("Huzur: 25 TL"); break;
                    case "10": Console.Write("Aydaki Kadın: 55 TL"); break;
                    case "11": Console.Write("Tuna Kılavuzu: 60 TL"); break;
                    case "12": Console.Write("Olasılıksız: 29 TL"); break;
                    case "13": Console.Write("Yetenek: 44 TL"); break;
                    case "14": Console.Write("Ateş: 39 TL"); break;
                    case "15": Console.Write("Sır: 50 TL"); break;
                    case "16": Console.Write("Şeker Portakalı: 9 TL"); break;
                    case "17": Console.Write("Simyacı: 50 TL"); break;
                    case "18": Console.Write("Yabancı: 30 TL"); break;
                    case "19": Console.Write("Büyük Yalnızlık: 28 TL"); break;
                    case "20": Console.Write("Çirkin Aşk: 40 TL"); break;
                }
            }
            #endregion
            #region Yeni okur kaydı
            if (islem == '2')
            {
                Console.WriteLine("***** Yeni Okur Kaydı *****");
                string ad, soyad, universite;
                Console.Write("Adınız: ");
                ad = Console.ReadLine();
                Console.Write("Soyanınız: ");
                soyad = Console.ReadLine();
                Console.Write("Üniversiteniz: ");
                universite = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Kaydı Oluşturucağımız Kullanıcı Bilgileri" + ad + soyad + universite);

                string dosya = @"C:\Users\LENOVO\Desktop\KitapProje\KitapProje.txt";
                StreamWriter sw = new StreamWriter(dosya);
                sw.WriteLine("Adınız: " + ad);
                sw.WriteLine("Soyadınız: " + soyad);
                sw.WriteLine("Üniversiteniz " + universite);
                sw.Close();

            }
            #endregion
            #region Günün kitabı
            if (islem == '3')
            {
                Console.WriteLine();
                Console.WriteLine("*************************************");
                Console.WriteLine();
                Console.WriteLine("***** Bugunün Kitabı: Çalıkuşu *****");
                Console.WriteLine();
                Console.WriteLine("************************************");
            }
            #endregion
            #region Kitap Arşivi
            if (islem == '4')
            {
                Console.WriteLine();
                Console.WriteLine("********* İslem Kitap Arşiv *********");
                Console.WriteLine();
                Console.WriteLine("*************************************");
                Console.WriteLine();
                //burası kitap arşiv
                FileStream fs = new FileStream(@"C:\Users\LENOVO\Desktop\KitapProje\Arşiv.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string metin = sr.ReadLine();
                while (metin != null)
                {
                    Console.WriteLine(metin);
                    metin = sr.ReadLine();
                }
                sr.Close();
                Console.WriteLine();
                Console.WriteLine("*************************************");
                Console.WriteLine();

            }
            #endregion
            #region Kitap satın alma
            if (islem == '5')
            {
                Console.WriteLine();
                Console.WriteLine("İslem Kitap Satın Alma");
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine();
                    Console.Write("Alacağınız Kitabın Numarası: ");
                    secim = Console.ReadLine();
                    if (secim == "1")
                    {
                        topfiyat = topfiyat + 12;

                    }
                    else if (secim == "2")
                    {
                        topfiyat = topfiyat + 20;
                    }
                    else if (secim == "3")
                    {
                        topfiyat = topfiyat + 18;

                    }
                    else if (secim == "4")
                    {
                        topfiyat = topfiyat + 30;
                    }
                    else if (secim == "5")
                    {
                        topfiyat = topfiyat + 20;
                    }
                    else if (secim == "6")
                    {
                        topfiyat = topfiyat + 22;
                    }
                    else if (secim == "7")
                    {
                        topfiyat = topfiyat + 20;
                    }
                    else if (secim == "8")
                    {
                        topfiyat = topfiyat + 11;
                    }
                    else if (secim == "9")
                    {
                        topfiyat = topfiyat + 25;
                    }
                    else if (secim == "10")
                    {
                        topfiyat = topfiyat + 55;
                    }
                    else if (secim == "11")
                    {
                        topfiyat = topfiyat + 60;
                    }
                    else if (secim == "12")
                    {
                        topfiyat = topfiyat + 29;
                    }
                    else if (secim == "13")
                    {
                        topfiyat = topfiyat + 44;
                    }
                    else if (secim == "14")
                    {
                        topfiyat = topfiyat + 39;
                    }
                    else if (secim == "15")
                    {
                        topfiyat = topfiyat + 50;
                    }
                    else if (secim == "16")
                    {
                        topfiyat = topfiyat + 9;
                    }
                    else if (secim == "17")
                    {
                        topfiyat = topfiyat + 50;
                    }
                    else if (secim == "18")
                    {
                        topfiyat = topfiyat + 30;
                    }
                    else if (secim == "19")
                    {
                        topfiyat = topfiyat + 28;
                    }
                    else if (secim == "20")
                    {
                        topfiyat = topfiyat + 40;
                    }
                    else
                    
                        Console.WriteLine("Böyle bir kitap numarası yok...");
                        Console.WriteLine();
                        Console.WriteLine("Başka bir kitap almak ister misiniz? ");
                        string cevap=Console.ReadLine();    
                   
                        if  (cevap == "h" || cevap =="H" || cevap =="hayır" || cevap=="HAYIR")
                        {
                            break;
                        }
                    
                }
                Console.WriteLine("Toplam Tutar: "+topfiyat);
            }
            #endregion
            #region Oyun
            if (islem == '6')
            {
                Console.WriteLine();
                Console.WriteLine("***** Tahmin Oyunu *****");
                Console.WriteLine();
                int tahmin = 0;
                Random rnd = new Random();
                int sayi=rnd.Next(1,100);
                while(sayi !=tahmin)
                {
                    Console.Write("Tahmin sayı değeriniz kaç: ");
                    tahmin=Convert.ToInt16(Console.ReadLine()); 
                    if(tahmin<sayi)
                    {
                        Console.WriteLine("Daha Büyük");
                    }
                    if(tahmin>sayi)
                    {
                        Console.WriteLine("Daha Küçük");
                    }
                    if(tahmin==sayi)
                    {
                        Console.WriteLine("Tebrikler Bildiniz");
                        break;
                    }
                }
            }
            #endregion
            Console.Read();
        }
    }
}



