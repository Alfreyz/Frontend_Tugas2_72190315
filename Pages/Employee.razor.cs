using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Pertemuan_2.Models;

namespace Pertemuan_2.Pages
{
    public partial class EmployeePage
    {
        public IEnumerable<Employee> Employees {get; set;}

        protected override Task OnInitializedAsync()
        {
            LoadEmployees();
            return base.OnInitializedAsync();
        }
        private void LoadEmployees(){
            Employee e1 = new Employee{
                EmployeeId = 72190315,
                FirstName = "72190315",
                LastName = "Ferry",
                Email = "Ferry@si.ukdw.ac.id",
                DateOfBirth = new DateTime(2001,08,24),
                Gender = Gender.Male,
                Department = new Department{DepartmentId = 1, DepartmentName="SI"},
                FotoPath = "Images/72190315-Ferry.jpg"
            };
            Employee e2 = new Employee{
                EmployeeId = 1,
                FirstName = "Number 1",
                LastName = "Testing 1",
                Email = "TestingNumber1@Training.com",
                DateOfBirth = new DateTime(2001,10,23),
                Gender = Gender.Male,
                Department = new Department{DepartmentId = 2, DepartmentName="TI"},
                FotoPath = "Images/1.jpg"
            };
            Employee e3 = new Employee{
                EmployeeId = 2,
                FirstName = "Number 2",
                LastName = "Testing 2",
                Email = "TestingNumber2@Training.com",
                DateOfBirth = new DateTime(1999,09,12),
                Gender = Gender.Male,
                Department = new Department{DepartmentId = 1, DepartmentName="SI"},
                FotoPath = "Images/2.jpg"
            };

            Employee e4 = new Employee{
                EmployeeId = 3,
                FirstName = "Number 3",
                LastName = "Testing 3",
                Email = "TestingNumber3@Training.com",
                DateOfBirth = new DateTime(1991,02,12),
                Gender = Gender.Female,
                Department = new Department{DepartmentId = 2, DepartmentName="TI"},
                FotoPath = "Images/2.jpg"
            };
            Employees = new List<Employee>{e1,e2,e3,e4};
        }
    }
}