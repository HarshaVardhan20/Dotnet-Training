using MathsLib;
using ScienceLib;


namespace ProjectIntro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Algebra algebra = new Algebra();

            Console.WriteLine(algebra.Add(3, 4));

            AstroScience astro = new AstroScience();

            Console.WriteLine(astro.getInfo());
            Console.WriteLine(astro.privateFunc());

            ScienceLoginAbs sciLogin = new ScienceLoginAbs();
            sciLogin.Login("Harhsa","123");
        }
    }
}
