using System;

namespace ClassLibrary2
{
    public class Class1
    {
        public static void notMain(){return;}
        static int presentForVarvara(string Varvara)
        {
            //return Varvara.Split(' ', StringSplitOptions.RemoveEmptyEntries).Where(s => s[0]==s[s.Length-1]).ToArray().Length;
            int repeats = default;
            string[] words = Varvara.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                char[] letters = word.ToCharArray();
                if (letters[0] == letters[letters.Length-1])
                {
                    repeats++;
                }
            }
            return repeats;
        } 
    }
}