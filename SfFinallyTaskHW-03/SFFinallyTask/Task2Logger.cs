using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFFinallyTask;


public interface ILogger
{
    void Event(string message);
    void Error(string message);
}

public class Logger : ILogger
{
    public void Error(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Ошибка: {message}");
        Console.ResetColor();
    }

    public void Event(string message)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Событие: {message}");
        Console.ResetColor();
    }
}
