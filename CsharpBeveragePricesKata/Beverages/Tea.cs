namespace CsharpBeveragePricesKata.Beverages
{
    public class Tea : Beverage
    {
        const double TEA_PRICING = 1.5;
        public double price()
        {
            return TEA_PRICING;
        }
    }
}