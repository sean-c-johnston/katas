using FluentAssertions;

namespace KentBeckTdd.MoneyExample;

public class DollarShould
{
    // $5 + £5 = $15 if rate is 2:1
    // handle fractional money
    // duplication of dollar/pounds
    // compare pounds to dollars

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

public class PoundsShould
{
    [Fact]
    public void MultiplyCorrectly()
    {
        var fivePounds = new Pounds(5);
        fivePounds.Times(2).Should().Be(new Pounds(10));
        fivePounds.Times(3).Should().Be(new Pounds(15));
    }

    [Fact]
    public void TestEquality()
    {
        new Pounds(5).Should().Be(new Pounds(5));
        new Pounds(5).Should().NotBe(new Pounds(10));
        
        new Pounds(5).Should().Be(new Dollar(5));
        new Pounds(5).Should().NotBe(new Dollar(10));
    }
}