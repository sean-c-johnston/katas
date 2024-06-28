namespace KentBeckTdd.MoneyExample;

public abstract class Money
{
    protected int Amount;
    public string? Currency { get; set; }

    public static Money Dollars(int amount) => new Dollar(amount, "USD");
    public static Money Pounds(int amount) => new Pound(amount, "GBP");

    public abstract Money Times(int multiplier);

    private bool Equals(Money other)
    {
        return Amount == other.Amount;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((Money)obj);
    }

    public override int GetHashCode()
    {
        return Amount;
    }
}

public class Dollar : Money
{
    public Dollar(int amount, string currency)
    {
        Amount = amount;
        Currency = currency;
    }

    public override Money Times(int multiplier) => Dollars(Amount * multiplier);
}

public class Pound : Money
{
    public Pound(int amount, string currency)
    {
        Amount = amount;
        Currency = currency;
    }

    public override Money Times(int multiplier) => Pounds(Amount * multiplier);
}