using System;

namespace YanacaqDoldurma
{
    class Program
    {
        static void Main(string[] args)
        {
            double benzin = 1, dizel = 0.80, lpg = 0.60;
            double benzinceni = 1000, dizelceni = 1000, lpgceni = 1000;
            double satismiqdari = 0;
            char anamenu_secim = '0', altmenu_secim = '0', yanacaqQiymetGuncel = '0', yanacaqsatisTipi = '0';
            //MeNu hissesi;
            MENU:
            Console.WriteLine("YANACAQ SATIS TIPI");
            Console.WriteLine(">>>>>>>>>><<<<<<<<<<<");
            Console.WriteLine("1-Qiymet Vahidini Goster");
            Console.WriteLine("2-Qiymet Vahidini Guncelle");
            Console.WriteLine("3-Yanacaq Satisi Et");
            Console.WriteLine("4-Yanacaq Cenini Kontrol et");
            Console.WriteLine("5-Toplam Satislari goster");
            Console.WriteLine("6-Cixis et");
            Console.WriteLine("************************************");
            Console.Write("Seciminizi edin-->[1;2;3;4;5;6]");
            anamenu_secim = Convert.ToChar(Console.ReadLine());
            if (anamenu_secim == '1')
            {
                Console.Clear();
                Console.WriteLine("Seciminiz: 1 <");
                Console.WriteLine("--Qiymetler Listi--");
                Console.WriteLine("Dizel (D) :{0} Azn/Litr", dizel);
                Console.WriteLine("Benzin (B) :{0} Azn/Litr", benzin);
                Console.WriteLine("Lpg (L) :{0} Azn/Litr", lpg);
                Alt_Menu:
                Console.WriteLine("Secim edin: < 1 AnaMenuya Qayit > < 2 Programi Bagla > : ");
                altmenu_secim = Convert.ToChar(Console.ReadLine());
                if (altmenu_secim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenu_secim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Xais edirik '1' ve '2' seciminden basqasini secmeyin.");
                    goto Alt_Menu;
                }
            }
            else if (anamenu_secim == '2')
            {
                Console.WriteLine("< Seciminiz '2' >");
                Console.WriteLine(" < Qiymet vahid Guncelle > ");
                yanacaqTipi:
                Console.WriteLine("Yanacaq Tipini seci ( D, B, L )");
                yanacaqQiymetGuncel = Convert.ToChar(Console.ReadLine());
                if (yanacaqQiymetGuncel == 'D' || yanacaqQiymetGuncel == 'd')
                {
                    Console.WriteLine("Dizel (D) :{0} Azn/Litr", dizel);
                    Console.Write("Dizel yanacagi ucun yeni qiymeti qeyd edin");
                    dizel = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Yeni deyisiklik edildi");
                    Console.WriteLine("Dizel (D) :{0} Azn/Litr", dizel);
                }
                else if (yanacaqQiymetGuncel == 'B' || yanacaqQiymetGuncel == 'b')
                {
                    Console.WriteLine("Benzin (B) :{0} Azn/Litr", benzin);
                    Console.Write("Benzin yanacagi ucun yeni qiymeti qeyd edin");
                    benzin = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Yeni deyisiklik edildi");
                    Console.WriteLine("benzin (b) :{0} Azn/Litr", benzin);
                }
                else if (yanacaqQiymetGuncel == 'L' || yanacaqQiymetGuncel == 'l')
                {
                    Console.WriteLine("Lpg (L) :{0} Azn/Litr", lpg);
                    Console.Write("Lpg yanacagi ucun yeni qiymeti qeyd edin");
                    lpg = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Yeni deyisiklik edildi");
                    Console.WriteLine("Lpg (L) :{0} Azn/Litr", lpg);
                }
                else
                {
                    Console.WriteLine("Xais edirik (D, B, L) bunlardan basqa  bir scim etmeyin");
                    goto yanacaqTipi;
                }
                Alt_Menu:
                Console.WriteLine("Secim edin: < 1 AnaMenuya Qayit > < 2 Programi Bagla > : ");
                altmenu_secim = Convert.ToChar(Console.ReadLine());
                if (altmenu_secim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenu_secim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Xais edirik '1' ve '2' seciminden basqasini secmeyin.");
                    goto Alt_Menu;
                }
            }
            else if (anamenu_secim == '3')
            {
                Console.Clear();
                Console.WriteLine("Yanacaq satis secimi");
                yanacaqsatisTipi:
                Console.WriteLine("yanacaq tipini secin D, B, L");
                yanacaqsatisTipi = Convert.ToChar(Console.ReadLine());
                if (yanacaqsatisTipi == 'D' || yanacaqsatisTipi == 'd')
                {
                    if (dizelceni == 0)
                    {
                        Console.WriteLine(" Cen bosdur");
                        goto MENU;
                    }
                    else
                    {
                        Console.WriteLine("Ne qeder Yanacaq alacaqsiz qeyd edin:");
                        satismiqdari = Convert.ToDouble(Console.ReadLine());
                        if (dizelceni < satismiqdari)
                        {
                            Console.WriteLine("Cende bu qeder yanacaq vardir {0}, Operasiya edilmedi", dizelceni);
                            goto MENU;
                        }
                        else if (satismiqdari <= dizelceni)
                        {
                            dizelceni = dizelceni - satismiqdari;
                            Console.WriteLine(" Operasiya basa catdi ");
                            Console.WriteLine(" Cende bu qeder yanacaq qaldi {0}", dizelceni);
                        }
                    }
                }
                else if (yanacaqsatisTipi == 'B' || yanacaqsatisTipi == 'b')
                {
                    if (benzinceni == 0)
                    {
                        Console.WriteLine(" Cen bosdur");
                        goto MENU;
                    }
                    else
                    {
                        Console.WriteLine("Ne qeder Yanacaq alacaqsiz qeyd edin:");
                        satismiqdari = Convert.ToDouble(Console.ReadLine());
                        if (benzinceni < satismiqdari)
                        {
                            Console.WriteLine("Cende bu qeder yanacaq vardir {0}, Operasiya edilmedi", benzinceni);
                            goto MENU;
                        }
                        else if (satismiqdari <= benzinceni)
                        {
                            benzinceni = benzinceni - satismiqdari;
                            Console.WriteLine(" Operasiya basa catdi ");
                            Console.WriteLine(" Cende bu qeder yanacaq qaldi {0}", benzinceni);
                        }
                    }
                }
                else if (yanacaqsatisTipi == 'L' || yanacaqsatisTipi == 'l')
                {
                    if (lpgceni == 0)
                    {
                        Console.WriteLine(" Cen bosdur");
                        goto MENU;
                    }
                    else
                    {
                        Console.WriteLine("Ne qeder Yanacaq alacaqsiz qeyd edin:");
                        satismiqdari = Convert.ToDouble(Console.ReadLine());
                        if (lpgceni < satismiqdari)
                        {
                            Console.WriteLine("Cende bu qeder yanacaq vardir {0}, Operasiya edilmedi", lpgceni);
                            goto MENU;
                        }
                        else if (satismiqdari <= lpgceni)
                        {
                            lpgceni = lpgceni - satismiqdari;
                            Console.WriteLine(" Operasiya basa catdi ");
                            Console.WriteLine(" Cende bu qeder yanacaq qaldi {0}", lpgceni);
                        }
                    }
                }
                else
                {
                    Console.WriteLine(" Xais edirik D, B, L den basqa seci etmeyin yoxsa sehf olur");
                    goto yanacaqsatisTipi;
                }
                Alt_Menu:
                Console.WriteLine("Secim edin: < 1 AnaMenuya Qayit > < 2 Programi Bagla > : ");
                altmenu_secim = Convert.ToChar(Console.ReadLine());
                if (altmenu_secim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenu_secim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Xais edirik '1' ve '2' seciminden basqasini secmeyin.");
                    goto Alt_Menu;
                }
            }
            else if (anamenu_secim =='4')
            {
                Console.Clear();
                Console.WriteLine("4- secimini etdiniz");
                Console.WriteLine("Yanacaq ceni kontrolu");
                Console.WriteLine(" Dizel Ceninde bu %{0} qeder yanacaq qalib", (dizelceni / 10));
                Console.WriteLine(" Benzin Ceninde bu %{0} qeder yanacaq qalib", (benzinceni / 10));
                Console.WriteLine(" Lpg Ceninde bu %{0} qeder yanacaq qalib", (lpgceni / 10));
                Alt_Menu:
                Console.WriteLine("Secim edin: < 1 AnaMenuya Qayit > < 2 Programi Bagla > : ");
                altmenu_secim = Convert.ToChar(Console.ReadLine());
                if (altmenu_secim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenu_secim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Xais edirik '1' ve '2' seciminden basqasini secmeyin.");
                    goto Alt_Menu;
                }
            }
            else if (anamenu_secim=='5')
            {
                Console.Clear();
                Console.WriteLine("Toplam satis tutarlari");
                Console.WriteLine(" Toplam Dizel ucun yanacaq tutari {0}", 1000-dizelceni);
                Console.WriteLine(" Dizel ucun yanacaq tutari {0}", (1000 - dizelceni)*dizel);
                Console.WriteLine(" Toplam Benzin ucun yanacaq tutari {0}", 1000 - benzinceni);
                Console.WriteLine(" Benzin ucun yanacaq tutari {0}", (1000 - benzinceni) * benzin);
                Console.WriteLine(" Toplam Lpg ucun yanacaq tutari {0}", 1000 - lpgceni);
                Console.WriteLine(" Lpg ucun yanacaq tutari {0}", (1000 - lpgceni) * lpg);
                Console.WriteLine("__________________________________________");
                Console.WriteLine("Toplam Yanacaq Tutar Qiymeti{0}",((1000 - dizelceni) * dizel)+ ((1000 - benzinceni) * benzin)+ ((1000 - lpgceni) * lpg));
                Alt_Menu:
                Console.WriteLine("Secim edin: < 1 AnaMenuya Qayit > < 2 Programi Bagla > : ");
                altmenu_secim = Convert.ToChar(Console.ReadLine());
                if (altmenu_secim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenu_secim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Xais edirik '1' ve '2' seciminden basqasini secmeyin.");
                    goto Alt_Menu;
                }

            }
            else if (anamenu_secim=='6')
            {
                Environment.Exit(0);
            }
        }
    }
}
