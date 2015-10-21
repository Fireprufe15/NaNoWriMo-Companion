using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NaNoWriMo
{
    class FileManager
    {

        private const string FILENAME = "config/values.txt";

        public FileManager()
        { }

        public bool checkSaveFile()
        {
            return File.Exists(FILENAME);
        }

        public void createFile(string username, string secretcode)
        {

            Directory.CreateDirectory("config");
            FileStream file = new FileStream(FILENAME, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(file);
            sw.WriteLine(username);
            sw.WriteLine(secretcode);
            sw.Close();

        }

        public string[] returnValues()
        {
            FileStream file = new FileStream(FILENAME, FileMode.Open);
            StreamReader sr = new StreamReader(file);
            string values = sr.ReadToEnd();
            sr.Close();
            return values.Split('\n');
        }

        public void removeSaveFile()
        {
            File.Delete(FILENAME);
        }

    }
}
