using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP
{
    public class StartClass
    {
        public static void Main(string[] args)
        {


            Random rnd = new Random();
            //string paev = "";
            //for (int i = 0; i < 10; i++)
            //{
            //    int nr = rnd.Next(1, 7);
            //    Console.WriteLine(nr);
            //    switch (nr)
            //    {
            //        case 1: paev="Esmaspäev"; break;
            //        case 2: paev="Teisipäev"; break;
            //        case 3: paev="Kolmapäev"; break;
            //        case 4: paev="Neljapäev"; break;
            //        case 5: paev="Reede"; break;
            //        case 6: paev="Laulapäev"; break;
            //        case 7: paev="Pühapäev"; break;
            //        default: paev="Viga"; break;
            //    }
            //    Console.WriteLine(paev);
            //}
            //int j = 0;
            //while (j<10)
            //{
            //    Console.WriteLine(paev);
            //    j++;
            //}
            //Console.WriteLine(j);
            //do
            //{
            //    Console.WriteLine(paev);
            //    j--;
            //} while (j!=0);
            //Console.WriteLine(j);


            //int[] lst = new int[10];
            //for (int i = 0; i < lst.Length; i++)
            //{
            //    lst[i]=rnd.Next(-100, 100); 
            //}
            //foreach (int arv in lst)
            //{
            //    if (arv<0)
            //    {
            //        Console.Beep();
            //    }
            //    Console.WriteLine(arv);
            //}

            //Console.WriteLine("Goodbye world! \nMis on sinu nimi?");
            //string name = Console.ReadLine();
            //Console.WriteLine("Tere "+name);
            //Console.WriteLine("Arv 1: ");
            //int arv1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Arv 2: ");
            //int arv2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Tehe (+ ; - ): ");
            //char tehe = char.Parse(Console.ReadLine());
            //if (tehe=='+')
            //{
            //    Console.WriteLine("Arvude {0} ja {1} summa võrdub {2}", arv1, arv2, arv1+arv2);

            //}
            //else if(tehe=='-')
            //{
            //    Console.WriteLine("Arvude {0} ja {1} vichitanie võrdub {2}", arv1, arv2, arv1-arv2);
            //}
            //else
            //{
            //    Console.WriteLine(":(");
            //}


            //Console.WriteLine("Mis on sinu nimi?");
            //string nimi = Console.ReadLine();
            //if (nimi.ToLower()=="juku")
            //{
            //    Console.WriteLine("Lähme kinno!");
            //    Console.WriteLine("Kui vana sa oled?");
            //    int age = int.Parse(Console.ReadLine());
            //    if (age<6 && age>=0)
            //    {
            //        Console.WriteLine("Tasuta");
            //    }
            //    else if (age>=6 && age<=14)
            //    {
            //        Console.WriteLine("Lastepilet");
            //    }
            //    else if (age>=15 && age<=65)
            //    {
            //        Console.WriteLine("Täispilet");
            //    }
            //    else if (age>65 && age<=100)
            //    {
            //        Console.WriteLine("Sooduspilet");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Viga andmetega");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Hea nimi!");
            //}


            //Console.WriteLine("1 inimene, mis on sinu nimi? ");
            //string nimi1 = Console.ReadLine();
            //Console.WriteLine("2 inimene, mis on sinu nimi? ");
            //string nimi2 = Console.ReadLine();
            //if (nimi1=="Artem" && nimi1=="Maksim" || nimi2=="Maksim")
            //{
            //    Console.WriteLine("{0} ja {1} nüüd on nabrid!", nimi1, nimi2);
            //}


            //Console.WriteLine("1 külg: ");
            //float k1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("2 külg: ");
            //float k2 = float.Parse(Console.ReadLine());
            //Console.WriteLine("S - {0}\nKas sa tahad tee remonti? ",k1*k2);
            //string vastus = Console.ReadLine();
            //if (vastus.ToLower()=="jah")
            //{
            //    Console.WriteLine("Kui palju maksab 1 ruutmeeter?");
            //    float rm = float.Parse(Console.ReadLine());
            //    Console.WriteLine("Remont maksab {0}",(k1*k2)*rm);
            //}
            //else
            //{
            //    Console.WriteLine("Head aega! ");
            //}


            //Console.WriteLine("Mis on soodushind?");
            //float hind = float.Parse(Console.ReadLine());
            //float sum = (hind/70)*100;
            //Console.WriteLine("hind ilma allahindluseta - {0}",sum);


            //Console.WriteLine("Mis on temperatuur?");
            //int temp = int.Parse(Console.ReadLine());
            //if (temp>18)
            //{
            //    Console.WriteLine("temperatuur on üle kaheksateistkümne kraadi ");
            //}
            //else
            //{
            //    Console.WriteLine("temperatuur ei ole üle kaheksateistkümne kraadi ");
            //}


            //Console.WriteLine("Mis on sinu pikkus?");
            //float pikk = float.Parse(Console.ReadLine());
            //if (pikk<=70 || pikk>=250)
            //{
            //    Console.WriteLine("See on vale pikkus!");
            //}
            //else if (pikk<=150)
            //{
            //    Console.WriteLine("Sa oled lühike");
            //}
            //else if (pikk<=190)
            //{
            //    Console.WriteLine("Sa oled keskmine");
            //}
            //else if (pikk<250)
            //{
            //    Console.WriteLine("Sa oled pikk!");
            //}


            //Console.WriteLine("Kas sa oled mees või naine?");
            //string pol = Console.ReadLine();
            //if (pol.ToLower()=="mees")
            //{
            //    Console.WriteLine("Mis on sinu pikkus?");
            //    float pikk = float.Parse(Console.ReadLine());
            //    if (pikk<=70 || pikk>=250)
            //    {
            //        Console.WriteLine("See on vale pikkus!");
            //    }
            //    else if (pikk<=160)
            //    {
            //        Console.WriteLine("Sa oled lühike");
            //    }
            //    else if (pikk<=190)
            //    {
            //        Console.WriteLine("Sa oled keskmine");
            //    }
            //    else if (pikk<250)
            //    {
            //        Console.WriteLine("Sa oled pikk!");
            //    }
            //}
            //else if (pol.ToLower()=="naine")
            //{
            //    Console.WriteLine("Mis on sinu pikkus?");
            //    float pikk = float.Parse(Console.ReadLine());
            //    if (pikk<=70 || pikk>=200)
            //    {
            //        Console.WriteLine("See on vale pikkus!");
            //    }
            //    else if (pikk<=120)
            //    {
            //        Console.WriteLine("Sa oled lühike");
            //    }
            //    else if (pikk<=160)
            //    {
            //        Console.WriteLine("Sa oled keskmine");
            //    }
            //    else if (pikk<200)
            //    {
            //        Console.WriteLine("Sa oled pikk!");
            //    }
            //}


            //Console.WriteLine("Kas sa tahad osta piim?");
            //string p = Console.ReadLine();
            //float hindp = 0;
            //float hinds = 0;
            //float hindl = 0;
            //if (p.ToLower()=="jah")
            //{
            //    Console.WriteLine("Kui palju maksab piim?");
            //    hindp = float.Parse(Console.ReadLine()); 
            //}
            //Console.WriteLine("Kas sa tahad osta sai?");
            //string s = Console.ReadLine();
            //if (s.ToLower()=="jah")
            //{
            //    Console.WriteLine("Kui palju maksab sai?");
            //    hinds = float.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Kas sa tahad osta leib?");
            //string l = Console.ReadLine();
            //if (l.ToLower()=="jah")
            //{
            //    Console.WriteLine("Kui palju maksab leib?");
            //    hindl = float.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Summ on - {0}",hindp+hinds+hindl);


            //int N = rnd.Next(-100, 100);
            //int M = rnd.Next(-100, 100);
            //int count = 0;
            //int m = 0;
            //int a = 0;
            //if (N>=M)
            //{
            //    count = (N - M)+1;
            //    a = N;
            //    m = M;
            //}
            //else
            //{
            //    count = (M - N)+1;
            //    a = M;
            //    m = N;
            //}
            //int[] lst = new int[count];
            //int i = 0;
            //for (int o = m; o!=a+1; o++)
            //{
            //    lst[i]=o;
            //    i++;
            //}
            //i = 0;
            //foreach (int arv in lst)
            //{
            //    Console.WriteLine("{0} - {1}", lst[i], arv*arv);
            //    i++;
            //}


            //int[] lst = new int[5];
            //int arv = 0;
            //float sum = 0;
            //int proiz = 1;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("\n{0} arv =", i+1);
            //    arv = int.Parse(Console.ReadLine());
            //    lst[i]=arv;
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    sum+=lst[i];
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    proiz*=lst[i];
            //}
            //float arke = sum/5;
            //Console.WriteLine("\nSumm - {0}\nAritmeetiline keskmine - {1}\nKorrutis - {2}", sum, arke,proiz);


            //string vastus = "";
            //do
            //{
            //    Console.WriteLine("Osta elevant ära!");
            //    vastus = Console.ReadLine();
            //} while (vastus!="elevant");


            //int arv = rnd.Next(1, 10);
            //int parv = 0;
            //int i = 0;
            //Console.WriteLine(arv);
            //for (i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Kirjuta arv (1-10)");
            //    parv = int.Parse(Console.ReadLine());
            //    if (parv == arv)
            //    {
            //        Console.WriteLine("See on õige");
            //        break;
            //    }
            //}
            //if (i==5 && parv!=arv)
            //{
            //    Console.WriteLine("Sa kaotasid!");
            //}


            //int[] lst = new int[4];
            //int arv = 0;
            //int c1 = 0;
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Kirjuta {0} arv", i + 1);
            //    do
            //    {
            //        arv = int.Parse(Console.ReadLine());
            //        string c = arv.ToString();
            //        c1 = c.Length;
            //    } while (c1 > 1);
            //    lst[i] = arv;
            //}
            //Array.Sort(lst);
            //Array.Reverse(lst);
            //string vastus = "";
            //foreach (int item in lst)
            //{
            //    string num = item.ToString();
            //    vastus += num;
            //}
            //Console.WriteLine("\n" + vastus);


            for (int i = 1; i < 11; i++)
            {
                for (int i1 = 1; i1 < 11; i1++)
                {
                    Console.Write(i*i1+" ");
                }
                Console.WriteLine();
            }


        }
    }
}
