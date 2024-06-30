namespace KentBeckTdd.MoneyExample;

public class Money(int amount, string currency)
{
    private readonly int _amount = amount;
    public string Currency { get; } = currency;

    public Money Add(Money money)
    {
        return new Money(_amount + money._amount, Currency);
    }

    public Money Times(int multiplier) => new(_amount * multiplier, Currency);

    private bool Equals(Money other)
    {
        return _amount == other._amount
            && Currency == other.Currency;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return Equals((Money)obj);
    }

    public override int GetHashCode()
    {
        return _amount;
    }

    public override string ToString()
    {
        return $"{Currency} {_amount}";
    }
}