namespace CsharpBeveragePricesKata.Beverages
{
    public class HotChocolateWithCream : HotChocolate
    {
        public override double price()
        {
            return 1.45 + 0.15;
        }
    }
}