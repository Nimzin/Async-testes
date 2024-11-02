using System;
using System.Threading.Tasks;

public class Program
{
	public static async Task Main(string[] args)
	{
		await DoWorkAsync();
	}

	public static async Task DoWorkAsync()
	{
		Console.WriteLine("Starting work...");

		for (int i = 0; i < 5; i++)
		{
			Console.WriteLine($"Doing asynchronous work {i + 1}");
			await Task.Delay(1000); // Simulate work by delaying for 1 second asynchronously
		}

		var result = await LongRunningOperationAsync();
		Console.WriteLine("Result: " + result);
		Console.WriteLine("Work completed.");
	}

	public static async Task<string> LongRunningOperationAsync()
	{
		// Simulate a long-running operation
		await Task.Delay(5000); // Delay for 5 seconds asynchronously
		return "Operation Complete";
	}
}
