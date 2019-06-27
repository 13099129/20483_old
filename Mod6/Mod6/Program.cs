using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod6
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteData();
            //();
            //ReadXmlData();
            importFiles();
        }

        static string filepath = "c:\\allfiles\\mod6demo.txt";
        static void WriteData()
        {
            System.IO.File.WriteAllText(filepath, "this is a test");
        }

        static void ReadData()
        {
            string alltheData = System.IO.File.ReadAllText(filepath);
            string[] records = alltheData.Split('\n');
            foreach(string record in records)
            {
                Console.WriteLine(record);
            }
            //Console.WriteLine(alltheData);
            Console.ReadLine();
        }

        static void ReadDataWithStreamReader()
        {
            System.IO.StreamReader rdr = new System.IO.StreamReader(filepath);
            while (!rdr.EndOfStream)
            {
                Console.WriteLine(rdr.ReadLine());
                
            }
            rdr.Close();
            rdr.Dispose();
        }


        static void ReadXmlData()
        {
            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            doc.Load("c:\\allfiles\\data.xml");
            System.Xml.XmlNodeList people = doc.SelectNodes("//person");
            foreach(System.Xml.XmlNode person in people)
            {
                Console.WriteLine(person.InnerText);
               
            }
            Console.ReadLine();
        }


        static void importFiles()
        {
            string importPath = System.IO.Path.Combine("c:\\allfiles", "import");
            string importDirectory = @"c:\allfiles\import";
            System.IO.DirectoryInfo impDir = new System.IO.DirectoryInfo(importDirectory);
            foreach(System.IO.FileInfo currentFile in impDir.GetFiles("*.txt"))
            {
                Console.WriteLine(currentFile.Name);
                currentFile.MoveTo(currentFile.FullName + ".dne");
            }
            Console.ReadLine();
        }



    }
}
