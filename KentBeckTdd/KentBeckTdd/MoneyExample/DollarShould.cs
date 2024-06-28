using FluentAssertions;

namespace KentBeckTdd.MoneyExample;

public class DollarShould
{
    // $5 + £5 = $15 if rate is 2:1
    // handle fractional money
    // duplication of dollar/pounds
        // common times method
    // duplication of test classes
    // avoid using classes in equality, prefer to tie it to a domain concern
    

    // // compare pounds to dollars
    // // want to make Amount private
    // // $5 * 2 = $10
    // // want to avoid mutating dollar

    [Fact]
    public void MultiplyCorrectly()
    {
        var fiveDollars = Money.Dollars(5);
        fiveDollars.Times(2).Should().Be(Money.Dollars(10));
        fiveDollars.Times(3).Should().Be(Money.Dollars(15));
    }

    [Fact]
    public void TestEquality()
    {
        Money.Dollars(5).Should().Be(Money.Dollars(5));
        Money.Dollars(5).Should().NotBe(Money.Dollars(10));
    }

    [Fact]
    public void HaveACurrency()
    {
        Money.Dollars(5).Currency.Should().Be("USD");
    }
}

public class PoundsShould
{
    [Fact]
    public void MultiplyCorrectly()
    {
        var fivePounds = Money.Pounds(5);
        fivePounds.Times(2).Should().Be(Money.Pounds(10));
        fivePounds.Times(3).Should().Be(Money.Pounds(15));
    }

    [Fact]
    public void CompareToItself()
    {
        Money.Pounds(5).Should().Be(Money.Pounds(5));
        Money.Pounds(5).Should().NotBe(Money.Pounds(10));
    }

    [Fact]
    public void CompareToDollars()
    {
        Money.Pounds(5).Should().NotBe(Money.Dollars(5));
    }
    
    
    [Fact]
    public void HaveACurrency()
    {
        Money.Pounds(5).Currency.Should().Be("GBP");
    }
}
