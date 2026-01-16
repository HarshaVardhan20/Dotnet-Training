/// <summary>
/// Program class for user authentication and password validation.
/// Validates that passwords match their confirmation and registers users successfully.
/// Throws an exception if passwords do not match.
/// </summary>
public class Program
{
    #region Inner Classes
    /// <summary>
    /// Data class representing a user with authentication credentials.
    /// </summary>
    public class User
    {
        /// <summary>The user's name.</summary>
        public string Name {get;set;}
        /// <summary>The user's password.</summary>
        public string Password {get;set;}
        /// <summary>The user's password confirmation for verification.</summary>
        public string ConfirmationPassword {get;set;}
    }

    /// <summary>
    /// Custom exception thrown when password and confirmation password do not match.
    /// </summary>
    public class PasswordMismatchException : Exception
    {
        /// <summary>
        /// Initializes a new instance of PasswordMismatchException with a predefined message.
        /// </summary>
        public PasswordMismatchException(): base("Password is mismatched"){}
    }
    #endregion

    #region Methods
    /// <summary>
    /// Validates that the password matches the confirmation password.
    /// Returns a User object if passwords match, throws PasswordMismatchException otherwise.
    /// </summary>
    /// <param name="name">The user's name.</param>
    /// <param name="password">The user's password.</param>
    /// <param name="confirmationPassword">The confirmation password to verify.</param>
    /// <returns>User object if passwords match.</returns>
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
    #endregion

    #region Main
    /// <summary>
    /// Main entry point. Demonstrates password validation and user registration.
    /// Handles PasswordMismatchException if passwords do not match.
    /// </summary>
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
    #endregion
}