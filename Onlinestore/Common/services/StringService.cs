
namespace Common.services
{
    public class StringService
    {
        public string CutString(string text, int length)
        {
            if (text == null)
                return null;
            if (text.Length < length)
                return text;

            return text.Substring(0, length) + "...";
        }
    }
}
