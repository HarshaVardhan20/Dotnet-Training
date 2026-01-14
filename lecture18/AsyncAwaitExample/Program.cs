namespace AsyncAwaitExample
{
    public class Program
    {
        public async Task AsyncMethod()
        {
            Console.WriteLine("Task Started");
            await Task.Delay(3000);
            Console.WriteLine("Task Completed after 3 Seconds");
        }

        public async void CallMethod()
        {
            string result = await FetchDataAsync("https://jsonplaceholder.typicode.com/todos");
            Console.WriteLine(result);
            await AsyncMethod();
        }

        public async Task<string> FetchDataAsync(string url)
        {
            using( HttpClient client = new HttpClient())
                return await client.GetStringAsync(url);
        }

        public static void Main()
        {
            Program p = new Program();
            p.CallMethod();
            Console.ReadLine();
        }
    }
}
