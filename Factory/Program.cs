class Program
{
    static void Main()
    {
        PizzaStore nyStore = new PizzaStore(Factory.NYPizza);
        PizzaStore chicagoStore = new PizzaStore(Factory.ChicagoPizza);

        Pizza pizza = nyStore.OrderPizza("cheese");
        System.Console.WriteLine($"Ethan ordered a {pizza.name}\n");

        pizza = chicagoStore.OrderPizza("cheese");
        System.Console.WriteLine($"Joel ordered a {pizza.name}\n");
    }
}

