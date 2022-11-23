using System.Globalization;

namespace method1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Method();
        }
        static void Method ()
        {
           string str = "bU tasKi metHodla yazMalisiZ";

            TextInfo info = new CultureInfo("en-En", false).TextInfo;
            string result = info.ToTitleCase(str);
            Console.WriteLine(result);


        }
    }
}