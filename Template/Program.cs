class Program
{
    static void Main()
    {
        Tea tea = new Tea();
        Coffee coffee = new Coffee();

        System.Console.WriteLine("\nMaking tea...");
        tea.PrepareRecipe();

        System.Console.WriteLine("\nMaking coffee...");
        coffee.PrepareRecipe();
    }
}