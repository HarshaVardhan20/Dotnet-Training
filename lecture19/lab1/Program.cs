namespace FindItemsProblem1
{
    public class Program
    {
        public static SortedDictionary<string, long> itemDetails = new SortedDictionary<string, long>();

        public SortedDictionary<string, long> FindItemDetails(long soldCount)
        {
            SortedDictionary<string, long> itemDetail = new SortedDictionary<string, long>();
            if(itemDetails == null)
            {
                return new SortedDictionary<string, long>();
            }
            foreach(var item in itemDetails)
            {
                if (item.Value.Equals(soldCount))
                {
                    itemDetail.Add(item.Key, soldCount);
                }
            }
            return itemDetail;

        }

        public List<string> FindMinAndMaxSoldItems()
        {
            var minimum = itemDetails.Values.Min();
            var maximum = itemDetails.Values.Max();
            var items = new List<string>();
            string mini = "";
            string maxi = "";
            foreach(var item in itemDetails)
            {
                if (item.Value.Equals(minimum))
                {
                    mini = item.Key;
                }
                if (item.Value.Equals(maximum))
                {
                    maxi = item.Key;
                }
            }
            items.Add(mini);
            items.Add(maxi);
            return items;
            
        }
        public Dictionary<string, long> SortedByCount()
        {
            return itemDetails.OrderBy(e => e.Value).ToDictionary(e => e.Key, e => e.Value);
        }

        public void AddItem()
        {
            Console.Write("Enter Item Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Sold Count: ");
            if (long.TryParse(Console.ReadLine(), out long count))
            {
                if (!itemDetails.ContainsKey(name))
                {
                    itemDetails.Add(name, count);
                }
            }
            else
            {
                Console.WriteLine("Invalid sold count");
            }
        }

        public void SearchBySoldCount()
        {
            Console.Write("Enter Sold Count to Search: ");
            if (long.TryParse(Console.ReadLine(), out long soldCount))
            {
                var result = FindItemDetails(soldCount);
                if (result.Count == 0)
                {
                    Console.WriteLine("Invalid sold count");
                }
                else
                {
                    foreach (var item in result)
                    {
                        Console.WriteLine(item.Key + " : " + item.Value);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid sold count");
            }
        }

        public void DisplayMinAndMax()
        {
            var result = FindMinAndMaxSoldItems();
            Console.WriteLine("Minimum Sold Item: " + result[0]);
            Console.WriteLine("Maximum Sold Item: " + result[1]);
        }

        public void DisplaySortedItems()
        {
            var sortedItems = SortedByCount();
            foreach (var item in sortedItems)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. Find Item Details by Sold Count");
                Console.WriteLine("3. Find Min and Max Sold Items");
                Console.WriteLine("4. Display Items Sorted by Sold Count");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Enter a valid integer choice");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        p.AddItem();
                        break;

                    case 2:
                        p.SearchBySoldCount();
                        break;

                    case 3:
                        p.DisplayMinAndMax();
                        break;

                    case 4:
                        p.DisplaySortedItems();
                        break;

                    case 5:
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }
    }
}