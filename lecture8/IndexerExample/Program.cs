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



    }
    class Program
    {
        static void Main(string[] args)
        {
            MyData myData = new MyData();

            myData[0] = "C++";
            myData[1] = "Python";
            myData[2] = "Javascript";

            Console.WriteLine(myData[0]);
            Console.WriteLine(myData[1]);
            Console.WriteLine(myData[2]);
            string str = "helloAa";
            Console.WriteLine(str.getACount());
            BooksIndexer bookIndexer = new BooksIndexer { Name = "Harsha", Rno = 1 };

            bookIndexer[0] = "Book 1";
            bookIndexer[1] = "Book 2";
            bookIndexer[2] = "Book 3";
            //Console.WriteLine(bookIndexer[0]);
            //Console.WriteLine(bookIndexer[1]);
            //Console.WriteLine(bookIndexer[2]);


            YoungProfessional yp = new YoungProfessional();
            yp.SetDateOfBirth("28-12-2025");
            yp.setAddress("Address");

            //Console.WriteLine(GeneralUsers.GetRno());
            //Console.WriteLine(GeneralUsers.GetRno());
        }
    }
}
