namespace SF_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo folder = new DirectoryInfo($@"{Environment.CurrentDirectory}");
            var span = TimeSpan.FromMinutes(30);

            if (!folder.Exists) throw new Exception("Folder don't exist");

            long totalFolderSize = folderSize(folder);
            Console.WriteLine("Folders");
            var dirs = folder.GetDirectories();
            foreach (var dir in dirs)
            {
                Console.WriteLine(dir);
                Console.WriteLine();
            }

            Console.WriteLine($"Total  folder size in bytes: {totalFolderSize}");

        }
        static long folderSize(DirectoryInfo folder)
        {
            long totalSizeOfDir = 0;
            FileInfo[] allFiles = folder.GetFiles();
            foreach (FileInfo file in allFiles)
            {
                totalSizeOfDir += file.Length;
            }
            DirectoryInfo[] subFolders = folder.GetDirectories();
            foreach (DirectoryInfo dir in subFolders)
            {
                totalSizeOfDir += folderSize(dir);
            }
            return totalSizeOfDir;
        }











        //if (!Directory.Exists(dirName)) throw new Exception("Папака не существует");

        //Console.WriteLine("Folders");
        //var dirs = Directory.GetDirectories(dirName);

        //foreach (var dir in dirs)
        //{
        //    Console.WriteLine(dir);
        //    Console.WriteLine();

        //    //if(Directory.GetLastWriteTime(dir)< DateTime.Now.AddSeconds(-1))
        //    //   {
        //    //       Directory.Delete(dir, true); 
        //    //   }
        //}


        //string[] files = Directory.GetFiles(dirName);
        //Console.WriteLine(string.Join(", ", files));
    }


}
