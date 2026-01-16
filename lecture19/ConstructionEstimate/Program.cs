using System.ComponentModel.DataAnnotations;

/// <summary>
/// Program class for validating construction estimates.
/// Ensures that construction area does not exceed the available site area.
/// Throws an exception if the estimate is invalid.
/// </summary>
public class Program
{
    #region Inner Classes
    /// <summary>
    /// Data class to hold construction and site area details.
    /// </summary>
    public class EstimateDetails
    {
        public float ConstructionArea{get;set;}
        public float SiteArea{get;set;}
    }
    /// <summary>
    /// Custom exception thrown when a construction estimate is invalid (construction area > site area).
    /// </summary>
    public class ConstructionEstimateException: Exception
    {
        /// <summary>
        /// Initializes a new instance of ConstructionEstimateException with a predefined message.
        /// </summary>
        public ConstructionEstimateException(): base("Sorry your construction estimate is not Approved"){}
    }
    #endregion

    #region Methods
    /// <summary>
    /// Validates that the construction area does not exceed the site area.
    /// Returns EstimateDetails if valid, otherwise throws ConstructionEstimateException.
    /// </summary>
    /// <param name="constructionArea">The area of the construction project.</param>
    /// <param name="siteArea">The total available site area.</param>
    /// <returns>EstimateDetails object containing the validated areas.</returns>
    public EstimateDetails ValidateConstructionEstimate(float constructionArea, float siteArea)
    {
        if (constructionArea <= siteArea)
        {
            return new EstimateDetails
            {
                ConstructionArea = constructionArea,
                SiteArea = siteArea
            };
        }
        throw new ConstructionEstimateException();
    }
    #endregion

    #region Main
    /// <summary>
    /// Main entry point. Demonstrates construction estimate validation.
    /// Attempts to validate estimates and handles any exceptions that occur.
    /// </summary>
    public static void Main()
    {
        Program p = new Program();
        try
        {
            EstimateDetails e  = p.ValidateConstructionEstimate(33.33f,33.32f);
            Console.WriteLine("Constructon estimate is valid");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    #endregion
}