
using System;

class Expense
{
    public string Category;
    public double Amount;

    public Expense(string category, double amount)
    {
        if (string.IsNullOrWhiteSpace(category))
            throw new ArgumentException("Category cannot be empty.");

        if (amount <= 0)
            throw new ArgumentException("Amount must be greater than zero.");

        Category = category;
        Amount = amount;
    }

    public void Display()
    {
        Console.WriteLine("Category: " + Category);
        Console.WriteLine("Amount: Rs. " + Amount);
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("--- Expense Tracking System ---");

            Console.Write("Enter expense category: ");
            string category = Console.ReadLine();

            Console.Write("Enter expense amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            Expense e = new Expense(category, amount);

            Console.WriteLine("\n--- Expense Details ---");
            e.Display();
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid numeric amount.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("\nExpense tracking operation completed.");
            Console.ReadLine();
        }
    }
}
