using System;
using System.IO;

class Program
{
	static void Main()
	{
		string fileName = "log.txt";

		Console.Write("Введите имя пользователя: ");
		string userName = Console.ReadLine();

		// Формируем запись о событии
		string time = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
		string record = time + " - Пользователь " + userName + " вошёл в систему";

		// Добавляем новое событие в конец файла
		File.AppendAllText(fileName, record + Environment.NewLine);

		// Читаем и выводим весь журнал
		Console.WriteLine();
		Console.WriteLine("Журнал событий:");

		string[] lines = File.ReadAllLines(fileName);
		foreach (string line in lines)
		{
			Console.WriteLine(line);
		}
	}
}