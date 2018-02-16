public static class Factory
{
    public static Pizza NYPizza(string type)
    {
        switch (type)
        {
            case "cheese":
                return new NYCheesePizza();

            case "veggie":
                return new NYVeggiePizza();

            case "clam":
                return new NYClamPizza();

            case "pepperoni":
                return new NYPepperoniPizza();

            default:
                return null;
        }
    }

    public static Pizza ChicagoPizza(string type)
    {
        switch (type)
        {
            case "cheese":
                return new ChicagoCheesePizza();

            case "veggie":
                return new ChicagoVeggiePizza();

            case "clam":
                return new ChicagoClamPizza();

            case "pepperoni":
                return new ChicagoPepperoniPizza();

            default:
                return null;
        }
    }
}