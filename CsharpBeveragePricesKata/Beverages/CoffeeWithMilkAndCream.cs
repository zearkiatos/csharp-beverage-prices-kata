namespace CsharpBeveragePricesKata.Beverages
{
    public class CoffeeWithMilkAndCream : Coffee
    {
        public override double price()
        {
            return base.price() + 0.25;
        }
    }
}