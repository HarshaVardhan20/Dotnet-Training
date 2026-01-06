
namespace XmlSeriealization
{
    public delegate int delegateAddFuncName (int a,int b);
    public class Deligate
    {

        public void Delegation(int a,int b)
        {
            delegateAddFuncName delegateVariable = new delegateAddFuncName(AddMethod1); // can be AddMethod2
            Console.WriteLine(delegateVariable(a,b));
        }
        
        public int AddMethod1(int a,int b)
        {
            return a + b;
        }

        public int AddMethod2(int a,int b)
        {
            return a + b;
        }
    }
}
