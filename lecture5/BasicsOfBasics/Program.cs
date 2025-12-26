namespace BasicsOfBasics
{
    public class SomeClass
    {
        public int AddTwo(int a,int b)
        {
            checked
            {
                int c = a + b;
                return c;
            }
        }

        public int MultiMath(int n,out int square, out int half, out int addBy3)
        {
            square = n * n;
            half = n / 2;
            addBy3 = n + 3;
            return n;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            SomeClass someClass = new SomeClass();
            //int x = int.MaxValue;
            //int y = 10;
            //int ans = someClass.AddTwo(x, y);  // Overflow and becomes negative.
            int n = 10;

            int a = someClass.MultiMath(n, out int square, out int half, out int addBy3);
            Console.WriteLine($"n is {n} square is {square} half is {half} addBy3 is {addBy3}");

            int[][] data = new int[3][];
            data[0] = new int[] { 1, 2, 3 };
            data[1] = new int[] { 10, 20 };
            data[2] = new int[] { 7, 8, 9, 10 };
            for (int i = 0; i < data.Length; i++) { 
                Console.WriteLine("Row " + i + ": ");
                foreach (var v in data[i]) Console.Write(v + " ");
                Console.WriteLine();
            }


            Console.WriteLine("**********************************************************************************");
            List<int> nums = new List<int>();

            nums.Add(18);
            nums.Add(13);
            nums.Add(35);
            nums.Add(27);
            nums.Sort();
            foreach(var num in nums)
            {
                Console.WriteLine(num);
            }
        }
    }
}
