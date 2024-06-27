namespace KentBeckTdd.MoneyExample;

public abstract class Money
{
    protected int Amount;

    private bool Equals(Money other)
    {
        return Amount == other.Amount;
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
    public Dollar(int amount)
    {
        Amount = amount;
    }

    public Dollar Times(int multiplier) => new(Amount * multiplier);
}

public class Pounds : Money
{
    public Pounds(int amount)
    {
        Amount = amount;
    }

    public Pounds Times(int multiplier) => new(Amount * multiplier);
}