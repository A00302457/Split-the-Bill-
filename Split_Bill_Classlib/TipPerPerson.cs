namespace Split_Bill_Classlib;

public class TipPerPerson
{
        public decimal tipPerPerson(decimal price, int peoples, float percentage)
        {
            decimal totalTip = price * (decimal)(percentage / 100.0f);
            return totalTip / peoples;
        }
}