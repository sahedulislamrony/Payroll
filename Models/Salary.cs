using System;

namespace JUSTPayroll.Models
{
    public class Salary
    {
        public string EmployeeId { get; set; } = string.Empty;
        public string EmployeeName { get; set; } = string.Empty;
        public decimal BaseSalary { get; set; }
        public decimal Increment { get; set; }
        public decimal Decrement { get; set; }
        public decimal Bonus { get; set; }
        public decimal TotalSalary => BaseSalary + Increment + Bonus - Decrement;
        public string Month { get; set; } = string.Empty;
        public DateTime ProcessedDate { get; set; }

        public Salary()
        {
            ProcessedDate = DateTime.Now;
        }

        public Salary(string employeeId, string employeeName, decimal baseSalary, 
                     decimal increment, decimal decrement, decimal bonus, string month)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            BaseSalary = baseSalary;
            Increment = increment;
            Decrement = decrement;
            Bonus = bonus;
            Month = month;
            ProcessedDate = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{EmployeeId}|{EmployeeName}|{BaseSalary}|{Increment}|{Decrement}|{Bonus}|{TotalSalary}|{Month}|{ProcessedDate:yyyy-MM-dd HH:mm:ss}";
        }

        public static Salary FromString(string data)
        {
            var parts = data.Split('|');
            if (parts.Length != 9) throw new ArgumentException("Invalid salary data format");

            return new Salary
            {
                EmployeeId = parts[0],
                EmployeeName = parts[1],
                BaseSalary = decimal.Parse(parts[2]),
                Increment = decimal.Parse(parts[3]),
                Decrement = decimal.Parse(parts[4]),
                Bonus = decimal.Parse(parts[5]),
                Month = parts[7],
                ProcessedDate = DateTime.Parse(parts[8])
            };
        }
    }
}
