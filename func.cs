using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EP
{
    public class func
    {
        public static Dictionary<string, string> FTLlm(string file)
        {
            StreamReader text = new StreamReader(file);
            Dictionary<string, string> lima = new Dictionary<string, string>();
            string laused = "";
            string[] t = new string[2];
            while ((laused = text.ReadLine()) != null)
            {
                t = laused.Split("-");
                lima[t[0]] = t[1];
            }
            text.Close();
            return lima;
        }

        public static Dictionary<string, string> FTLml(string file)
        {
            StreamReader text = new StreamReader(file);
            Dictionary<string, string> mali = new Dictionary<string, string>();
            string laused = "";
            string[] t = new string[2];
            while ((laused = text.ReadLine()) != null)
            {
                t = laused.Split("-");
                mali[t[1]] = t[0];
            }
            text.Close();
            return mali;
        }


        public static void Otsi(Dictionary<string, string> mali, Dictionary<string, string> lima)
        {
            Console.WriteLine("Mida sa otsid?");
            string sona = Console.ReadLine();
            if (mali.ContainsKey(sona))
            {
                Console.WriteLine(mali[sona]);
            }
            else if (lima.ContainsKey(sona))
            {
                Console.WriteLine(lima[sona]);
            }
            else
            {
                Console.WriteLine("Seda objekti pole olemas, kas soovite selle lisada?");
                string vali = Console.ReadLine();
                if (vali.ToLower()=="jah")
                {
                    Lisa(lima, mali);
                }
            }
        }


        public static void LTF(Dictionary<string, string> lima, string file)
        {
            StreamWriter text = new StreamWriter(file);
            string str = "";
            foreach (KeyValuePair<string, string> item in lima)
            {
                str=str + item.Key+"-"+item.Value+"\n";
            }
            text.Write(str);
            text.Close();
        }


        public static void Lisa(Dictionary<string, string> lima, Dictionary<string, string> mali)
        {
            string maakond = "";
            string linna = "";
            do
            {
                Console.WriteLine("Kirjuta uus maakond");
                maakond = Console.ReadLine();
            } while (mali.ContainsKey(maakond) != false || lima.ContainsKey(maakond) != false);
            do
            {
                Console.WriteLine("Kirjuta uus linna");
                linna = Console.ReadLine();
            } while (lima.ContainsKey(linna) != false && mali.ContainsKey(linna) != false);
            lima[linna] = maakond;
            LTF(lima, @"..\..\..\maakond.txt");
        }


        public static void Train(Dictionary<string, string> lima, Dictionary<string, string> mali)
        {
            Random rnd = new Random();
            string vastus = "";
            string sona = "";
            string a = "";
            double win = 0;
            double lose = 0;
            ArrayList vastused = new ArrayList();
            ArrayList list = new ArrayList();
            foreach (KeyValuePair<string, string> item in lima)
            {
                list.Add(item.Key);
                list.Add(item.Value);
            }
            for (int o = 0; o < 4; o++)
            {
                do
                {
                    sona = (string)list[rnd.Next(0, list.Count)];
                } while (vastused.Contains(sona));
                if (lima.ContainsKey(sona))
                {
                    vastus = lima[sona];
                }
                else
                {
                    vastus = mali[sona];
                }
                Console.WriteLine("Mängu number {0}", o+1);
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("{0} - ?", sona);
                    a = Console.ReadLine();
                    if (a == vastus)
                    {
                        Console.WriteLine("See on õige!");
                        win += 1;
                        break;
                    }
                    else if (i == 2)
                    {
                        Console.WriteLine("Vastus oli {0}", vastus);
                        lose += 1;
                    }
                    else
                    {
                        Console.WriteLine("Vale!");
                    }
                }
                Console.WriteLine();
                vastused.Add(sona);
            }
            Console.WriteLine("Võitude arv: {0}\nVõitude protsent: {1}%\nKahjude arv: {2}\nKaotuse protsent: {3}%", win, win/4*100, lose, lose/4*100);
        }


        public static void Parandada(Dictionary<string, string> lima, Dictionary<string, string> mali)
        {
            string a = "";
            string ob = "";
            string ob1 = "";
            do
            {
                Console.WriteLine("Kirjutage parandatav objekt");
                a = Console.ReadLine();
            } while (lima.ContainsKey(a)==false && mali.ContainsKey(a)==false);

            if (lima.ContainsKey(a))
            {
                Console.WriteLine("Kirjutage õige versioon");
                ob = Console.ReadLine();
                Console.WriteLine("Kirjutage objekti linn või maakond");
                ob1 = Console.ReadLine();
                lima.Remove(a);
                lima[ob] = ob1;
            }
            else if (mali.ContainsKey(a))
            {

                Console.WriteLine("Kirjutage õige versioon");
                ob = Console.ReadLine();
                mali.Remove(a);
                mali[ob] = ob1;
            }
            LTF(lima, @"..\..\..\maakond.txt");
        }
    }
}
