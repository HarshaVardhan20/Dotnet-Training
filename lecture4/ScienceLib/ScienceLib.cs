using System.Reflection.Metadata.Ecma335;

namespace ScienceLib
{
    public class AstroScience
    {
        public string getInfo()
        {
            return "This is AstroScience";
        }

        
        public static void Main()
        {
            ScienceLoginAbs scienceLogin = new ScienceLoginAbs();
            scienceLogin.Login("harsha", "123");
            Console.WriteLine(scienceLogin.protectedFunc());
        }
    }
}
