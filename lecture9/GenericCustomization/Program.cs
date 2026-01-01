using System.Collections;

namespace GenericCustomization
{
    public class MyCollection : IList
    {
        public ArrayList items;
        public MyCollection() { 
            items = new ArrayList();            
        }
        public object? this[int index] { get => items[index]; set => throw new NotImplementedException(); }

        public bool IsFixedSize => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public int Count => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public int Add(object? value)
        {
            return items.Add(value);
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(object? value)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(object? value)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, object? value)
        {
            throw new NotImplementedException();
        }

        public void Remove(object? value)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }
    }
    public class Program
    {

        public static void Main(string[] args)
        {
            MyCollection mc = new MyCollection();
            mc.Add(4);
            Console.WriteLine(mc[0]);
        }
    }
}
