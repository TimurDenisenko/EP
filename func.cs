using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP
{
    public class func
    {
        public static void FTL(string file)
        {
            StreamReader text = new StreamReader(file);
            Dictionary<string,string> mali = new Dictionary<string,string>();
            string laused = "";
            while (laused!=null)
            {
                laused = text.ReadLine();
                string[] t = laused.Split("-");
                mali[t[0]] = t[1];
            }
            text.Close();
        }

    }
}
