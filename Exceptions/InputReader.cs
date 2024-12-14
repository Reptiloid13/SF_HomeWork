using System;
using Task2;
namespace Task2;
public class InputReader
{
    public delegate void NumberEnterDelegate(Byte input);

    public event NumberEnterDelegate NumberEnter;

    public void ReeadInput()
    {
        Boolean isInputCorrect = false;
        Byte inp = 0;

        while (!isInputCorrect)
        {
            try
            {
                Console.WriteLine("Enter sort mode: 1 - Ascending, 2 - Descending");

                if (Byte.TryParse(Console.ReadLine(), out inp)
                    && (inp == 1 || inp == 2))
                {
                    isInputCorrect = true;
                    NumberEnter?.Invoke(inp);
                }
                else
                {
                    throw new WrongNumberException();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}


