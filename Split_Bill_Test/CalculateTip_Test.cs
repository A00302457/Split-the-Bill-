using Split_Bill_Classlib;

namespace Split_Bill_Test;
[TestClass]

public class CalculateTip_Test
{
     [TestMethod]
    public void CalculateTip_calculateTips_Method_When_Except_Zero_tips_Return_Zero_tips_For_Each_Person()
    {
        var calculator = new CalculateTip();
        var totalAmount = new Dictionary<string, decimal>()
        {
            { "Pooja", 25},
            { "Arya", 30},
            { "Arpan", 20}
        };
        float tips = 0;
        var result = calculator.calculateTips(totalAmount,tips);
        Assert.AreEqual(0, result["Pooja"]);
        Assert.AreEqual(0, result["Arya"]);
        Assert.AreEqual(0, result["Arpan"]);
    }  

    [TestMethod]
    public void CalculateTip_calculateTips_Method_When_Except_Negative_tips_Return_Zero_tips_For_Each_Person()
    {
        var calculator = new CalculateTip();
        var totalAmount = new Dictionary<string, decimal>()
        {
            { "Pooja", 25},
            { "Arya", 30},
            { "Arpan", 20}
        };
        float tips = -10;
        var result = calculator.calculateTips(totalAmount,tips);
        Assert.AreEqual(0, result["Pooja"]);
        Assert.AreEqual(0, result["Arya"]);
        Assert.AreEqual(0, result["Arpan"]);
    }  

     [TestMethod]
    public void CalculateTip_calculateTips_Method_When_Except_total_tips_Return_expected_tips_For_Each_Person()
    {
        var calculator = new CalculateTip();
        var totalAmount = new Dictionary<string, decimal>()
        {
            { "Pooja", 25},
            { "Arya", 30},
            { "Arpan", 20}
        };
        float tips = 20;
        var result = calculator.calculateTips(totalAmount,tips);
        Assert.AreEqual(5, result["Pooja"]);
        Assert.AreEqual(6, result["Arya"]);
        Assert.AreEqual(4, result["Arpan"]);
    }  
}