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
        if (obj.GetType() != this.GetType()) return false;
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

    public Money Times(int multiplier) => new Dollar(Amount * multiplier);
}

public class Pound : Money
{
    public Pound(int amount)
    {
        Amount = amount;
    }

    public Money Times(int multiplier) => new Pound(Amount * multiplier);
}