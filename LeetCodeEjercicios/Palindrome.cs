using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCodeEjercicios
{
    public class Palindrome
    {
        public void Solution(string pal)
        {
            char[] str;
            pal = Regex.Replace(pal.ToLower(),@"[^a-z]","");
            Console.WriteLine(pal);
            str = pal.ToLower().ToCharArray();
            bool resultado = true;

            for (int i = 0, j = str.Length - 1; i < str.Length && j >= 0 && resultado != false; i++, j--)
            {
                resultado = (str[i] == str[j]) ? true : false;
                Console.WriteLine(resultado);
            }

            Console.WriteLine($"La frase enviada es {resultado} Palindrome");
            return;

        }
    }
}
