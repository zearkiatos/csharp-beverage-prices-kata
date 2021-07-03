namespace CsharpBeveragePricesKata.Beverages
{
    public class CoffeeWithMilkAndCream : Beverage
    {
        private double coffeePrice;
        private double cinnamonSupplementPrice = 0;
        const double MILK_AND_CREAM_PRICING = 0.25;

        public CoffeeWithMilkAndCream(Beverage coffee) 
        {
            this.coffeePrice = coffee.price();
        }

        public CoffeeWithMilkAndCream(Beverage coffee, Beverage cinnamonSupplement) 
        {
            this.coffeePrice = coffee.price();
            this.cinnamonSupplementPrice = cinnamonSupplement.price();
        }
        public double price()
        {
            return this.coffeePrice +  this.cinnamonSupplementPrice + MILK_AND_CREAM_PRICING;
        }
    }
}