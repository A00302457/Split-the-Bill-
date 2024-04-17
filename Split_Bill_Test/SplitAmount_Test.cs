using Split_Bill_Classlib;

namespace Split_Bill_Test;

[TestClass]
public class SplitAmount_Test
{
    [TestMethod]
    public void SplitAmount_Split_The_Bill_Method_When_Except_Zero_Amount_Return_Zero()
    {
        var amount = new SplitAmount();
        var result = amount.SplitTheBill(0,2);
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void SplitAmount_Split_The_Bill_Method_When_Except_Zero_person_Return_Zero()
    {
        var amount = new SplitAmount();
        var result = amount.SplitTheBill(10,0);
        Assert.AreEqual(0, result);
    }
    [TestMethod]
    public void SplitAmount_Split_The_Bill_Method_When_Except_Zero_personAndAmount_Return_Zero()
    {
        var amount = new SplitAmount();
        var result = amount.SplitTheBill(0,0);
        Assert.AreEqual(0, result);
    }
}