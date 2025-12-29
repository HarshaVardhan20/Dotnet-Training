namespace AssciAndStringManupulation
{
    public class Program
    {
        public void CleanseAndInvert(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsLetter(input[i]))
                {
                    Console.WriteLine("Invalid input");
                    return;
                }
            }

            string str = input.ToLower();

            string ans = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (((int)str[i]) % 2 != 0)
                {
                    ans += str[i];
                }
            }

            char[] arr = ans.ToCharArray();
            Array.Reverse(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    arr[i] = char.ToUpper(arr[i]);
                }
            }

            string result = new string(arr);
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string? input = Console.ReadLine();
            Program p = new Program();
            p.CleanseAndInvert(input);
        }
    }
}
