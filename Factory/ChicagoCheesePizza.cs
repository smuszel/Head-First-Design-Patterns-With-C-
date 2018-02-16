public class ChicagoCheesePizza : Pizza
{
    public ChicagoCheesePizza()
    {
        name = "Chicago Style Deep Dish Cheese Pizza";
        dough = "Extra Thick Crust Dough";
        sauce = "Plum Tomato Sauce";

        toppings.Add("Shredded Mozzarella Cheese");
    }

    public override void Cut()
    {
        System.Console.WriteLine("Cutting the pizza into square slices");
    }
}