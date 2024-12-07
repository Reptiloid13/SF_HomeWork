namespace SF_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dirName = @" C:\Users\фвьшт\source\repos\SF HomeWork\SF HomeWork\Folder\";
            var span = TimeSpan.FromMinutes(30);
            var rootDirectory = new DirectoryInfo(dirName);

            if (!Directory.Exists(dirName)) throw new Exception("Папака не существует");

            Console.WriteLine("Folders");
            var dirs = Directory.GetDirectories(dirName);

            foreach (var dir in dirs)
            {
                Console.WriteLine(dir);
                Console.WriteLine();


            }

        }
    }
}
