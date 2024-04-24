namespace P2C4._2;

public class SimpleMath
{
    /// <summary>
    /// calculate the average value of a list of integers
    /// return the average of the list
    /// </summary>
    /// <param name="listeDesEntiers"></param>
    /// <returns></returns>
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
