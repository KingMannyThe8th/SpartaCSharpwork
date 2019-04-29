using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_45_file_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //CREATE NEW FILE FROM SCRATCH
            File.WriteAllText("file.txt", "some data");

            //read 1 line of text as a string 
            Console.WriteLine("\n\nRead raw data");
            string data = File.ReadAllText("file.txt");
            Console.WriteLine(data);

            //Write Data -overwrites original text (to "write" means to delete whats existing and put new content there !
            Console.WriteLine("\n\nwriting new text");
            File.WriteAllText("file.txt", "here is some new data");

            Console.WriteLine("\n\nreading text back again");
            data = File.ReadAllText("file.txt");
            Console.WriteLine(data);

            //append : ADDS AT END
            Console.WriteLine("\n\nAppending Text");
            File.AppendAllText("file.txt","\n\nhere is some new data 2");
            File.AppendAllText("file.txt","\n\nhere is some new data 3");
            File.AppendAllText("file.txt","\n\nhere is some new data 4");
            File.AppendAllText("file.txt","\n\nhere is some new data 5");
            File.AppendAllText("file.txt","\n\nhere is some new data 6");
           

            data = File.ReadAllText("file.txt");
            Console.WriteLine(data);

            //DATA LOGGING
            // append : adds at end

            Console.WriteLine("\n\nAppending Text");

            File.AppendAllText("file.txt", "\nand here is some more data 2 " + DateTime.Now.ToString());

            File.AppendAllText("file.txt", "\nand here is some more data 3 " + DateTime.Now.ToString());

            File.AppendAllText("file.txt", "\nand here is some more data 4 " + DateTime.Now);

            File.AppendAllText("file.txt", "\nand here is some more data 5 " + DateTime.Now.ToString());

            File.AppendAllText("file.txt", "\nand here is some more data 6 " + DateTime.Now.ToString());
            File.AppendAllText("file.txt", "\nsearchterm22");

            data = File.ReadAllText("file.txt");

            Console.WriteLine(data);





            // data logging : used all the time - add a DateTime.Now

            Console.WriteLine("\n\nLogging With DateTime Stamp");

            File.AppendAllText("file.txt", Environment.NewLine + DateTime.Now.ToString());

            data = File.ReadAllText("file.txt");

            Console.WriteLine(data);

            //Reading multiple lines to an array 
            string[] dataArray = File.ReadAllLines("file.txt");

            foreach(string item in dataArray)
            {
               if(item == "searchterm22")
                {
                    Console.WriteLine($"Bingo ! searchterm22 has been found at line !!!");
                }
            }

            for(int i = 0; i < dataArray.Length; i++)
            {
                if (dataArray[i] == "searchterm22")
                {
                    Console.WriteLine($"Bingo! searchterm22 found at line {i}");//the line number is not showing 
                }
            }

            //File.Copy - TRUE means YES, overrite if exists already 

            File.Copy("file.txt", "filecopy.txt", true);
            File.Delete("file.txt");
            File.Delete("filecopynewname.txt");
            

            if (!File.Exists("filecopynewname.txt"))
            {
                File.Move("filecopy.txt", "filecopynewname.txt");  //MOVE IS SIMILAR TO RENAMING A FILE 
            }

            Console.WriteLine(File.GetCreationTime("filecopy.txt"));
            Console.WriteLine(File.GetLastWriteTime("filecopy.txt"));
            
            //FOLDERS
            //CREATE FOLDER
            Directory.CreateDirectory("Parent");
            Directory.CreateDirectory("Parent\\Child1");
            Directory.CreateDirectory("Parent\\Child2");
            Directory.CreateDirectory("Parent\\Child3");
            File.WriteAllText("Parent\\Child3file.txt", "hello");
            File.WriteAllText("Parent/Child3/file.txt","hello");

            //delete one folder
            Directory.Delete($"Parent/Child2", true);

            //CREATE IN C:\ drive
            Directory.CreateDirectory("/TestFolder");

            var filepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);//FUTURE REFERENCE SAVE FILEPATH AS A VARIABLE
                                                                                            //TO USE LATER 

            //Create in MyDocuments 
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Test Folder");

            //List All Files in A folder and see if one file exists
            //LAB: Create a folder in My Documents 
            Directory.CreateDirectory(filepath + "\\LabPracticeFolder");
          
            //CREATE 3 TEXT FILES 
            File.WriteAllText(filepath + "\\LabPracticeFolder\\LabTextFile1.txt", "MORNING");
            File.WriteAllText(filepath + "\\LabPracticeFolder\\LabTextFile2.txt", "AFTERNOON");
            File.WriteAllText(filepath + "\\LabPracticeFolder\\LabTextFile3.txt", "EVENING");
            File.WriteAllText(filepath + "\\LabPracticeFolder\\bobsfile.txt", "MORNING");
            
            //CREATE AN ARRAY CALLED FILE LIST
            var FileList= Directory.EnumerateFiles(filepath + "\\LabPracticeFolder");
            //PUT THE NAMES OF THE TEXT FILES INTO THIS ARRAY
            foreach (var item in FileList)
            {
                
                if (item == filepath + "\\LabPracticeFolder\\bobsfile.txt")
                {
                    Console.WriteLine("We have found Bobsfile.txt!!");
                }
            }
           

        }
    }
}
