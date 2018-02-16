using System.Collections.Generic;
public abstract class Pizza
{
    public string name { get; set; }
    public string dough;
    public string sauce;
    public List<string> toppings = new List<string>();

    public virtual void Prepare()
    {
        System.Console.WriteLine($"Preparing {name}");
        System.Console.WriteLine("Tossing dough...");
        System.Console.WriteLine("Adding sauce...");
        System.Console.WriteLine("Adding toppings...");
        
        foreach (string topping in toppings)
        {
            System.Console.WriteLine("  " + topping);
        }
    }

    public virtual void Bake()
    {
        System.Console.WriteLine("Bake for 25 min at 350");
    }

    public virtual void Cut()
    {
        System.Console.WriteLine("Cutting into diagonal slices");
    }

    public virtual void Box()
    {
        System.Console.WriteLine($"Place pizza in official PizzaStore box");
    }
}