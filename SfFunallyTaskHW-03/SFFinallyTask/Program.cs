namespace SFFinallyTask;

public class Program
{
    static void Main(string[] args)
    {
        ILogger logger = new Logger();

        Calculator calculator = new Calculator(logger); // здесь показывает ошибку - почему? 
        try
        {
            logger.Event("Начало работы калькулятора");
            Console.WriteLine("Введите первое число -  ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число - ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            logger.Event($"Выполняется операция сложения: {num1}+{num2} ");
            calculator.Add(num1, num2);
            logger.Event($"Результат: {calculator.GetResult()}");

        }
        catch (FormatException)
        {
            logger.Error("Ошибка: Введите корректное числовое  значение");
        }

        finally
        {
            Console.WriteLine("Программа завершена");
            logger.Event("Завершена работа калькулятора");
        }


    }

}


