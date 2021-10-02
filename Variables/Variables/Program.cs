using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 5;         //1 byte
            sbyte c = 5;        //1 byte

            short s = 5;       //2 byte
            ushort us = 5;     //2 byte

            Int16 i16 = 2;     //2 byte;
            int i = 2;         //4 byte
            Int32 i32 = 2;     //4 byte

            uint ui = 2;       //4 byte
            long l = 4;        //8 byte
            ulong ul = 4;      //8 byte

            float f = 5;       //4 byte
            double d = 5;      //8 byte
            decimal de = 5;    //16 byte

            char ch = '2';     // 2 byte
            string str = "yusuf";   //sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;

            object o1 = "s";
            object o2 = 'a';
            object o3 = 4;
            object o4 = 4.2;

            //string ifadeler

            string str1 = string.Empty;
            string ad = "Yusuf";
            string soyad = "Zeyrek";
            string fullIisim = ad + soyad;

            int i1 = 2;
            int i2 = 3;
            int i3 = i1 * i2;

            //boolean

            bool bool1 = 10 > 2;

            //Değişken Dönüşümleri

            string str20 = "20";
            int i20 = 20;

            string newValue = str20 + i20.ToString();

            Console.WriteLine(newValue);

            int newInt = i20 + Convert.ToInt32(str20);

            Console.WriteLine(newInt);

            int i22 = int.Parse(str20);

            string DateTime2 = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(DateTime2);

            string DateTime3 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(DateTime3);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);

            Console.ReadLine();
        }
        
    }
}
