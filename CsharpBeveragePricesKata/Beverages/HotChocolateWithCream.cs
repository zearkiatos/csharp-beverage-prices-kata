namespace CsharpBeveragePricesKata.Beverages
{
    public class HotChocolateWithCream : Beverage
    {
        const double MILK_PRICING = 0.15;

        private double hotChocolatePrice;

        private double cinnamonSupplementPrice = 0;

        public HotChocolateWithCream(Beverage hotChocolate) 
        {
            this.hotChocolatePrice = hotChocolate.price();
        }

        public HotChocolateWithCream(Beverage hotChocolate, Beverage cinnamonSupplement) 
        {
            this.hotChocolatePrice = hotChocolate.price();
            this.cinnamonSupplementPrice = cinnamonSupplement.price();
        }
        public double price()
        {
            return  this.hotChocolatePrice + this.cinnamonSupplementPrice + MILK_PRICING;
        }
    }
}