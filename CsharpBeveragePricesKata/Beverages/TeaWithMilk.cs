namespace CsharpBeveragePricesKata.Beverages
{
    public class TeaWithMilk : Tea
    {
        public override double price()
        {
            return base.price() + 0.10;
        }
    }
}