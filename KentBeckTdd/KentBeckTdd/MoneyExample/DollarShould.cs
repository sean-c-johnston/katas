using FluentAssertions;

namespace KentBeckTdd.MoneyExample;

public class DollarShould
{
    // $5 + £5 = $15 if rate is 2:1
    // handle fractional money

    // // want to make Amount private
    // // $5 * 2 = $10
    // // want to avoid mutating dollar

    [Fact]
    public void MultiplyCorrectly()
    {
        var fiveDollars = new Dollar(5);
        fiveDollars.Times(2).Should().Be(new Dollar(10));
        fiveDollars.Times(3).Should().Be(new Dollar(15));
    }

    [Fact]
    public void TestEquality()
    {
        new Dollar(5).Should().Be(new Dollar(5));
        new Dollar(5).Should().NotBe(new Dollar(10));
    }
}