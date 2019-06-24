using System;

namespace Kata
{
    public class BandNameGeneratorKata
    {
        public string BandNameGenerator(string str)
        {
            if (Char.ToLower(str[0]) == str[str.Length - 1])
            {
                return str.Substring(0, 1).ToUpper() + str.Substring(1).ToLower() + str.Substring(1);
            }
            else
            {
                return "The " + str.Substring(0, 1).ToUpper() + str.Substring(1).ToLower();
            }
        }
    }
}