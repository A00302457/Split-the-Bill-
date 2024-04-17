namespace Split_Bill_Classlib;

public class SplitAmount
{
    public decimal SplitTheBill(decimal amount, int numberOfPeople)
    {
        if(amount > 0 && numberOfPeople > 0)
            return amount / numberOfPeople;
        else
            return 0;
    }
}
