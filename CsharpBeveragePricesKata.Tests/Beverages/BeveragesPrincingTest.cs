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


        [Fact]
        public void Should_Computes_Coffee_With_Optional_Cinnamon_Supplement_Price()
        {
            Beverage coffeeWithCinnamonSupplement = new Coffee(new CinnamonSupplement());
            Assert.Equal(coffeeWithCinnamonSupplement.price(), 1.7);
        }

        [Fact]
        public void Should_Computes_Tea_With_Optional_Cinnamon_Supplement_Price()
        {
            Beverage teaWithCinnamonSupplement = new Tea(new CinnamonSupplement());
            Assert.Equal(teaWithCinnamonSupplement.price(), 2);
        }

        [Fact]
        public void Should_Computes_Hot_Chocolate_With_Optional_Cinnamon_Supplement_Price()
        {
            Beverage hotChocolateWithCinnamonSupplement = new HotChocolate(new CinnamonSupplement());
            Assert.Equal(hotChocolateWithCinnamonSupplement.price(), 1.95);
        }

        [Fact]
        public void Should_Computes_Tea_With_Milk_With_Optional_Cinnamon_Supplement_Price()
        {
            Beverage teaWithMilkAndCinnamonSupplement = new TeaWithMilk(new Tea(), new CinnamonSupplement());
            Assert.Equal(teaWithMilkAndCinnamonSupplement.price(), 2.1);
        }

        [Fact]
        public void Should_Computes_Coffee_With_Milk_With_Optional_Cinnamon_Supplement_Price()
        {
            Beverage coffeeWithMilkAndCinnamonSupplement = new CoffeeWithMilk(new Coffee(), new CinnamonSupplement());
            Assert.Equal(coffeeWithMilkAndCinnamonSupplement.price(), 1.8);
        }

                
        [Fact]
        public void Should_Computes_Coffee_With_Milk_And_Cream_With_Optional_Cinnamon_Supplement_Price()
        {
            Beverage coffeeWithMilkAndCreamAndCinnamonSupplement = new CoffeeWithMilkAndCream(new Coffee(), new CinnamonSupplement());
            Assert.Equal(coffeeWithMilkAndCreamAndCinnamonSupplement.price(), 1.95);
        }

        [Fact]
        public void Should_Computes_Hot_Chocolate_Milk_Cream_With_Optional_Cinnamon_Supplement_Price()
        {
            Beverage hotChocolateWithCreamAndCinnamonSupplement = new HotChocolateWithCream(new HotChocolate(), new CinnamonSupplement());
            Assert.Equal(hotChocolateWithCreamAndCinnamonSupplement.price(), 2.1);
        }



    }
}

