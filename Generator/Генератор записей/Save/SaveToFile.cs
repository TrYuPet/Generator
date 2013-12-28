using System;
using System.IO;

namespace Save
{
    public class SaveToFile
    {
        static public void SaveRowsToFile(string nameOfFile, string[] rows)
        {
            var fileWriter = new StreamWriter(nameOfFile);
            var outputText = String.Join("\r\n", rows);
            fileWriter.WriteLine(outputText);
            fileWriter.Close();
        }
    }
}
