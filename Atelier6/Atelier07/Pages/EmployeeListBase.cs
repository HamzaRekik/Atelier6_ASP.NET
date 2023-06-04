using Atelier07.Pages;
using EmployeeManagement.Models.Services;
using Microsoft.AspNetCore.Components;
using BlazorApp_EmployeeList.services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using EmployeeManagement.Models;

namespace BlazorApp_EmployeeList.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Employees = new List<Employee>();
            Employees = (await EmployeeService.GetEmployees()).ToList();
        }
        private void LoadEmployees()
        {
            Employee e1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "John",
                LastName = "Hastings",
                Email = "David@pragimtech.com",
                DateOfBrith = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                Department = new Departement
                {
                    DepartementId =1,
                    DepartementName = "IT"
                },
                PhotoPath = "images/john.png"
            };
            
            Employee e2 = new Employee
            {
                EmployeeId = 2,
                FirstName = "Sam",
                LastName = "Galloway",
                Email = "Sam@pragimtech.com",
                DateOfBrith = new DateTime(1981, 12, 22),
                Gender = Gender.Male,
                Department = new Departement { DepartementId = 2, DepartementName = "HR" },
                PhotoPath = "images/sam.jpg"
            };
            Employee e3 = new Employee
            {
                EmployeeId = 3,
                FirstName = "Mary",
                LastName = "Smith",
                Email = "mary@pragimtech.com",
                DateOfBrith = new DateTime(1979, 11, 11),
                Gender = Gender.Female,
                Department = new Departement {DepartementId = 1, DepartementName = "IT" },
                PhotoPath = "images/mary.png"
            };
            Employee e4 = new Employee
            {
                EmployeeId = 3,
                FirstName = "Sara",
                LastName = "Longway",
                Email = "sara@pragimtech.com",
                DateOfBrith = new DateTime(1982, 9, 23),
                Gender = Gender.Female,
                Department = new Departement { DepartementId = 3, DepartementName = "Payroll" },
                PhotoPath = "images/sara.png"
            };
            Employees = new List<Employee> { e1, e2, e3, e4 };
        }
    }

}

