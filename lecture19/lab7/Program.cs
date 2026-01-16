using System.ComponentModel.DataAnnotations;

public class Program
{
    public class EstimateDetails
    {
        public float ConstructionArea{get;set;}
        public float SiteArea{get;set;}
    }
    public class ConstructionEstimateException: Exception
    {
        public ConstructionEstimateException(): base("Sorry your construction estimate is not Approved"){}
    }
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
}