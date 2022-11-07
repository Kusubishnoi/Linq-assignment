using LinQ_Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MainProgram
{
    static void Main(string[] args)
    {

        List<Employee> EmployeeList = new List<Employee>();

        Employee emp1 = new Employee(0, "Deepika", "Front-end", " Html ", "  Cognizant");
        Employee emp2 = new Employee(1, "Rishita", "FullStack", ".NetCore", "Infosys  ");
        Employee emp3 = new Employee(2, "Ritika ", "Back-end ", " C# ", "    Aspirefox");
        EmployeeList.Add(emp1);
        EmployeeList.Add(emp2);
        EmployeeList.Add(emp3);
       
        
        addnew add = new addnew();
        bool flag = true;
        while (flag)
        {
            Console.Clear();
            Console.WriteLine("Select an options:\n\n1.Add new users\n2.Edit an existing users\n3.View users\n4.Delete a user\n5.Search a user\n6.Quit\n\nEnter your selections");

            string ch = Console.ReadLine();
            switch (ch)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("----- Add New User ------\n");
                    var emp = add.AddNew();
                    EmployeeList.Add(emp);
                    break;
                case "2":
                    EditUser edit = new EditUser(EmployeeList);
                    EmployeeList = edit.Edit();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine(" ---- All Users ---- \n");

                    PrintEmployee print = new PrintEmployee(EmployeeList);
                    print.PrintAllEmployee();

                    Console.WriteLine($"\n\nTotal Number of employee: {EmployeeList.Count}\n");
                    Console.WriteLine("Press Enter to Return to Main Menu");
                    Console.ReadLine();
                    break;

                case "4":
                    DeleteEmp del = new DeleteEmp(EmployeeList);
                    EmployeeList = del.Delete();
                    break;
                case "5":
                    SearchEmp search = new SearchEmp(EmployeeList);
                    search.Search();
                    break;
                case "6":
                    flag = false;
                    break;
                default:
                    Console.WriteLine("\nInvalid Input\n");
                    Console.WriteLine("Press Enter to try again!");
                    Console.ReadLine();
                    break;

            }
        }
    }
}
