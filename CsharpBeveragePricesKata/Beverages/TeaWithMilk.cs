namespace CsharpBeveragePricesKata.Beverages
{
    public class TeaWithMilk : Beverage
    {
        const double MILK_PRICING = 0.10;
        private double teaPrice;

        private double cinnamonSupplementPrice = 0;

        public TeaWithMilk(Beverage tea)
        {
            this.teaPrice = tea.price();
        }

        public TeaWithMilk(Beverage tea, Beverage cinnamonSupplement)
        {
            this.teaPrice = tea.price();
            this.cinnamonSupplementPrice = cinnamonSupplement.price();
        }

        public double price()
        {
            return this.teaPrice + this.cinnamonSupplementPrice + MILK_PRICING;
        }
    }
}