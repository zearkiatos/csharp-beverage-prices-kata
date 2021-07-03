namespace CsharpBeveragePricesKata.Beverages
{
    public class Coffee : Beverage
    {
        const double COFFEE_PRICING = 1.2;
        private double cinnamonSupplementPrice = 0;

        public Coffee()
        {

        }

        public Coffee(Beverage cinnamonSupplement)
        {
            this.cinnamonSupplementPrice = cinnamonSupplement.price();
        }

        public double price()
        {
            return COFFEE_PRICING + this.cinnamonSupplementPrice;
        }
    }
}