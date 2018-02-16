using System;
public class PizzaStore
{
    public delegate Pizza PizzaCreationHandler(string type);
    public PizzaCreationHandler pizzaCreation;
    public PizzaStore(PizzaCreationHandler pizzaCreation)
    {
        this.pizzaCreation = pizzaCreation;
    }
    public Pizza OrderPizza(string type)
    {
        Pizza pizza = pizzaCreation(type);

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }
}