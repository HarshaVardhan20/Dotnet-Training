

namespace DelegateImplementation
{
    public delegate void MyDelegate(string msg);
    public class Program
    {
        static void MethodA(string msg) => Console.WriteLine("A: " + msg );
        static void MethodB(string msg) => Console.WriteLine("A: " + msg );
        static void MethodC(string msg) => Console.WriteLine("A: " + msg );
        public static void Main()
        {
            MyDelegate d = MethodA;
            d+= MethodB;
            d+= MethodC;
            d("Hello Delegate!");
            Console.ReadLine();
        }
    }
}
