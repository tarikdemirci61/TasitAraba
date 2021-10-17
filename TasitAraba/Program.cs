using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TasitAraba
{
    class Program
    {
        static void Main(string[] args)
        {
            Araba arb = new Araba();

            Console.Write("Kaç tane araba kaydı yapacaksınız? :");
            int kacTane = int.Parse(Console.ReadLine());
            string[] Marka = new string[kacTane];
            string[] Model = new string[kacTane];
            int[] Yil = new int[kacTane];

            for (int x = 0; x < kacTane; x++)
            {
                FileStream fs = new FileStream("C:\\Users\\tarik\\source\\repos\\TasitAraba\\ARABALAR.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
                StreamWriter sw = new StreamWriter(fs);
                Console.Write("\t" + (x + 1) + ". Markası:");
                sw.WriteLine(Marka[x] = Console.ReadLine());
                Console.Write("\t" + (x + 1) + ". Modeli:");
                sw.WriteLine(Model[x] = Console.ReadLine());
                Console.Write("\t" + (x + 1) + ". Yılı:");
                sw.WriteLine(Yil[x] = int.Parse(Console.ReadLine()));
                sw.Close();
                Console.WriteLine("Kayıt Eklendi.");
            }

            //for (int x = 0; x < kacTane; x++)
            //{
                //Console.Write("\t" + (x + 1) + ". Markası:");
                //Marka[x] = Console.ReadLine();
                //Console.Write(" " + (x + 1) + ". Modeli:");
                //Model[x] = Console.ReadLine();
                //Console.Write(" " + (x + 1) + ". Yılı:");
                //Yil[x] = int.Parse(Console.ReadLine());
                

            //}


            //Console.WriteLine("Marka Giriniz:");
            //arb.Marka = Console.ReadLine();
            //Console.WriteLine($"Girilen Marka:{arb.Marka}");

            //Console.WriteLine("Model Giriniz:");
            //arb.Model = Console.ReadLine();
            //Console.WriteLine($"Girilen Model:{arb.Model}");

            //Console.WriteLine("Yıl Giriniz:");
            //arb.Yil = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Girilen Yıl:{arb.Yil}");


            //...
            //    Console.Write("\t" + (x + 1) + ". Markası:");
            //Marka[x] = Console.ReadLine();
            //Console.Write(" " + (x + 1) + ". Modeli:");
            //Model[x] = Console.ReadLine();
            //Console.Write(" " + (x + 1) + ". Yılı:");
            //Yil[x] = int.Parse(Console.ReadLine());
            //...

            Console.ReadKey();

        }
    }
}
