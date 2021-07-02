namespace CsharpBeveragePricesKata.Beverages
{
    public class CoffeeWithMilk : Beverage
    {

        private double coffeePrice;

        const double MILK_PRICING = 0.10;

        public CoffeeWithMilk(Beverage coffee) 
        {
            this.coffeePrice = coffee.price();
        }
        public double price()
        {
            return this.coffeePrice + MILK_PRICING;
        }

    }
}