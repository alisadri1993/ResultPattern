using ResultPattern.Abstraction;

namespace ResultPattern;

internal class Program
{
    static void Main(string[] args)
    {
        #region result pattern usage 

        var result = SampleWithResultPattern.Divide(10, 0);
        if (result.IsSuccess)
        {
            Console.WriteLine($"Result: {result.Value}");
        }
        else
        {
            Console.WriteLine($"Error: {result.Error}");
        }
        #endregion

        #region equaivalent with exception usage

        try
        {
            var divisionResult = SampleWithoutResultPattern.Divide(10, 0);
            Console.WriteLine($"Result: {divisionResult}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        #endregion

    }
}
