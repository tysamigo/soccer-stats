﻿using System;
using System.IO;

namespace project_csharp_soccer_stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(directory.FullName, "SoccerGameResults.csv");
            var fileContents = ReadFile(fileName);
            string[] fileLines = fileContents.Split(new char[] { '\r', '\n'});
            foreach(var line in fileLines)
            {
                Console.WriteLine(line);
            }
            }

        public static string ReadFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
