namespace CsharpBeveragePricesKata.Beverages
{
    public class CoffeeWithMilkAndCream : Beverage
    {
        private double coffeePrice;
        const double MILK_AND_CREAM_PRICING = 0.25;

        public CoffeeWithMilkAndCream(Beverage coffee) 
        {
            this.coffeePrice = coffee.price();
        }
        public double price()
        {
            return this.coffeePrice + MILK_AND_CREAM_PRICING;
        }
    }
}