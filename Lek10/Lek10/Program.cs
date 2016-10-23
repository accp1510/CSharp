using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace Lek10
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri uri = new Uri("http://www.cbr.ru/");
            WebClient web = new WebClient();
            StreamReader st = new StreamReader(web.OpenRead(uri));
            string str;
            string page = string.Empty;
            while ((str = st.ReadLine()) != null)
            {
                //Console.WriteLine(str);
                page += str;
            }
            int id = page.IndexOf("rubl");
            page = page.Substring(id + 4);
            id = page.IndexOf("</td>");
            Console.WriteLine(page.Substring(0, id));

        }
    }
}
