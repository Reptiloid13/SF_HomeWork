using System;
using System.Security.Cryptography.X509Certificates;

namespace Task2;
public class LastNamesCollection
{
    public List<String> Items { get; set; } = new List<String>();



    public LastNamesCollection()
    {
        InitList();
    }

    private void InitList()
    {
        Items.Add("Ivan");
        Items.Add("Vasiliy");
        Items.Add("Petr");
        Items.Add("John");
        Items.Add("Franchesco");

    }

    public void Sort(Byte mode)
    {
        switch ((SortModeEnum)mode)
        {
            case SortModeEnum.Asc:
                Items = Items.OrderBy(x => x).ToList();
                break;

            default:
                Items = Items.OrderByDescending(x => x).ToList(); break;
        }
    }
}

public enum SortModeEnum : Byte
{
    Asc = 1,
    Desc
}

public class WrongNumberException : Exception
{
    public WrongNumverException() : base("Wrong number entered") { }
}

