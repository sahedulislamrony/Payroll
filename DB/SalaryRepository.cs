using System;
using System.Collections.Generic;
using System.Linq;
using JUSTPayroll.Models;

namespace JUSTPayroll.DB
{
    public class SalaryRepository
    {
        public static void AddSalary(Salary salary)
        {
            try
            {
                var filePath = FileManager.GetSalaryFilePath(salary.Month);
                FileManager.WriteToFile(filePath, salary.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding salary: {ex.Message}");
            }
        }

        public static void AddSalaries(List<Salary> salaries)
        {
            if (salaries == null || !salaries.Any()) return;

            var month = salaries.First().Month;
            try
            {
                var filePath = FileManager.GetSalaryFilePath(month);
                
                foreach (var salary in salaries)
                {
                    FileManager.WriteToFile(filePath, salary.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding salaries: {ex.Message}");
            }
        }

        public static List<Salary> GetSalariesByMonth(string month)
        {
            try
            {
                var filePath = FileManager.GetSalaryFilePath(month);
                var lines = FileManager.ReadFromFile(filePath);
                var salaries = new List<Salary>();

                foreach (var line in lines)
                {
                    try
                    {
                        salaries.Add(Salary.FromString(line));
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }

                return salaries;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving salaries: {ex.Message}");
            }
        }

        public static Salary? GetEmployeeSalaryByMonth(string employeeId, string month)
        {
            try
            {
                var salaries = GetSalariesByMonth(month);
                return salaries.FirstOrDefault(s => s.EmployeeId.Equals(employeeId, StringComparison.OrdinalIgnoreCase));
            }
            catch (Exception ex)
            {
                throw new Exception($"Error finding employee salary: {ex.Message}");
            }
        }

        public static bool SalaryExistsForMonth(string employeeId, string month)
        {
            return GetEmployeeSalaryByMonth(employeeId, month) != null;
        }

        public static List<string> GetAvailableMonths()
        {
            try
            {
                var dataDirectory = FileManager.GetDataDirectory();
           

                var salaryFiles = Directory.GetFiles(dataDirectory, "Salary.*.txt");
                var months = new List<string>();

                foreach (var file in salaryFiles)
                {
                    var fileName = Path.GetFileNameWithoutExtension(file);
                    if (fileName.StartsWith("Salary."))
                    {
                        var month = fileName.Substring(7); // Remove "Salary." prefix
                        months.Add(month);
                    }
                }

                return months.OrderBy(m => m).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting available months: {ex.Message}");
            }
        }
    }
}
