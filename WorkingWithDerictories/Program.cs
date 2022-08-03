string dirName = @"C:\"; // Any path with folders

var directory = new DirectoryInfo(dirName); // Gets info about given path of folder

if (directory.Exists) // Checks directory exists 
{
    #region Directories
    Console.WriteLine("Directory:");
    
    DirectoryInfo[] dirs = directory.GetDirectories(); // Gets all directories of given path
    foreach (DirectoryInfo dir in dirs) // Сycles through all directories
    {
        Console.WriteLine($"Directory name: {dir.Name}");
        Console.WriteLine($"Directory full name: {dir.FullName}");
        Console.WriteLine($"Creation time of directory: {dir.CreationTime}");
        Console.WriteLine($"Root directory: {dir.Root}");

        #region SubDirectories
        Console.WriteLine("SubDirectories:");
        var subDirectories = new DirectoryInfo(dir.FullName); // Gets info about given path of folder
        DirectoryInfo[] subDirs = subDirectories.GetDirectories(); // Gets all directories of given path
        foreach (DirectoryInfo subDir in subDirs) // Сycles through all subdirectories
        {
            Console.WriteLine($"\tSubDirectory name: {subDir.Name}");
            Console.WriteLine($"\tSubDirectory full name: {subDir.FullName}");
            Console.WriteLine($"\tCreation date of subdirectory: {subDir.CreationTime}");
            Console.WriteLine($"\tRoot directory: {subDir.Root}");
            Console.WriteLine("\t" + new string('-', 25));
        }
        #endregion
        Console.WriteLine(new string('-', 25));
    }
    Console.WriteLine();
    #endregion

    Console.WriteLine("Files:");
    FileInfo[] files = directory.GetFiles(); // Gets all files of given directory
    foreach (FileInfo file in files) // Сycles through file info
    {
        Console.WriteLine(file.FullName);
    }
}