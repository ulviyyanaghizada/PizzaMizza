using PizzaMizza.Helper;
using PizzaMizza.Models;
using PizzaMizza.Service;

namespace PizzaMizza;
class Program
{
    static void Main(string[] args)
    {
        #region Pizza
        //SqlPizza.ExecCommand("INSERT INTO Pizzas VALUES ('Vegetarian',' ')")
        //Console.WriteLine(SqlPizza.ExecCommand("INSERT INTO Pizzas VALUES ('Vegetarian',' ')"));
        //PizzaService servicepizza = new PizzaService();
        //Pizza pizza = new Pizza() { Name = "Margarita", Image = " " };
        //servicepizza.Add(pizza);
        //servicepizza.Delete(2);
        // Console.WriteLine(servicepizza.GetById(1));
        //Pizza pizza = servicepizza.GetById(1);
        //pizza.Name = "Margarita";
        //servicepizza.Update(pizza);
        //foreach (Pizza item in servicepizza.GetAll())
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region Ingredient
        //Sqlingredient.ExecCommand("INSERT INTO Ingredient VALUES ('Biber')");
        //Console.WriteLine(Sqlingredient.ExecCommand("INSERT INTO Ingredient VALUES ('Mozarella pendiri')"));
        IngredientService ingredientservice = new IngredientService();
        //Pizza pizza = new Pizza() { Name = "Margarita" };
        //servicepizza.Add(pizza);
        //servicepizza.Delete(2);
        // Console.WriteLine(servicepizza.GetById(1));
        //Pizza pizza = servicepizza.GetById(1);
        //pizza.Name = "Margarita";
        //servicepizza.Update(pizza);
        //foreach (Ingredient item in servicepizza.GetAll())
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        Console.ReadLine();
    }
}

