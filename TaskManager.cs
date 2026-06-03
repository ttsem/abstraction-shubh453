using System;

public interface IPrinter
{
    void Print();
}

public interface IScanner
{
    void Scan();
}

public class Printer : IPrinter
{
    public void Print()
    {
        Console.WriteLine("Printing document...");
    }
}

public class Scanner : IScanner
{
    public void Scan()
    {
        Console.WriteLine("Scanning document...");
    }
}

public class TaskManager
{
    private readonly IPrinter _printer;
    private readonly IScanner _scanner;
    public TaskManager()
    {
        _printer = new Printer();
        _scanner = new Scanner();
    }

    public void PrintTask(int taskId)
    {
        Console.WriteLine($"Executing Print Task: {taskId}");
        _printer.Print();
    }

    public void ScanTask(int taskId)
    {
        Console.WriteLine($"Executing Scan Task: {taskId}");
        _scanner.Scan();
    }
}

public class Program
{
    public static void Main()
    {
        var scheduler = new TaskManager();

        scheduler.PrintTask(101);
        scheduler.ScanTask(102);
    }
}
