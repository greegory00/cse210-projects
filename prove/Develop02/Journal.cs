using System;
using System.IO;

public class Journal
{

    public string _write;
    public string _display;

    
    public void Write()
    {
        Console.WriteLine($"{_write}");
        string w = Console.ReadLine();
    }



    public void Display()
    {
    
        Console.WriteLine($"Date: 00/0/0000 - {_write}");
    
    }

}

class Save
{

    static void Main()
    {
        string filename = "file.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
        }
    }


}