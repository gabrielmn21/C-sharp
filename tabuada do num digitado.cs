using System;

class HelloWorld
{
	static void Main()
	{
		int num;

		do
		{
			try
			{
				Console.WriteLine("Digite o numero a ser calculado:");
				num = Int32.Parse(Console.ReadLine());

				Console.WriteLine($"Tabuada do {num}:");
				for (int i = 1; i <= 10; i++)
				{
					Console.WriteLine($"{num} x {i} = {num * i}");
				}

				
				break;
			}
			catch (FormatException)
			{
				Console.WriteLine("Digite um numero valido!");
			}
			catch (OverflowException)
			{
				Console.WriteLine("Numero muito grande! Tente um numero menor.");
			}
		} while (true);
	}
}
