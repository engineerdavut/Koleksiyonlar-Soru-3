using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle giriniz.");
            string text = Console.ReadLine();
            char[] ch = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            List<char> myList = new List<char>();
            for (int i = 0; i < text.Length; i++)
            {
                if (ch.Contains(Convert.ToChar(text.Substring(i, 1))))
                {
                    myList.Add(Convert.ToChar(text.Substring(i, 1)));
                }
            }
            char[] istenenArray = new char[myList.Count];
            int j = 0;
            foreach (char item in myList)
            {
                istenenArray[j] = item;
                j++;
            }
            Console.WriteLine("Girdiginiz Cumledeki sesli harfler sirasiyla");
            foreach(char item in istenenArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
