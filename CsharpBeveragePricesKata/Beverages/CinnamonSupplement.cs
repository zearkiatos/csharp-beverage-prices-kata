namespace CsharpBeveragePricesKata.Beverages
{
    public class CinnamonSupplement : Beverage
    {
        const double CINNAMON_SUPPLEMENT_PRICING = 0.5;

        public double price()
        {
            return CINNAMON_SUPPLEMENT_PRICING;
        }
    }
}