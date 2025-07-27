using System;

namespace JUSTPayroll.Models
{
    public class Teacher
    {
        public string Name { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string Designation { get; set; } = string.Empty;
        public string CurrentAddress { get; set; } = string.Empty;
        public string PermanentAddress { get; set; } = string.Empty;
        public DateTime JoiningDate { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EmployeeId { get; set; } = string.Empty;

        public Teacher()
        {
            EmployeeId = Guid.NewGuid().ToString("N")[..8].ToUpper();
        }

        public Teacher(string name, string department, string designation, 
                      string currentAddress, string permanentAddress, 
                      DateTime joiningDate, DateTime dateOfBirth)
        {
            Name = name;
            Department = department;
            Designation = designation;
            CurrentAddress = currentAddress;
            PermanentAddress = permanentAddress;
            JoiningDate = joiningDate;
            DateOfBirth = dateOfBirth;
            EmployeeId = Guid.NewGuid().ToString("N")[..8].ToUpper();
        }

        public override string ToString()
        {
            return $"{EmployeeId}|{Name}|{Department}|{Designation}|{CurrentAddress}|{PermanentAddress}|{JoiningDate:yyyy-MM-dd}|{DateOfBirth:yyyy-MM-dd}";
        }

        public static Teacher FromString(string data)
        {
            var parts = data.Split('|');
            if (parts.Length != 8) throw new ArgumentException("Invalid teacher data format");

            return new Teacher
            {
                EmployeeId = parts[0],
                Name = parts[1],
                Department = parts[2],
                Designation = parts[3],
                CurrentAddress = parts[4],
                PermanentAddress = parts[5],
                JoiningDate = DateTime.Parse(parts[6]),
                DateOfBirth = DateTime.Parse(parts[7])
            };
        }
    }
}
