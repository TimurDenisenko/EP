using System;
using System.Collections;
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
            //string vas = Console.ReadLine();
            //float hindp = 0;
            //float hinds = 0;
            //float hindl = 0;
            //if (vas.ToLower()=="jah")
            //{
            //    Console.WriteLine("Kui palju maksab piim?");
            //    hindp = float.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Kas sa tahad osta sai?");
            //vas = Console.ReadLine();
            //if (vas.ToLower()=="jah")
            //{
            //    Console.WriteLine("Kui palju maksab sai?");
            //    hinds = float.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Kas sa tahad osta leib?");
            //vas = Console.ReadLine();
            //if (vas.ToLower()=="jah")
            //{
            //    Console.WriteLine("Kui palju maksab leib?");
            //    hindl = float.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Summ on - {0}", hindp+hinds+hindl);


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
            //Console.WriteLine("\n{0}", Convert.ToInt32(vastus));


            //for (int i = 1; i < 11; i++)
            //{
            //    for (int i1 = 1; i1 < 11; i1++)
            //    {
            //        Console.Write(i*i1+" ");
            //    }
            //    Console.WriteLine();
            //}


            //string name = "T";
            //AlamClass.Tere(name);


            //int arv1 = 9;
            //int arv2 = 3;
            //int c = AlamClass.Korruta(arv1,arv2);
            //Console.WriteLine(c);
            //Console.WriteLine(AlamClass.Korruta(9, 3));

            //Console.Write("N = ");
            //int length = Convert.ToInt32(Console.ReadLine());
            //int num=AlamClass.Middle(length);
            //Console.WriteLine(num);

            //AlamClass.Nurr(4,2, "+");


            //Console.WriteLine(AlamClass.Stars(20));


            //AlamClass.NStars();


            //ArrayList lst = new ArrayList();
            //lst.Add("Esimene");
            //lst.Add("Teine");
            //lst.Add("Kolmas");
            //if (lst.Contains("Teine"))
            //{
            //    Console.WriteLine(true);
            //    Console.WriteLine("Asub kohal {0}",lst.IndexOf("Esimene")+1);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}
            //Console.WriteLine("Kokku järjenids on {0} elemente",lst.Count);
            //lst.Insert(3, "Neljas");
            //lst.Insert(4, "Viies");
            //lst.RemoveAt(0);
            //lst.Remove("Viies");
            //lst.Sort();
            //foreach (string i in lst)
            //{
            //    Console.Write("{0}, ",i);   
            //}
            //Console.WriteLine();


            //List<Inimene> list = new List<Inimene>();
            //Inimene inimene = new Inimene();
            //inimene.Nimi="Andrei";
            //inimene.Vanus=37;
            //list.Add(inimene);
            //list.Add(new Inimene() {Vanus=29, Nimi="Luka"} );
            //foreach (Inimene i in list )
            //{
            //    Console.WriteLine("{0} {1}",i.Nimi,i.Vanus);
            //}


            //Dictionary<int, string> dic = new Dictionary<int, string>(5);
            //dic.Add(1,"üks");
            //dic.Add(2, "kaks");
            //dic[3]="kolm";
            //dic[4]="neli";
            //dic[5]="viis";
            //foreach (KeyValuePair<int,string> keyValue in dic)
            //{
            //    Console.WriteLine("{0} {1}",keyValue.Key,keyValue.Value);
            //}


            //Dictionary<int,Inimene> dic = new Dictionary<int, Inimene>(5);
            //dic.Add(1, new Inimene() {Nimi="Andrei",Vanus=37 });
            //Inimene inimene = new Inimene();
            //inimene.Nimi= "Nikolai";
            //inimene.Vanus = 20;
            //Inimene inimene1 = new Inimene();
            //inimene1.Nimi = "Aleksander";
            //inimene1.Vanus = 10;
            //dic.Add(2,inimene);
            //dic[4]=inimene1;
            //foreach (KeyValuePair<int,Inimene> i in dic)
            //{
            //    Console.WriteLine("{0} - {1}.{2}",i.Key,i.Value.Nimi,i.Value.Vanus);
            //}


            //ConsoleKeyInfo nupp = new ConsoleKeyInfo();
            //do
            //{
            //    Console.WriteLine("Vajuta Backspace");
            //    nupp=Console.ReadKey();
            //} while (nupp.Key!=ConsoleKey.Backspace);


            //try
            //{
            //    StreamWriter text = new StreamWriter(@"..\..\..\TextFile.txt",true);
            //    string lause = "Lisa failisse lause";
            //    text.WriteLine(lause);
            //    text.Close();
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Viga!");
            //}
            //try
            //{
            //    StreamReader text = new StreamReader(@"..\..\..\TextFile.txt");
            //    ArrayList list = new ArrayList();
            //    string laused = "";
            //    while (laused!=null)
            //    {
            //        laused = text.ReadLine();
            //        list.Add(laused);
            //    }
            //    text.Close();
            //    foreach (string item in list)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Viga!");
            //}


            StreamReader text = new StreamReader(@"..\..\..\maakond.txt");
            Dictionary<string, string> mali = new Dictionary<string, string>();
            string laused = "";
            string[] t = new string[2];

            while (laused!=null)
            {
                laused = text.ReadLine();
                if (laused!=null)
                t = laused.Split("-");
                mali[t[0]] = t[1];
            }
            text.Close();

            foreach (KeyValuePair<string,string> item in mali)
            {
                Console.WriteLine("{0}-{1}",item.Key,item.Value);
            }
        }
    }
}
