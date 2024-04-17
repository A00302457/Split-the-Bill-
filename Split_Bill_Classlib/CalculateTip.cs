

namespace Split_Bill_Classlib;

public class CalculateTip
{
    public Dictionary<string, decimal> calculateTips(Dictionary<string, decimal> totalamount, float tips)
    {
       if (tips > 0)
       {
            Dictionary<string,decimal> totaltip = new Dictionary<string, decimal>();
            decimal totalbill = 0;
            foreach(var i in totalamount)
            {
                totalbill += i.Value;
            }
            foreach(var i in totalamount)
            {
                decimal tip = i.Value * (decimal)(tips / 100f);
                totaltip[i.Key] = tip;
            }
            return totaltip;
       }
       else
       {
            Dictionary<string, decimal> zeroTip = new Dictionary<string, decimal>();
        foreach (var i in totalamount)
        {
            zeroTip[i.Key] = 0;
        }
        return zeroTip;
       }        
       
    }
    
}