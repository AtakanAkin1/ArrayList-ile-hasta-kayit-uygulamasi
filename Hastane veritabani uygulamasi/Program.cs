using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hastane_veritabani_uygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int KullaniciHakki = 2;
            while (KullaniciHakki>=0)
            {
                Console.Clear();
                Console.Write("Kullanici Adi: ");
                string kullaniciAdi = Console.ReadLine();
                Console.Write("Sifre: ");
                string sifre = Console.ReadLine();

                if(kullaniciAdi.ToLower()=="admin"&&sifre.ToLower()=="1234")
                {
                    ArrayList Hastane = new ArrayList();
                    string secim;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("1-Hasta Kayit");
                        Console.WriteLine("2-Hasta Sorgulama");
                        Console.WriteLine("3-Hasta Silme");
                        Console.WriteLine("4-Hasta Listesi");
                        Console.WriteLine("5-Hasta Guncelleme");
                        Console.WriteLine("6-Sistem Cikisi");
                        Console.Write("Isleminizi seciniz: ");
                        secim = Console.ReadLine();
                        
                        switch (secim)
                        {
                            case "1":
                                string eh;
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("Hasta Adi ve soyadi: ");
                                    string AdSoyad = Console.ReadLine();
                                    Hastane.Add(AdSoyad);
                                    Console.Write("Hasta bilgisi eklendi devam etmek istiyor musunuz(E/H): ");
                                    eh = Console.ReadLine();
                                } while (eh.ToUpper()=="E");
                                break;
                            case "2":
                                string eh2;
                                do
                                {
                                    Console.Clear();
                                    Console.Write("Hasta bilgilerini giriniz: ");
                                    string HastaB = Console.ReadLine();
                                    if (Hastane.Contains(HastaB))
                                    {
                                        string HastaI = Hastane.IndexOf(HastaB).ToString();
                                        Console.WriteLine("{0} bilgisine sahip hasta {1}. id numarasi ile listede bulunmaktadir.", HastaB, HastaI);
                                    }
                                    else
                                    {
                                        Console.WriteLine("{0} bilgilerine sahip hasta listede bulunmamaktadir.Hastayi listeye eklemek icin hasta kayit menusune giris yapiniz.",HastaB);
                                    }
                                    Console.Write("Hasta aramaya devam etmek istiyor musunuz(E/H): ");
                                    eh2 = Console.ReadLine();
                                } while (eh2.ToUpper()=="E");
                                break;
                            case "3":
                                string eh3;
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("Not: Hastanin bilgilerini id numarasina gore silebilirsiniz. ");
                                    Console.Write("Hastanin id numarasini ogrenmek icin hasta adi ve soyadi giriniz: ");
                                    string indexO = Console.ReadLine();
                                    if (Hastane.Contains(indexO))
                                    {
                                        string indexo = Hastane.IndexOf(indexO).ToString();
                                        Console.WriteLine("{0} bilgilerine sahip hasta {1} id numarasina sahiptir.", indexO, indexo);
                                        Console.Write("Silmek istediginiz hastanin id numarasini giriniz: ");
                                        int sil = Convert.ToInt32(Console.ReadLine());
                                        Hastane.RemoveAt(sil);
                                        Console.WriteLine("Hasta basariyla silindi.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("{0} bilgilerine sahip hasta listede bulunmamaktadir.Hastayi listeye eklemek icin hasta kayit menusune giris yapiniz.", indexO);
                                    }
                                    Console.Write("Hasta silmeye devam etmek istiyor musunuz(E/H): ");
                                    eh3 = Console.ReadLine();
                                } while (eh3.ToUpper()=="E");
                                break;
                            case "4":
                                Console.Clear();
                                Console.WriteLine("VeriTabanin'da bulunan hastalar listeleniyor...");
                                System.Threading.Thread.Sleep(2000);
                                for(int a=0; a<Hastane.Count; a++)
                                {
                                    Console.Write("* ");
                                    Console.WriteLine(Hastane[a]);
                                }
                                Console.WriteLine("Hastalar listelendi cikis yapmak icin ENTER tusuna basiniz.");
                                Console.ReadLine();
                                break;
                            case "5":
                                string eh4;
                                do
                                {
                                    Console.Clear();
                                    Console.Write("Lutfen listede bulunan hastanin adini ve soyadini giriniz: ");
                                    string guncelle = Console.ReadLine();
                                    if (Hastane.Contains(guncelle))
                                    {
                                        Console.Write("{0} hastanin yerine Guncellenecek adi ve soyadi giriniz: ");
                                        string yeniGuncelle = Console.ReadLine();

                                        int indexGuncelle = Hastane.IndexOf(guncelle);
                                        Hastane[indexGuncelle] = yeniGuncelle;
                                        Console.Clear();
                                        Console.WriteLine("Hasta guncelleniyor lutfen bekleyiniz.");
                                        System.Threading.Thread.Sleep(2000);
                                        Console.WriteLine("Hasta basariyla guncellenmistir...");
                                        Console.WriteLine("Devam etmek icin ENTER tusuna basiniz.");
                                        Console.ReadLine();
                                    }
                                    else
                                    {
                                        Console.WriteLine("{0} bilgilerine sahip hasta listede bulunmamaktadir.Hastayi listeye eklemek icin hasta kayit menusune giris yapiniz.", guncelle);
                                    }
                                    Console.WriteLine("Hasta guncellemeye devam etmek istiyor musunuz(E/H): ");
                                    eh4 = Console.ReadLine();
                                } while (eh4.ToUpper()=="E");
                                break;
                            case "6":
                                Console.Clear();
                                Console.WriteLine("Cikis yapiliyor.Lutfen bekleyiniz.");
                                System.Threading.Thread.Sleep(2000);
                                Console.WriteLine("Cikis yapildi ENTER tusuna basarak programi kapatiniz.");
                                break;
                            default:
                                Console.WriteLine("Lutfen gecerli bir tuslama yapiniz.");
                                break;

                                
                        }
                    } while (secim!="6");
                    break;
                   
                }
                else
                {
                    if (KullaniciHakki == 0)
                    {
                        Console.WriteLine("Cok fazla hatali giris yaptiniz.Lutfen daha sonra tekrar deneyiniz.");
                        System.Threading.Thread.Sleep(2000);
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine("Kullanici Adi veya sifreyi hatali girdiniz.Lutfen tekrar deneyiniz.");
                    KullaniciHakki--;
                    Console.WriteLine("Devam etmek icin ENTER tusuna basiniz.");
                    Console.ReadLine();
                }
                
                
            }
            Console.ReadKey();
        }
    }
}
