using System;

class Order
{
	public string DishName;
	public int Quantity;
	public double Price;

	public Order(string dishName, int quantity, double price)
	{
		DishName = dishName;
		Quantity = quantity;
		Price = price;
	}

	// Расчёт общей стоимости заказа
	public double GetTotalCost()
	{
		return Quantity * Price;
	}

	// Вывод информации о заказе
	public void PrintInfo()
	{
		Console.WriteLine("Блюдо: " + DishName);
		Console.WriteLine("Количество порций: " + Quantity);
		Console.WriteLine("Цена за порцию: " + Price);
		Console.WriteLine("Общая стоимость: " + GetTotalCost());
	}
}

class Program
{
	static void Main()
	{
		Console.Write("Введите название блюда: ");
		string name = Console.ReadLine();

		Console.Write("Введите количество порций: ");
		int quantity = int.Parse(Console.ReadLine());

		Console.Write("Введите цену за порцию: ");
		double price = double.Parse(Console.ReadLine());

		Order order = new Order(name, quantity, price);

		Console.WriteLine();
		order.PrintInfo();
	}
}