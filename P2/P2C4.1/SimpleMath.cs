namespace P2C4._1;

public class SimpleMath
{
    /// <summary>
    /// Calculate the average value of a list of integers
    /// </summary>
    /// <param name="listOfIntegers">A list containing integer numbers</param>
    /// <returns>The average of the list</returns>
    public static int CalculateAverage(List<int> listOfIntegers)
    {
        int average = 0;

        foreach (int value in listOfIntegers)
        {
            average += value;
        }
        average /= listOfIntegers.Count;

        return average;
    }
}
