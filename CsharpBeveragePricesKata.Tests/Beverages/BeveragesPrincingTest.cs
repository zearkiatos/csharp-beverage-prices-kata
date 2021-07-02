using System;
using Xunit;
using CsharpBeveragePricesKata.Beverages;

namespace CsharpBeveragePricesKata.Tests.Beverages
{
    public class BeveragesPrincingTest
    {
        [Fact]
        public void Should_Computes_Coffee_Price()
        {
            Beverage coffee = new Coffee();
            Assert.Equal(coffee.price(), 1.2);
        }

        [Fact]
        public void Should_Computes_Tea_Price()
        {
            Beverage tea = new Tea();
            Assert.Equal(tea.price(), 1.5);
        }

        [Fact]
        public void Should_Computes_Hot_Chocolate_Price()
        {
            Beverage hotChocolate = new HotChocolate();
            Assert.Equal(hotChocolate.price(), 1.45);
        }

        [Fact]
        public void Should_Computes_Tea_With_Milk_Price()
        {
            Beverage teaWithMilk = new TeaWithMilk(new Tea());
            Assert.Equal(teaWithMilk.price(), 1.6);
        }

        [Fact]
        public void Should_Computes_Coffee_With_Milk_Price()
        {
            Beverage coffeeWithMilk = new CoffeeWithMilk(new Coffee());
            Assert.Equal(coffeeWithMilk.price(), 1.3);
        }
        
        [Fact]
        public void Should_Computes_Coffee_With_Milk_And_Cream_Price()
        {
            Beverage coffeeWithMilkAndCream = new CoffeeWithMilkAndCream(new Coffee());
            Assert.Equal(coffeeWithMilkAndCream.price(), 1.45);
        }

        [Fact]
        public void Should_Computes_Hot_Chocolate_Milk_Cream_Price()
        {
            Beverage hotChocolateWithCream = new HotChocolateWithCream(new HotChocolate());
            Assert.Equal(hotChocolateWithCream.price(), 1.5999999999999999);
        }



    }
}

