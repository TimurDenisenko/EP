using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP
{
    public class AlamClass
    {
        public static void Tere(string nimi)
        {
            Console.WriteLine("Tere, {0}.",nimi);
        }


        public static int Korruta(int a, int b)
        {
            return a*b;
        }


        public static int Middle(int length)
        {
            int a = 0;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("{0} arv",i+1);
                a+= Convert.ToInt32(Console.ReadLine());
            }
            return a/length;
        }


        public static void Nurr(int a,int b,string str)
        {
            double n = 0;
            string n1 = "Norm";
            switch (str)
            {
                case "+":
                    n=a+b;
                    break;
                case "-":
                    n=a-b;
                    break;
                case "*":
                    n=a*b;
                    break;
                case "/":
                    if (b==0)
                    {
                        n1=Convert.ToString(n);
                        n1="Viga";
                    }
                    else
                    {
                        n=a/b;
                    }
                    break;
                default:
                    n1=Convert.ToString(n);
                    n1="Viga";
                    break;
            }
            if (n1=="Norm")
            {
                Math.Round(n, 1);
                for (int i = 0; i < n; i++)
                {
                    Console.Write("nurr ");
                }
            }
            else
            {
                Console.WriteLine("Viga!");
            } 
        }


        public static string Stars(int n)
        {
            string var = "";
            for (int i = 0; i < n; i++)
            {
                var+="*";
            }
            return var;
        }


        public static void NStars()
        {
            int[] stars = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0} arv",i+1);
                stars[i]=Convert.ToInt32(Console.ReadLine());
            }
            foreach (int num in stars)
            {
                Console.Write(Stars(num));
                Console.WriteLine();
            }
        }
    }
}
