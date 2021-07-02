namespace CsharpBeveragePricesKata.Beverages
{
    public class Coffee : Beverage
    {
        const double COFFEE_PRICING = 1.2;
        public double price()
        {
            return COFFEE_PRICING;
        }
    }
}