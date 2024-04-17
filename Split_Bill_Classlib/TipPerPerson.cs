namespace Split_Bill_Classlib;

public class TipPerPerson
{
        public decimal tipPerPerson(decimal price, int peoples, float percentage)
        {
            if(price > 0 && peoples > 0)
            {
                decimal totalTip = price * (decimal)(percentage / 100.0f);
                return totalTip / peoples;
            }
            else
                return 0;
        }
}