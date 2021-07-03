namespace CsharpBeveragePricesKata.Beverages
{
    public class CoffeeWithMilk : Beverage
    {

        private double coffeePrice;

        private double cinnamonSupplementPrice = 0;

        const double MILK_PRICING = 0.10;

        public CoffeeWithMilk(Beverage coffee) 
        {
            this.coffeePrice = coffee.price();
        }

        public CoffeeWithMilk(Beverage coffee, Beverage cinnamonSupplement) 
        {
            this.coffeePrice = coffee.price();
            this.cinnamonSupplementPrice = cinnamonSupplement.price();
        }
        public double price()
        {
            return this.coffeePrice + this.cinnamonSupplementPrice + MILK_PRICING;
        }

    }
}