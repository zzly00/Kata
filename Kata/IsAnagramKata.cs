using System;

namespace Kata
{
    public class IsAnagramKata
    {
        public bool IsAnagram(string test, string original)
        {
            char[] testArr = test.ToLower().Replace(" ", "").ToCharArray();
            Array.Sort(testArr);
            char[] originalArr = original.ToLower().Replace(" ", "").ToCharArray();
            Array.Sort(originalArr);
            return new string(testArr) == new string(originalArr);
        }
    }
}
