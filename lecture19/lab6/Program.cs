public class Program
{
    public class User
    {
        public string Name {get;set;}
        public string Password {get;set;}
        public string ConfirmationPassword {get;set;}
    }
    public User ValidatePassword(string name, string password,string confirmationPassword)
    {
        if (password == confirmationPassword)
        {
            return new User{Name=name,Password=password,ConfirmationPassword=confirmationPassword};
        }
        else
        {
            throw new PasswordMismatchException();
        }
    }

    public class PasswordMismatchException : Exception
    {
        public PasswordMismatchException(): base("Password is mismatched"){}
    }
    public static void Main()
    {
        Program p = new Program();
        try
        {
            User u = p.ValidatePassword("Harsha","Harsha","harsha");
            Console.WriteLine("Registered Successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}