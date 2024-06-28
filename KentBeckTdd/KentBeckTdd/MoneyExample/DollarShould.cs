using FluentAssertions;

namespace KentBeckTdd.MoneyExample;

public class DollarShould
{
    // $5 + £5 = $15 if rate is 2:1
    // handle fractional money
    // duplication of dollar/pounds
        // common times method
    // duplication of test classes
    

    // // avoid using classes in equality, prefer to tie it to a domain concern
    // // compare pounds to dollars
    // // want to make Amount private
    // // $5 * 2 = $10
    // // want to avoid mutating dollar

    [Fact]
    public void MultiplyCorrectly()
    {
        var fiveDollars = new Dollar(5, "USD");
        fiveDollars.Times(2).Should().Be(new Dollar(10, "USD"));
        fiveDollars.Times(3).Should().Be(new Dollar(15, "USD"));
    }

    [Fact]
    public void TestEquality()
    {
        new Dollar(5, "USD").Should().Be(new Dollar(5, "USD"));
        new Dollar(5, "USD").Should().NotBe(new Dollar(10, "USD"));
    }

    [Fact]
    public void HaveACurrency()
    {
        new Dollar(5, "USD").Currency.Should().Be("USD");
    }
}

public class PoundsShould
{
    [Fact]
    public void MultiplyCorrectly()
    {
        var fivePounds = new Pound(5, "GBP");
        fivePounds.Times(2).Should().Be(new Pound(10, "GBP"));
        fivePounds.Times(3).Should().Be(new Pound(15, "GBP"));
    }

    [Fact]
    public void CompareToItself()
    {
        new Pound(5, "GBP").Should().Be(new Pound(5, "GBP"));
        new Pound(5, "GBP").Should().NotBe(new Pound(10, "GBP"));
    }

    [Fact]
    public void CompareToDollars()
    {
        new Pound(5, "GBP").Should().NotBe(new Dollar(5, "USD"));
    }
    
    
    [Fact]
    public void HaveACurrency()
    {
        new Pound(5, "GBP").Currency.Should().Be("GBP");
    }
}
