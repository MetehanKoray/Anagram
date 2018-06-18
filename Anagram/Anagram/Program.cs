using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        static void dondur(string kelime1,string kelime2)
        {
            char [] word1 = kelime1.ToCharArray();
            char[] word2 = kelime2.ToCharArray();

            Array.Sort(word1);
            Array.Sort(word2);

            string a = new string(word1);
            string b = new string(word2);

            if (a == b)
                Console.WriteLine("Kelimeler Anagramdır.");
            else
                Console.WriteLine("Kelimeler Anagram Değildir.");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 1.Kelimeyi Giriniz");
            string girdi1 = Console.ReadLine();
            Console.WriteLine("Lütfen 2.Kelimeyi Giriniz");
            string girdi2 = Console.ReadLine();

            dondur(girdi1,girdi2);
            Console.ReadLine();
        }
    }
}