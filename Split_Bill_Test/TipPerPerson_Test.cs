using Split_Bill_Classlib;
namespace Split_Bill_Test;

[TestClass]
public class TipPerPerson_Test
{
    [TestMethod]
    public void TipPerPerson_tipPerPerson_Method_When_Except_Zero_price_Return_Zero()
    {
        var amount = new TipPerPerson();
        var result = amount.tipPerPerson(0,2,10);
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void TipPerPerson_tipPerPerson_Method_When_Except_Zero_peoples_Return_Zero()
    {
        var amount = new TipPerPerson();
        var result = amount.tipPerPerson(10,0,10);
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void TipPerPerson_tipPerPerson_Method_When_Except_Zero_price_And_people_Return_Zero()
    {
        var amount = new TipPerPerson();
        var result = amount.tipPerPerson(0,0,10);
        Assert.AreEqual(0, result);
    }
}
