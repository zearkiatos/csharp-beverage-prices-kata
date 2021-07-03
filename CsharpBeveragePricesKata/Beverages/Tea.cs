namespace CsharpBeveragePricesKata.Beverages
{
    public class Tea : Beverage
    {
        const double TEA_PRICING = 1.5;

        private double cinnamonSupplementPrice = 0;

        public Tea()
        {

        }

        public Tea(Beverage cinnamonSupplement)
        {
            this.cinnamonSupplementPrice = cinnamonSupplement.price();
        }
        public double price()
        {
            return TEA_PRICING + this.cinnamonSupplementPrice;
        }
    }
}