namespace IndexerExample
{
    class MyData
    {
        private string[] values = new string[3];

        public string this[int index]
        {
            get
            {
                return values[index];
            }
            set
            {
                values[index] = value;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                MyData myData = new MyData();

                myData[0] = "C++";
                myData[1] = "Python";
                myData[2] = "Javascropt";

                Console.WriteLine(myData[0]);
                Console.WriteLine(myData[1]);
                Console.WriteLine(myData[2]);
            }
        }
    }

}