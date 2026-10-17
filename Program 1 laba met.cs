	using System;

	class Program
	{
		static void Main()
		{
			Console.Write("Введите ваш возраст: ");
			int age = int.Parse(Console.ReadLine());

			if (age < 0 || age > 120)
			{
				Console.WriteLine("Некорректный возраст!");
			}
			else if (age <= 12)
			{
				Console.WriteLine("Период жизни: детство");
				Console.WriteLine("Рекомендация: больше играйте, учитесь и высыпайтесь.");
			}
			else if (age <= 17)
			{
				Console.WriteLine("Период жизни: подростковый возраст");
				Console.WriteLine("Рекомендация: развивайте свои интересы и не бойтесь просить совета у взрослых.");
			}
			else if (age <= 59)
			{
				Console.WriteLine("Период жизни: взрослая жизнь");
				Console.WriteLine("Рекомендация: следите за здоровьем и находите время для отдыха.");
			}
			else
			{
				Console.WriteLine("Период жизни: старость");
				Console.WriteLine("Рекомендация: больше гуляйте на свежем воздухе и проходите регулярные медосмотры.");
			}
		}
	}