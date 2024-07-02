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
        var product = Money.Dollar(5).Plus(Money.Dollar(5));
        //todo - more replacement with factories
        product.Should().Be(Money.Dollar(10));
        var product = Money.Dollars(5).Plus(Money.Dollars(5));
        product.Should().Be(Money.Dollars(10));
    }
    
    [Fact]
    public void MultiplyCorrectly()
    {
        var fiveDollars = new Money(5, "USD");
        fiveDollars.Times(2).Should().Be(new Money(10, "USD"));
        fiveDollars.Times(3).Should().Be(new Money(15, "USD"));
    }

    [Fact]
    public void TestEquality()
    {
        new Money(5, "USD").Should().Be(new Money(5, "USD"));
        new Money(5, "USD").Should().NotBe(new Money(10, "USD"));
        new Money(5, "GBP").Should().NotBe(new Money(5, "USD"));
    }

    [Fact]
    public void HaveACurrency()
    {
        new Money(5, "USD").Currency.Should().Be("USD");
    }
}