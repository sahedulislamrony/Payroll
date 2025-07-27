using System;
using System.Collections.Generic;
using System.Linq;
using JUSTPayroll.Models;

namespace JUSTPayroll.DB
{
    public class EmployeeRepository
    {
        public static void AddEmployee(Teacher teacher)
        {
            try
            {
                var filePath = FileManager.GetEmployeeFilePath();
                FileManager.WriteToFile(filePath, teacher.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding employee: {ex.Message}");
            }
        }

        public static List<Teacher> GetAllEmployees()
        {
            try
            {
                var filePath = FileManager.GetEmployeeFilePath();
                var lines = FileManager.ReadFromFile(filePath);
                var teachers = new List<Teacher>();

                foreach (var line in lines)
                {
                    try
                    {
                        teachers.Add(Teacher.FromString(line));
                    }
                    catch (Exception)
                    {
                        // Skip invalid lines
                        continue;
                    }
                }

                return teachers;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving employees: {ex.Message}");
            }
        }

        public static Teacher? FindEmployeeById(string employeeId)
        {
            try
            {
                var employees = GetAllEmployees();
                return employees.FirstOrDefault(e => e.EmployeeId.Equals(employeeId, StringComparison.OrdinalIgnoreCase));
            }
            catch (Exception ex)
            {
                throw new Exception($"Error finding employee: {ex.Message}");
            }
        }

        public static Teacher? FindEmployeeByName(string name)
        {
            try
            {
                var employees = GetAllEmployees();
                return employees.FirstOrDefault(e => e.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
            }
            catch (Exception ex)
            {
                throw new Exception($"Error finding employee by name: {ex.Message}");
            }
        }

        public static bool EmployeeExists(string employeeId)
        {
            return FindEmployeeById(employeeId) != null;
        }

        public static int GetTotalEmployeeCount()
        {
            return GetAllEmployees().Count;
        }
    }
}
