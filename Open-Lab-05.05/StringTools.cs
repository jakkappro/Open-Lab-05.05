using System;

namespace Open_Lab_05._05
{
    public class StringTools
    {
        public string AlternatingCaps(string original)
        {
            string ret = "";
            char[] originalChar = original.ToCharArray();
            int index = 0;
            for(int i = 0; i < original.Length; i++)
            {
                if (!Char.IsWhiteSpace(original[i]))
                {
                    if (index % 2 == 0)
                        ret += originalChar[i].ToString().ToUpper();
                    else
                        ret += originalChar[i].ToString().ToLower();

                    index++;
                }
                else
                {
                    ret += " ";
                }
            }
            return ret;
        }
    }
}
