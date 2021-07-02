namespace CsharpBeveragePricesKata.Beverages
{
    public class HotChocolateWithCream : Beverage
    {
        const double MILK_PRICING = 0.15;

        private double hotChocolatePrice;

        public HotChocolateWithCream(Beverage hotChocolate) 
        {
            this.hotChocolatePrice = hotChocolate.price();
        }
        public double price()
        {
            return  this.hotChocolatePrice + MILK_PRICING;
        }
    }
}