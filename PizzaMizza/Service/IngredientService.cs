using System;
using PizzaMizza.Abstraction;
using PizzaMizza.Helper;
using PizzaMizza.Models;
using System.Data;

namespace PizzaMizza.Service
{
	public class IngredientService
	{
        internal class IngeridientService : IService<Ingredient>
        {
            public void Add(Ingredient model)
            {
                SqlPizza.ExecCommand($"INSERT INTO Pizzas VALUES (N'{model.Name}')");
            }

            public void Delete(int Id)
            {
                SqlPizza.ExecCommand($"DELETE Pizzas WHERE Id = {Id}");
            }

            public List<Ingredient> GetAll()
            {
                DataTable dt = Sqlingredient.ExecQuery("SELECT * FROM Ingredients");

                List<Ingredient> ingredients = new List<Ingredient>();
                foreach (DataRow dr in dt.Rows)
                {
                    ingredients.Add(new Ingredient { Id = Convert.ToInt32(dr["Id"]), Name = dr["Name"].ToString() });
                }
                return ingredients;
            }

            public Ingredient GetById(int Id)
            {
                DataTable dt = Sqlingredient.ExecQuery("SELECT * FROM Ingredients");
                DataRow dr = dt.Rows[0];
                Ingredient ingredient = new Ingredient
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Name = dr["Name"].ToString()
                };
                return ingredient;
            }

            public void Update(Ingredient model)
            {
                SqlPizza.ExecCommand($"UPDATE Ingredients SET Name = {model.Name} WHERE Id={model.Id}");
            }
        }
    }
}

