namespace InterfaceIntro
{
    interface Iprint
    {
        void Print();  
    }       

    public class Class1: Iprint
    {
        public void Print() {
            Console.WriteLine("Print method in class1");
        }
    }   
    public class Class2 : Iprint
    {
        public void Print()
        {
            Console.WriteLine("Print method in class2");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            Class2 c2 = new Class2();
            c1.Print();
            c2.Print();
        }
    }
}
