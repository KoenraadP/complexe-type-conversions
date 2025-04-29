using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Conversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double x = 9;
            //decimal y = x;

            //int x = 9;
            //double y = x;

            //byte x = 255;
            //int y = x;

            // Bart Staat In  Lange File, Druk
            // Byte Short Int Long  Float Double

            //double y = 9.5;
            //// cast --> alles na de komma verdwijnt
            //int x = (int)y;
            //// convert --> er wordt 'normaal' afgerond
            //int z = Convert.ToInt32(y);

            //Console.WriteLine(x); 
            //Console.WriteLine(z);

            //bool x = true;
            //Console.WriteLine(x);
            //// bool standaard 0 false 1 true
            //Console.WriteLine(Convert.ToByte(x));

            //Console.WriteLine("Enter your age");
            //int age = Convert.ToInt32(Con
            //
            //sole.ReadLine());
            //Console.WriteLine(age);

            //int x = 300;
            //byte y = (byte)x;
            //// 300 in binair 100101100
            //// https://www.rapidtables.com/convert/number/
            //// byte is maar maximaal 8 bits --> 00101100 blijft over
            //// dit is '44'
            //Console.WriteLine(y);

            //// overflowexception
            //byte z = Convert.ToByte(x);
            //Console.WriteLine(z);

            // omzetten naar datum kan ook met Convert
            //string dateString = "29/04/2025";
            //DateTime date = Convert.ToDateTime(dateString);
        }
    }
}
