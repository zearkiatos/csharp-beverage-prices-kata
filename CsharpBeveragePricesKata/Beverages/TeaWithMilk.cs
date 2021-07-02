namespace CsharpBeveragePricesKata.Beverages
{
    public class TeaWithMilk : Beverage
    {
        const double MILK_PRICING = 0.10;
        private double teaPrice;

        public TeaWithMilk(Beverage tea)
        {
            this.teaPrice = tea.price();
        }

        public double price()
        {
            return teaPrice + MILK_PRICING;
        }
    }
}