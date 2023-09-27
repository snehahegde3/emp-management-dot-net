using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { set; get; }
        private int EmpSal { set; get; }
        public string DepartmentName { set; get; }
        public string EmpDesignation {  set; get; }
        public Employee(int ID, string name, int sal, string department, string designation) {
            EmpID = ID;
            EmpName = name;
            EmpSal = sal;
            DepartmentName = department;
            EmpDesignation = designation;
        }
    }

}
