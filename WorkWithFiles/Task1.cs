using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WorkWithFiles


public class WorkWithFiles
{
    public void Task1()
    {

        DirectoryInfo folder = new DirectoryInfo($"{Environment.CurrentDirectory}");
        var span = TimeSpan.FromMinutes(30);
        //var rootDirectory = new DirectoryInfo(folder);

        if (!folder.Exists) throw new Exception("Папака не существует");

        Console.WriteLine("Folders: ");
        var dirs = folder.GetDirectories();

        foreach (var dir in dirs)
        {
            Console.WriteLine(dir.FullName);
            Console.WriteLine();
        }

        Console.WriteLine("Files: ");

        var files = folder.GetFiles("*", SearchOption.AllDirectories);

        foreach (var file in files)
        {
            Console.WriteLine();
            Console.WriteLine(file.FullName);
        }

    }
}
