namespace RazorPizzeria.Models
{
    public class PizzasModel
    {
		public string ImageTitle { get; set; }
		public string PizzaName { get; set; }
		public float BasePrice { get; set; } = 2;

		public bool TomatoSauce { get; set; }
		public bool Cheese { get; set; }
		public bool Pepperoni { get; set; }
		public bool Mushroom { get; set; }
		public bool Tuna { get; set; }
		public bool Pineapple { get; set; }
		public bool Ham { get; set; }
		public bool Beef { get; set; }

		public float FinalPrice { get; set; }

		public float CalculateFinalPrice(PizzasModel Pizza)
		{
			Pizza.FinalPrice = BasePrice;

			if (Pizza.TomatoSauce) Pizza.FinalPrice += 1;
			if (Pizza.Cheese) Pizza.FinalPrice += 1;
			if (Pizza.Pepperoni) Pizza.FinalPrice += 1;
			if (Pizza.Mushroom) Pizza.FinalPrice += 1;
			if (Pizza.Tuna) Pizza.FinalPrice += 1;
			if (Pizza.Pineapple) Pizza.FinalPrice += 100;
			if (Pizza.Ham) Pizza.FinalPrice += 1;
			if (Pizza.Beef) Pizza.FinalPrice += 1;

			return FinalPrice;
		}

	}
}
