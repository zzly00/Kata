namespace Kata
{
    public class GetMiddleKata
    {
        public string GetMiddle(string s)
        {
            int mid = s.Length % 2 == 0 ? s.Length / 2 - 1 : s.Length / 2;
            return s.Length % 2 == 0 ? s.Substring(mid, 2) : s.Substring(mid, 1);
        }
    }
}
