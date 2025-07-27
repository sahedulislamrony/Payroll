using System;
using System.IO;
using System.Collections.Generic;

namespace JUSTPayroll.DB
{
    public static class FileManager
    {
        //actual path 
        //private static readonly string DataDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");

        // for testing purpose
        private static readonly string DataDirectory = @"D:\sahedul\JUSTPayroll\Data";

        static FileManager()
        {
            // Ensure data directory exists
            if (!Directory.Exists(DataDirectory))
            {
                Directory.CreateDirectory(DataDirectory);
            }
            Console.WriteLine($"Data Directory: {DataDirectory}");
        }

        public static string GetEmployeeFilePath()
        {
            return Path.Combine(DataDirectory, "Employee.txt");
        }

        public static string GetSalaryFilePath(string month)
        {
            return Path.Combine(DataDirectory, $"Salary.{month}.txt");
        }
        public static string GetDataDirectory()
        {
            return Path.Combine(DataDirectory);
        }

        public static void WriteToFile(string filePath, string content, bool append = true)
        {
            try
            {
                if (append)
                {
                    File.AppendAllText(filePath, content + Environment.NewLine);
                }
                else
                {
                    File.WriteAllText(filePath, content);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error writing to file: {ex.Message}");
            }
        }
        
        public static List<string> ReadFromFile(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    return new List<string>();
                }

                var lines = File.ReadAllLines(filePath);
                var result = new List<string>();
                
                foreach (var line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        result.Add(line.Trim());
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error reading from file: {ex.Message}");
            }
        }

        public static bool FileExists(string filePath)
        {
            return File.Exists(filePath);
        }

        public static void CreateFileIfNotExists(string filePath)
        {
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
        }
    }
}
