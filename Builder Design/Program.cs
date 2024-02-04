namespace Builder_Design
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a Margherita pizza using the builder pattern
            IPizzaBuilder margheritaBuilder = new MargheritaPizzaBuilder();
            PizzaDirector director = new PizzaDirector(margheritaBuilder);

            director.ConstructPizza();
            Pizza margheritaPizza = margheritaBuilder.GetPizza();

            // Displaying the created pizza
            margheritaPizza.Display();
        }
    }
}