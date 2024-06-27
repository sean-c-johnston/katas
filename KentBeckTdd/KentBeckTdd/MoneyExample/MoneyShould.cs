using FluentAssertions;

namespace KentBeckTdd.MoneyExample;

public class MoneyShould
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

        var tenDollars = fiveDollars.Times(2);
        tenDollars.Should().Be(new Dollar(10));

        var fifteenDollars = fiveDollars.Times(3);
        fifteenDollars.Should().Be(new Dollar(15));
    }

    [Fact]
    public void TestEquality()
    {
        new Dollar(5).Should().Be(new Dollar(5));
    }
}

public class Dollar(int amount)
{
    private readonly int _amount = amount;
    public Dollar Times(int multiplier) => new(_amount * multiplier);

    protected bool Equals(Dollar other)
    {
        return _amount == other._amount;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Dollar)obj);
    }

    public override int GetHashCode()
    {
        return _amount;
    }
}