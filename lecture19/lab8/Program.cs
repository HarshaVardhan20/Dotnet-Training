

using System.ComponentModel.DataAnnotations;

public class Program
{
    public class User
    {
        public string Name{get;set;}
        public string PhoneNumber{get;set;}
    }
    public class InvalidPhoneNumberException: Exception
    {   
        public InvalidPhoneNumberException(): base("Invalid Phone number"){}
    }
    public User ValidatePhoneNumber(string name, string phoneNumber)
    {
        if (phoneNumber.Length == 10)
        {
            return new User{Name = name,PhoneNumber = phoneNumber};
        }
        else
        {
            throw new InvalidPhoneNumberException();
        }
    }
    public static void Main()
    {
        try
        {
            Program p = new Program();
            User u = p.ValidatePhoneNumber("Harsha","9392306018");
            Console.WriteLine("User created successfully correct Phone numebr");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

