namespace Split_Bill_Classlib;

public class SpliAmount
{
    public decimal SplitTheBill(decimal amount, int numberOfPeople)
    {
        return amount / numberOfPeople;
    }
}
