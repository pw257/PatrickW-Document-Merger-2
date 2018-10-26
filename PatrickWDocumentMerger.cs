//using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PatrickWDocumentMerger.cs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path1 = @"C:\FileName.txt";
            string path2 = @"C:\FileName2";
            string newFilePath = @"C:\FileName3";

            Console.Write("Document Merger\n");

            Console.Write("Please enter your first file name:");
            Console.ReadLine();

            if (File.Exists(FileName))
                Console.WriteLine("File Exists");
            else
                Console.WriteLine("File does not exist, Please try again");

            Console.Write("Please enter your second file name:");
            Console.ReadLine();

            if (File.Exists(FileName2))
                Console.WriteLine("File Exists");
            else
                Console.WriteLine("File does not exist, please try again");

            string allText = System.IO.File.ReadAllText(path1);
            allText += "\r\n";
            allText += System.IO.File.ReadAllText(path2);

            using (FileStream fs = new FileStream(NewFilePath, FileMode.OpenOrCreate))
            {
                System.IO.File.WriteAllText(newFilePath, allText);
            }

            Console.Write("Would you like to merge two new files? \n");
            Console.ReadLine();
         
        }
    }
}
