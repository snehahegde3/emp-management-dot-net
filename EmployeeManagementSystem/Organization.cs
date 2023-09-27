using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class Organization
    {
        static string orgName = "Siemens";
        static Organization org;
        static int totalEmps = 0;
        static public Employee[] employees = new Employee[40];
        public static Organization createInstance()
        {
            if(org == null)
            {
                return new Organization();
            }
            return org;
        }
        public static void deleteInstance()
        {
            org = null;
        }
        public static void addEmployeeRecord()
        {
            string name, dept, desgn;
            int sal;

            name = Inputter.TakeInput("name");
            sal = Int32.Parse(Inputter.TakeInput("salary"));
            dept = Inputter.TakeInput("department");
            desgn = Inputter.TakeInput("designation");
            Employee emp = new Employee(IDGenerator.Generate(), name,sal,dept,desgn);
            employees[totalEmps++] = emp;
        }
        public static void searchEmpById()
        {
            if (totalEmps < 1)
            {
                Console.WriteLine("No records to display");
                return;
            }
            int id = Int32.Parse(Inputter.TakeInput("ID"));
            for(int i=0;i<totalEmps;i++)
            {
                if (employees[i].EmpID == id)
                {
                    displayEmpDetails(employees[i]);
                }
            }
        }
        public static void displayEmpDetails(Employee[] employees)
        {
            if(employees.Length < 1)
            {
                Console.WriteLine("No records to display");
                return;
            }
            for (int i = 0; i < totalEmps; i++)
            {
                displayEmpDetails(employees[i]);
            }
        }
        public static void displayEmpDetails()
        {
            if (employees.Length < 1)
            {
                Console.WriteLine("No records to display");
                return;
            }
            for (int i = 0; i < totalEmps; i++)
            {
                displayEmpDetails(employees[i]);
            }
        }
        public static void displayEmpDetails(Employee emp)
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine($"Employee {emp.EmpID} named {emp.EmpName} belongs to {emp.DepartmentName} and works as a {emp.EmpDesignation}");
            Console.WriteLine("--------------------------------------------------------------");
        }
        public static void searchByDepartment()
        {
            if (totalEmps < 1)
            {
                Console.WriteLine("No records to display");
                return;
            }
            string dept = Inputter.TakeInput("department");
            int deptEmpCount = 0;
            Employee[] deptEmp = new Employee[totalEmps];
            for (int i = 0; i < totalEmps; i++)
            {
                if (employees[i].DepartmentName == dept)
                {
                    Console.Write("found : ");
                    deptEmp[deptEmpCount++] = employees[i];
                }
            }
            if(deptEmp.Length> 0)
            {
                displayEmpDetails(deptEmp);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
        public static void searchByDesignation()
        {
            if (totalEmps < 1)
            {
                Console.WriteLine("No records to display");
                return;
            }
            string desgn = Inputter.TakeInput("designation");
            int desgnEmpCount = 0;
            Employee[] desgnEmp = new Employee[totalEmps];
            for(int i=0;i<totalEmps;i++)
            {
                if (employees[i].EmpDesignation == desgn)
                {
                    Console.Write("Found : ");
                    desgnEmp[desgnEmpCount++] = employees[i];
                }
            }
            if (desgnEmp.Length > 0)
            {
                displayEmpDetails(desgnEmp);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
        public static void deleteById()
        {
            if(totalEmps < 1)
            {
                Console.WriteLine("No records to delete");
                return;
            }
            int id = Int32.Parse(Inputter.TakeInput("ID"));
            for(int i = 0; i < totalEmps; i++)
            {
                if (employees[i].EmpID == id)
                {
                    employees[i] = employees[totalEmps -1];
                    employees[totalEmps - 1] = null;
                    totalEmps--;
                }
                else
                {
                    Console.WriteLine("");
                }
            }
        }
    }
}
