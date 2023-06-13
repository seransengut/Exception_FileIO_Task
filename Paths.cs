namespace Exception__and__Filefunction
{
    public class Paths
    {
        public static void path()
        {
            //path.combine
            string directory = @"C:\C# Seran Works\c# notepad\alpha.txt";
            string fileName = "alpha.txt";
            string fullPath = Path.Combine(directory, fileName);
            Console.WriteLine("Combined path: " + fullPath + "\n");


            //path.extension
            string extension1 = Path.GetExtension(directory);
            Console.WriteLine("File extension: " + extension1 + "\n");


            //path.filename
            string fileName2 = Path.GetFileName(directory);
            Console.WriteLine("File name: " + fileName2 + "\n");


            //path.directoryname
            string directoryName3 = Path.GetDirectoryName(directory);
            Console.WriteLine("Directory name: " + directoryName3 + "\n");


            //path.fullpath
            string fullPath4 = Path.GetFullPath(directory);
            Console.WriteLine("Full path: " + fullPath4 + "\n");

            //path.randomFileName
            string randomFileName = Path.GetRandomFileName();
            Console.WriteLine("Random file name: " + randomFileName + "\n");

            //path.tempFileName
            string tempFileName = Path.GetTempFileName();
            Console.WriteLine("Temporary file name: " + tempFileName + "\n");

            //path.tempFolderPath
            string tempFolderPath = Path.GetTempPath();
            Console.WriteLine("Temporary folder path: " + tempFolderPath + "\n");

            //path.IsPathRooted
            string absolutePath = directory;
            string relativePath = @"C:\C# Seran Works\c# notepad\out and ref.txt";
            Console.WriteLine("Is rooted: " + Path.IsPathRooted(absolutePath));
            Console.WriteLine("Is rooted: " + Path.IsPathRooted(relativePath) + "\n");


            //path.ChangeExtension
            string newFilePath = Path.ChangeExtension(directory, ".csv");
            Console.WriteLine("New file path: " + newFilePath);

        }

    }
}
