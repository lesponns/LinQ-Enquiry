using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_44_29_08_23_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> citys = new List<string>()
            {
                 "Adıyaman","Burdur","Ağrı","Aksaray","Amasya","Bilecik",
                 "Bartın","Ardahan","Artvin","Çankırı","Balıkesir","Batman","Bayburt",
                 "Bingöl","Bitlis","Bolu","Bursa","Adana","Çorum"
            };
            #region Select
            var list = from s in citys select s;

            Console.WriteLine("Kayıtlı İller\n-------------");
            foreach (var city in list) 
            {
                Console.WriteLine(city);
            }

            Console.WriteLine("\n");
            #endregion

            #region OrderBy Ascending
            var kbsehirler = from s 
                             in citys
                             orderby s ascending
                             select s;
            Console.WriteLine("Küçükten Büyüğe Sıralama\n------------------------");
            foreach (var item in kbsehirler)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n");
            #endregion
            
            #region OrderBy Descending
            var bksehirler = from x
                             in citys
                             orderby x descending
                             select x;

            Console.WriteLine("Büyükten Küçüğe Sıralama\n------------------------");
            foreach (var item in bksehirler)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n");
            #endregion

            #region Where
            var fsehirler = from k
                            in citys
                            where k[0].ToString().ToLower()=="a"
                            orderby k ascending
                            select k;

            Console.WriteLine("A ile başlayan Şehirler\n-----------------------");
                               
            foreach (var item in fsehirler)
            { 
                Console.WriteLine(item); 
            }
            #endregion

            Console.ReadKey(); 
        }
    }
}
