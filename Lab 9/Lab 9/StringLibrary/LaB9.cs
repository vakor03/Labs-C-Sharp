using System;
using System.Linq;

namespace StringLibrary
{
    public class LaB9
    {
        public static string lab(string str, out int counter)
        {
            counter = 0;
            char[] symbols = str.ToCharArray();
            for (int i = 0; i < symbols.Length; i++)
            {
                bool isRepeated = false;
                for (int j = i+1; j < symbols.Length; j++)
                {
                    if (symbols[i]!='\0' && symbols[i] == symbols[j])
                    {
                        symbols[j] = '\0';
                        counter += 1;
                        isRepeated = true;
                    }
                }
                if (isRepeated)
                {
                    symbols[i] = '\0';
                    counter += 1;
                }
            }
            str = "";
            foreach (char t in symbols)
            {
                if (t!='\0')
                {
                    str += t;
                }
            }
            return str;
        }

        public static void labAsLinq()
        {
            string code = "AABBDDCCRRFF";
            string answer = new String(code.Distinct().ToArray());
        }
    }
}