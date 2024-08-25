using ResultPattern.Abstraction;

namespace ResultPattern;
internal class SampleWithResultPattern
{
    public static Result<int> Divide(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            return Result<int>.Failure("Division by zero is not allowed.");
        }

        return Result<int>.Success(numerator / denominator);
    }
}
