using System;

namespace Open_Lab_05._05
{
    public class StringTools
    {
        public string AlternatingCaps(string original)
        {
            string ret = "";
            int index = 0;
            for(int i = 0; i < original.Length; i++)
            {
                if (original.ToCharArray()[i].ToString() != " ")
                {
                    if (index % 2 == 0)
                        ret += original.ToCharArray()[i].ToString().ToUpper();
                    else
                        ret += original.ToCharArray()[i].ToString().ToLower();

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
