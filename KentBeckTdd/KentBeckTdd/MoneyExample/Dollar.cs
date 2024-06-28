namespace KentBeckTdd.MoneyExample;

public class Money
{
    protected int Amount;

    public override string ToString()
    {
        return $"{Currency} {Amount}";
    }

    public Money(int amount, string currency)
    {
        Amount = amount;
        Currency = currency;
    }
    
    public string? Currency { get; set; }

    public Money Times(int multiplier) => null!;

    private bool Equals(Money other)
    {
        return Amount == other.Amount
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
        return Amount;
    }
}

public class Dollar : Money
{
    public Dollar(int amount, string currency) : base(amount, currency)
    {
    }

    public Money Times(int multiplier) => new Money(Amount * multiplier, Currency!);
}

public class Pound : Money
{
    public Pound(int amount, string currency) : base(amount, currency)
    {
    }
    
    public Money Times(int multiplier) => new Money(Amount * multiplier, Currency!);
}