using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0, employeeCount;
            Organization siemensOrg = new Organization();
            while (choice != -1)
            {
                Console.WriteLine("Choose one or more of the following :  ");
                Console.WriteLine("1 to add employees\n2 to search by ID\n3 to search by department\n4 to seach by designation\n5 delete by ID\n6 display all employees");
                choice = Int32.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1: Organization.addEmployeeRecord();
                            break;
                    case 2:
                            Organization.searchEmpById();
                            break;
                    case 3: Organization.searchByDepartment();
                            break;
                    case 4: Organization.searchByDesignation();
                            break;
                    case 5: Organization.deleteById();
                            break;
                    case 6: Organization.displayEmpDetails();
                            break;
                    default:
                        {
                            Console.WriteLine("Invalid option");
                            choice = -1;
                        }
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
