using FluentAssertions;

namespace KentBeckTdd.MoneyExample;

public class DollarShould
{
    // $5 + £5 = $15 if rate is 2:1
    // handle fractional money
    

    // // duplication of dollar/pounds
    // // duplication of test classes
    // // common times method
    // // avoid using classes in equality, prefer to tie it to a domain concern
    // // compare pounds to dollars
    // // want to make Amount private
    // // $5 * 2 = $10
    // // want to avoid mutating dollar

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