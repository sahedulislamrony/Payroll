# JUST Payroll System

A comprehensive payroll management application for **Jashore University of Science and Technology** built with C# and WinForms.

## Features

### 1. Main Dashboard

- Clean and intuitive interface with university branding
- Three main options: Add New Teacher, Show All Teachers, Give Salary

### 2. Teacher Management

- **Add New Teacher**: Complete form to add teacher information
  - Full Name
  - Department
  - Designation
  - Current Address
  - Permanent Address
  - Joining Date
  - Date of Birth
  - Auto-generated Employee ID
- **Show All Teachers**: ListView displaying all teacher records with complete information

### 3. Salary Management

- **Give Salary Options**:
  - Specific Teacher: Search by name or Employee ID
  - All Teachers: Process salary for entire faculty
- **Salary Input Form**:
  - Base Salary
  - Increment
  - Decrement
  - Bonus
  - Month selection
  - Automatic total calculation
- **Show Salaries**: View salary records by month with summary statistics

## File Structure

```
JUSTPayroll/
├── Models/
│   ├── Teacher.cs          # Teacher data model
│   └── Salary.cs           # Salary data model
├── DB/
│   ├── FileManager.cs      # File operations utility
│   ├── EmployeeRepository.cs # Employee data operations
│   └── SalaryRepository.cs # Salary data operations
├── Forms/
│   ├── MainForm.cs         # Main application form
│   ├── AddTeacherForm.cs   # Add new teacher form
│   ├── ShowAllTeachersForm.cs # Display all teachers
│   ├── GiveSalaryForm.cs   # Salary distribution options
│   ├── SalaryInputForm.cs  # Salary input and calculation
│   └── ShowSalariesForm.cs # Display salary records
└── Data/                   # Auto-created data directory
    ├── Employee.txt        # Teacher records storage
    └── Salary.[Month].txt  # Monthly salary records
```

## Data Storage

### Employee.txt Format

```
EmployeeID|Name|Department|Designation|CurrentAddress|PermanentAddress|JoiningDate|DateOfBirth
```

### Salary.[Month].txt Format

```
EmployeeID|EmployeeName|BaseSalary|Increment|Decrement|Bonus|TotalSalary|Month|ProcessedDate
```

## How to Use

### Adding a New Teacher

1. Click "Add New Teacher" from the main menu
2. Fill in all required information
3. Click "Add Teacher" to save
4. Employee ID is automatically generated

### Viewing All Teachers

1. Click "Show All Teachers" from the main menu
2. All teacher records are displayed in a detailed list
3. Use "Refresh" to update the list

### Processing Salary

1. Click "Give Salary" from the main menu
2. Choose between:
   - **Specific Teacher**: Search by name or ID, then proceed
   - **All Teachers**: Process for entire faculty
3. Enter salary details:
   - Base salary (required)
   - Increment, decrement, bonus (optional)
4. Select the month
5. Click "Calculate" to see total
6. Click "Confirm" to save salary records

### Viewing Salary Records

1. From the Salary Input form, click "Show Salaries"
2. Or access through the salary processing workflow
3. Select different months to view historical records
4. View summary statistics (total records, total amount)

## Technical Requirements

- **.NET 9.0** with Windows Forms
- **Windows Operating System**
- **File-based storage** (no database required)

## Building and Running

```bash
# Build the application
dotnet build

# Run the application
dotnet run
```

## Error Handling

- Input validation for all forms
- File operation error handling
- User-friendly error messages
- Search functionality with "not found" handling

## Features Highlights

- **Simple and Clean UI**: Easy to navigate interface
- **File-based Storage**: No complex database setup required
- **Auto-calculations**: Salary totals calculated automatically
- **Search Functionality**: Find teachers by name or ID
- **Monthly Reports**: Salary records organized by month
- **Data Validation**: Comprehensive input validation
- **Error Handling**: Robust error handling throughout

## University Information

**Jashore University of Science and Technology**

- Comprehensive payroll management
- Faculty salary processing
- Employee record management
- Monthly salary reports

---

_© 2025 JUST Payroll System - Jashore University of Science and Technology_
