using System;
namespace PizzaMizza.Models
{
	public class Pizza
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Image { get; set; }

        public override string ToString()
        {
            return Id + ". " + Name + " " + Image;
        }
    }
}

