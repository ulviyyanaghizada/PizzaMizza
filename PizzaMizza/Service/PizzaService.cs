using System;
using System.Data;
using PizzaMizza.Abstraction;
using PizzaMizza.Helper;
using PizzaMizza.Models;

namespace PizzaMizza.Service
{
    internal class PizzaService : IService<Pizza>
    {
        public void Add(Pizza model)
        {
            SqlPizza.ExecCommand($"INSERT INTO Pizzas VALUES (N'{model.Name}', N'{model.Image}')");
        }

        public void Delete(int Id)
        {
            SqlPizza.ExecCommand($"DELETE Pizzas WHERE Id = {Id}");
        }

        public List<Pizza> GetAll()
        {
            DataTable dt = SqlPizza.Execquery("SELECT * FROM Pizzas");

            List<Pizza> pizzas = new List<Pizza>();
            foreach (DataRow dr in dt.Rows)
            {
                pizzas.Add(new Pizza { Id = Convert.ToInt32(dr["Id"]), Name = dr["Name"].ToString(), Image = dr["Image"].ToString() });
            }
            return pizzas;
        }

        public Pizza GetById(int Id)
        {
            DataTable dt = SqlPizza.Execquery("SELECT * FROM Pizzas");
            DataRow dr = dt.Rows[0];
            Pizza pizza = new Pizza
            {
                Id = Convert.ToInt32(dr["Id"]),
                Name = dr["Name"].ToString(),
                Image = dr["Image"].ToString()
            };
            return pizza;
        }

        public void Update(Pizza model)
        {
            SqlPizza.ExecCommand($"UPDATE Pizzas SET Name = {model.Name} WHERE Id={model.Id}");
        }
    }
}

