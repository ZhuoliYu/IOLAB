using System.IO;
using System;
using System.Linq;

IOLAB.Directory savedDirectory = new IOLAB.Directory();
FileInfo theMachineStops = new FileInfo(savedDirectory.theMachineStops);

ReplacePeriodToSTOP(theMachineStops);
Console.ReadLine();

void ReplacePeriodToSTOP(FileInfo file)
{
    try
    {
        string result;
        using (StreamReader sr = file.OpenText())
        {
            var Content = sr.ReadToEnd();
            string[] words = Content.Split('.');
            result = String.Join("STOP", words);
        }
        using (StreamWriter sw = File.CreateText(savedDirectory.TelegramCopy))
        {
            sw.WriteLine(result);
        }
    }
    catch (IOException ex)
    {
        Console.WriteLine(ex.Message);
    }
}