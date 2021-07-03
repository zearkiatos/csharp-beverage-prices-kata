namespace CsharpBeveragePricesKata.Beverages
{
    public class HotChocolate : Beverage
    {
        const double HOT_CHOCOLATE_PRICING = 1.45;

        private double cinnamonSupplementPrice = 0;

        public HotChocolate()
        {

        }

        public HotChocolate(Beverage cinnamonSupplement)
        {
            this.cinnamonSupplementPrice = cinnamonSupplement.price();
        }
        public double price()
        {
            return HOT_CHOCOLATE_PRICING + this.cinnamonSupplementPrice;
        }
    }
}