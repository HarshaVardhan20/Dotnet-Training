

using System.ComponentModel.DataAnnotations;

/// <summary>
/// Program class for user phone number verification.
/// Validates that phone numbers are exactly 10 digits long.
/// Throws an exception if the phone number is invalid.
/// </summary>
public class Program
{
    #region Inner Classes
    /// <summary>
    /// Data class representing a user with contact information.
    /// </summary>
    public class User
    {
        /// <summary>The user's name.</summary>
        public string Name{get;set;}
        /// <summary>The user's phone number.</summary>
        public string PhoneNumber{get;set;}
    }

    /// <summary>
    /// Custom exception thrown when a phone number does not meet validation requirements (must be 10 digits).
    /// </summary>
    public class InvalidPhoneNumberException: Exception
    {   
        /// <summary>
        /// Initializes a new instance of InvalidPhoneNumberException with a predefined message.
        /// </summary>
        public InvalidPhoneNumberException(): base("Invalid Phone number"){}
    }
    #endregion

    #region Methods
    /// <summary>
    /// Validates that the phone number is exactly 10 digits long.
    /// Returns a User object if valid, throws InvalidPhoneNumberException otherwise.
    /// </summary>
    /// <param name="name">The user's name.</param>
    /// <param name="phoneNumber">The phone number to validate.</param>
    /// <returns>User object if phone number is valid (10 digits).</returns>
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
    #endregion

    #region Main
    /// <summary>
    /// Main entry point. Demonstrates phone number validation and user creation.
    /// Handles InvalidPhoneNumberException if the phone number is not valid.
    /// </summary>
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
    #endregion
}

