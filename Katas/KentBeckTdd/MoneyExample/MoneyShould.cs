using FluentAssertions;

namespace KentBeckTdd.MoneyExample;

public class MoneyShould
{
    // $5 + £5 = $15 if rate is 2:1
    // handle fractional money

    [Fact]
    public void PerformComplexAddition()
    {
        
    }
    
    [Fact]
    public void PerformSimpleAddition()
    {
        var product = Money.Dollars(5).Plus(Money.Dollars(5));
        product.Should().Be(Money.Dollars(10));
    }
    
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
        Money.Pounds(5).Should().NotBe(Money.Dollars(5));
    }

    [Fact]
    public void HaveACurrency()
    {
        Money.Dollars(1).Currency.Should().Be("USD");
        Money.Pounds(1).Currency.Should().Be("GBP");
    }
}