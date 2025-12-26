namespace MultipleInheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Bird Object
            Bird b = new Bird();

            b.land();
            b.eat();

            // Bird1 Object
            IBird1 b1 = new Bird();
            b1.fly();

            // Bird2 Object
            IBird2 b2 = new Bird();

            b2.fly(); 
        }
    }
}
