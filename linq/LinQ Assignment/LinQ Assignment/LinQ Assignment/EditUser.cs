using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Assignment
{
    public class EditUser
    {
        List<Employee> empEdit;
        public EditUser(List<Employee> empEdit)
        {
            this.empEdit = empEdit;
        }

        public List<Employee> Edit()
        {
            Validation validate = new Validation();
            //Program p = new Program();
            addnew add = new addnew();
            PrintEmployee print = new PrintEmployee(empEdit);


            Console.Clear();
            Console.WriteLine("---- Edit Details ----\n\n");

            bool loopFlag = true;

            print.PrintAllEmployee();
            while (loopFlag)
            {

                Console.WriteLine("Enter the Employee ID you want to edit: ");

                int ID = Convert.ToInt32(Console.ReadLine());
                bool idFlag = false;
                foreach (var item in empEdit)
                {
                    if (item.Id == ID)
                    {
                        idFlag = true;
                        loopFlag = false;
                        Console.WriteLine($"\nInput the details of Employee with ID: {ID}\n");

                        Console.WriteLine("Update the Name");
                        //item.Name = Console.ReadLine(); //Updated
                        string name = Console.ReadLine();
                        item.Name = validate.CheckName(name);

                        Console.WriteLine("\nUpdate Department: ");
                        string department = "";
                        bool departmentFlag = false;
                        while (departmentFlag == false)
                        {
                            department = add.getDepartment();
                            if (department != "Try Again")
                            {
                                departmentFlag = true;
                            }
                        }
                        item.Department = department;//Updated

                        string technology = validate.getTechnology();
                        item.Technology = technology;

                        string company = validate.getCompany_name();
                        item.Company_name = company;

                        Console.WriteLine("\nPress Enter To return to Main Menu!\n");
                        Console.ReadLine();
                    }
                    
                }

                if (idFlag == false)
                {
                    Console.WriteLine("\nEmployee Not Found!\n");
                    Console.WriteLine("\nTry Again!!\n");

                    Console.WriteLine("\nPress Enter To return to Main Menu!\n");
                    Console.ReadLine();

                }

            }

            return empEdit;
        }
    }
}
