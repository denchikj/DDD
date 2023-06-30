namespace DomainDrivenDesign.ValueObjects
{
    public sealed record Quantity(decimal Value)
    {
        public override string ToString() => Value.ToString();
    }
}