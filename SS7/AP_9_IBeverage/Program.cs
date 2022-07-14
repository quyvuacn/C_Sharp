public interface IBeverage
{
    int GetServingTemperature(bool includesMilk);
    bool IsFairTrade { get; set; }
}

public class Coffee : IBeverage
{
    private int servingTempWithoutMilk { get; set; }
    private int servingTempWithMilk { get; set; }
    public int GetServingTemperature(bool includesMilk)
    {
        if (includesMilk)
        {
            return servingTempWithMilk;
        }
        else
        {
            return servingTempWithoutMilk;
        }
    }
    public bool IsFairTrade { get; set; }
    // Other non-interface members.
}