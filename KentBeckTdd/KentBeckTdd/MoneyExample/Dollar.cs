namespace KentBeckTdd.MoneyExample;

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