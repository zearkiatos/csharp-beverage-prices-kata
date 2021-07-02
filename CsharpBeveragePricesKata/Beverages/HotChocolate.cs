namespace CsharpBeveragePricesKata.Beverages
{
    public class HotChocolate : Beverage
    {
        const double HOT_CHOCOLATE_PRICING = 1.45;
        public double price()
        {
            return HOT_CHOCOLATE_PRICING;
        }
    }
}