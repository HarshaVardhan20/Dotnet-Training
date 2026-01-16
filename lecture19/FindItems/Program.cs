namespace FindItemsProblem1
{
    /// <summary>
    /// Program class for managing and searching item inventory.
    /// Provides functionality to add items, search by sold count, find min/max sold items, and sort items.
    /// Uses a SortedDictionary to automatically maintain alphabetical order of items.
    /// </summary>
    public class Program
    {
        #region Fields
        /// <summary>
        /// Static SortedDictionary storing item names and their corresponding sold counts.
        /// Maintains items in alphabetical order by key.
        /// </summary>
        public static SortedDictionary<string, long> itemDetails = new SortedDictionary<string, long>();
        #endregion

        #region Helper Methods
        /// <summary>
        /// Searches for all items that have been sold exactly the specified count.
        /// Returns a new SortedDictionary containing matching items.
        /// </summary>
        /// <param name="soldCount">The sold count to search for.</param>
        /// <returns>SortedDictionary containing items with the matching sold count.</returns>
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

        /// <summary>
        /// Finds the items with minimum and maximum sold counts.
        /// Returns a list with two items: the minimum sold item and the maximum sold item.
        /// </summary>
        /// <returns>List containing [minimum sold item, maximum sold item].</returns>
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
        /// <summary>
        /// Returns all items sorted by their sold count in ascending order.
        /// </summary>
        /// <returns>Dictionary containing items sorted by sold count.</returns>
        public Dictionary<string, long> SortedByCount()
        {
            return itemDetails.OrderBy(e => e.Value).ToDictionary(e => e.Key, e => e.Value);
        }
        #endregion

        #region UI Methods
        /// <summary>
        /// Prompts the user to enter an item name and sold count, then adds it to the inventory.
        /// Validates that the sold count is a valid long integer.
        /// Prevents duplicate items from being added.
        /// </summary>
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

        /// <summary>
        /// Prompts user to enter a sold count and displays all items with that exact count.
        /// Shows an error message if no items match the search criteria.
        /// </summary>
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

        /// <summary>
        /// Displays the items with minimum and maximum sold counts.
        /// </summary>
        public void DisplayMinAndMax()
        {
            var result = FindMinAndMaxSoldItems();
            Console.WriteLine("Minimum Sold Item: " + result[0]);
            Console.WriteLine("Maximum Sold Item: " + result[1]);
        }

        /// <summary>
        /// Displays all items sorted by their sold count in ascending order.
        /// </summary>
        public void DisplaySortedItems()
        {
            var sortedItems = SortedByCount();
            foreach (var item in sortedItems)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
        #endregion

        #region Main
        /// <summary>
        /// Main entry point providing a menu-driven interface for item management:
        /// 1. Add new items
        /// 2. Search items by sold count
        /// 3. Find min/max sold items
        /// 4. Display items sorted by count
        /// 5. Exit the program
        /// </summary>
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
        #endregion
    }
}