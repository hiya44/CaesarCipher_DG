using System;
using System.Text;

namespace CaesarCipher_DG
{
    public class Program
    {
        public static string CaesarCipher(string val, int shift)
        {
            if (shift < 0)
                shift = 26 - Math.Abs(shift);

            char[] encrypted = val.ToCharArray();
            for (int i = 0; i < encrypted.Length; i++)
            {
                char letter = encrypted[i];

                if (char.IsLetter(letter))
                {
                    char d = char.IsUpper(letter) ? 'A' : 'a';
                    letter = (char)((((letter + shift) - d) % 26) + d);
                    encrypted[i] = letter;
                }
                else encrypted[i] = letter;
            }
            return new string(encrypted);
        }
        static void Main(string[] args)
        {
            string a = "test1";
            string b = CaesarCipher(a, 18);
            string c = CaesarCipher(b, -18);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            string wiki = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";
            string wikiEn = CaesarCipher(wiki, -3);
            Console.WriteLine(wiki);
            Console.WriteLine(wikiEn);
            string wikiDe = CaesarCipher(wikiEn, 3);
            Console.WriteLine(wikiDe);
        }
    }
}
