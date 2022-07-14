//Defining an Interface
//Thuộc tính chỉ đọc
public interface ILoyaltyCardHolder
{
    int TotalPoints { get; }
    int AddPoints(decimal transactionValue);
    void ResetPoints();
}

//Lớp thể hiện interface ILoyaltyCardHolder:

public class Customer : ILoyaltyCardHolder{
    int totalPoints;
    public int TotalPoints
    {
        get { return totalPoints; }
    }

    public int AddPoints(decimal transactionValue)
    {
        int points = Decimal.ToInt32(transactionValue);
        totalPoints += points;
        return totalPoints;
    }

    public void ResetPoints()
    {
        totalPoints = 0;
    }


}

