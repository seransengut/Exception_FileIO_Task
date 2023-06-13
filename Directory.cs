namespace Exception__and__Filefunction
{
    public class Directory
    {
        public static void directory()
        {
            //Directory.exists
            string directoryPath1 = @"C:\C# Seran Works\c# notepad";
            DirectoryInfo directoryInfo1 = new DirectoryInfo(directoryPath1);
            if (directoryInfo1.Exists)
            {
                Console.WriteLine("Directory exists" + "\n");
            }
            else
            {
                Console.WriteLine("Directory does not exist" + "\n");
            }


            //Directory.Name
            string directoryPath2 = directoryPath1;
            DirectoryInfo directoryInfo2 = new DirectoryInfo(directoryPath2);
            string directoryName = directoryInfo2.Name;
            Console.WriteLine("Directory name: " + directoryName + "\n");



            //Directory.FullName
            string directoryPath3 = directoryPath1;
            DirectoryInfo directoryInfo3 = new DirectoryInfo(directoryPath3);
            string fullPath = directoryInfo3.FullName;
            Console.WriteLine("Full path: " + fullPath + "\n");



            //Directory.Parent
            string directoryPath4 = @"C:\C# Seran Works\c# notepad\alpha.txt";
            DirectoryInfo directoryInfo4 = new DirectoryInfo(directoryPath4);
            DirectoryInfo parentDirectory = directoryInfo4.Parent;
            Console.WriteLine("Parent directory: " + parentDirectory.FullName + "\n");



            //Directory.GetFiles
            string directoryPath5 = @"\\192.168.0.5\vaf\task\EXCEL";
            DirectoryInfo directoryInfo5 = new DirectoryInfo(directoryPath5);
            FileInfo[] files = directoryInfo5.GetFiles();
            foreach (FileInfo file in files)
            {
                Console.WriteLine("File: " + file.Name);
            }
            Console.WriteLine();



            //Directory.Create
            string directoryPath6 = @"C:\C# Seran Works\c# Seniors\Seniors Tasks\Exception  and  Filefunction\Directory create\subdirectory folder";
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath6);
            directoryInfo.Create();
            Console.WriteLine("directory folder creating" + "\n");



             //Directory.Delete
             string directoryPath7 = @"C:\C# Seran Works\c# Seniors\Seniors Tasks\Exception  and  Filefunction\Directory delete\Subdirectory delete";
             DirectoryInfo directoryInfo7 = new DirectoryInfo(directoryPath7);
             directoryInfo7.Delete();
             Console.WriteLine("deleting a folder" + "\n");



            //Directory.LastWriteTime
            string directoryPath8 = @"C:\C# Seran Works\c# notepad\alpha.txt";
            DirectoryInfo directoryInfo8 = new DirectoryInfo(directoryPath8);
            DateTime lastWriteTime = directoryInfo8.LastWriteTime;
            Console.WriteLine("Last write time: " + lastWriteTime + "\n");



            //Directory.creationTime
            string directoryPath9 = @"C:\C# Seran Works\c# notepad\alpha.txt";
            DirectoryInfo directoryInfo9 = new DirectoryInfo(directoryPath9);
            DateTime creationTime = directoryInfo9.CreationTime;
            Console.WriteLine("creation Time: " + creationTime + "\n");

        }
    }
}
