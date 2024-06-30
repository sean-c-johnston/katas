using FluentAssertions;

namespace KentBeckTdd.MoneyExample;

public class MoneyShould
{
    // $5 + £5 = $15 if rate is 2:1
    // $5 + $5 = $10
    // handle fractional money

    [Fact]
    public void AddCorrectly()
    {
        var product = new Money(5, "USD").Add(new Money(5, "USD"));
        
        product.Should().Be(new Money(10, "USD"));
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