namespace ResultPattern;
internal class SampleWithoutResultPattern
{
    public static int Divide(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Division by zero is not allowed.");
        }

        return numerator / denominator;
    }
}
