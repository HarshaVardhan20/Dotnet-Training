namespace MultipleInheritanceUsingInterface
{
    public interface IVegEater
    {
        void VegEater();
        void getTaste();
    }

    public interface INonVegEater
    {
        void NonVegEater();
        void getTaste();
    }

    public class Visitor: IVegEater, INonVegEater
    {    
        public void VegEater()
        {
            Console.WriteLine("Veg eater");
        }

        public void NonVegEater() 
        {
            Console.WriteLine("Non-veg eater");        
        }

        void IVegEater.getTaste()
        {
            Console.WriteLine("Non veg getTaste");
        }
            
        void INonVegEater.getTaste()
        {
            Console.WriteLine("Non veg getTaste");
        }
        public void Visit()
        {
            Console.WriteLine("Visitor is visited");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Visitor v = new Visitor();

            IVegEater vegEater = new Visitor();
            INonVegEater nonVegEater = new Visitor();

            v.VegEater();
            v.NonVegEater();
            v.Visit();
            vegEater.getTaste();
            nonVegEater.getTaste();
             
        }
    }
}
