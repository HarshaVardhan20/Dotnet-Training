using System;
using System.Collections.Generic;
using System.Text;

namespace IndexerExample
{

    public static class StringExtension
    {
        public static int getACount(this string str)
        {
            int count = 0;
            foreach(char ch in str)
            {
                if (ch == 'A')
                {
                    count++;
                }
            }
            return count;
        }
    }

    public static class GeneralUsers
    {
        public static int RNo;
        static GeneralUsers()
        {
            RNo = 1;
        }
        public static int GetRno()
        {
            return RNo;
        }
    }
    public partial class YoungProfessional
    {
        public YoungProfessional()
        {

        }
        public YoungProfessional(string dob)
        {
            DateOfBirth = dob;
        }
        public int PersonalId { get; private set; }
        public int RNo { get; set; }
        public string DateOfBirth { get; private set; }

        public string Name { get; set; }

        public void SetDateOfBirth(string dateOfBirth)
        {
            DateOfBirth = dateOfBirth;
        }
    }

    class BooksIndexer
    {
        public int Rno { get; set; }
        public string Name { get; set; }
        
        private string Address;

        private List<string> Books = new List<string>();

        public string this[int index]
        {
            get
            {
                if (index < Books.Count)
                {
                    return Books[index];
                }
                return $"Book not found at index {index}";
            }
            set
            {
                if (index < Books.Count)
                {

                    Books[index] = value;
                }
                else
                {
                    Books.Add(value);
                }
            }
        }
    }
}