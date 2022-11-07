using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Assignment
{
    public class SearchEmp
    {
        List<Employee> searchEmp = new List<Employee>();

        public SearchEmp(List<Employee> searchEmp)
        {
            this.searchEmp = searchEmp;
        }
        public void searchName()
        {

            Console.Write("Enter the Name: ");
            string name = Console.ReadLine();
            Validation v = new Validation();
            name = v.CheckName(name);
            bool nameFlag = false;

            List<Employee> temp = new List<Employee>();

            foreach (var item in searchEmp)
            {
                string currName = (item.Name).ToLower();
                name = name.ToLower();
                if (currName.Contains(name))
                {
                    nameFlag = true;

                    temp.Add(item);

                }
               
                if (nameFlag == false)
                {
                    Console.WriteLine("No Records !");
                    Console.WriteLine("Press Enter to return to Main Menu\n");
                }
                else
                {
                    Console.WriteLine("\nEmployee Found !");
                    Console.WriteLine("Press Enter to Display Record !");
                    Console.ReadLine();

                    PrintEmployee print = new PrintEmployee(temp);
                    print.PrintAllEmployee();
                }
            }
        }

        public void Search()
        {
            Console.Clear();
            Console.WriteLine("---- Search Employee ----\n");
            Console.WriteLine("-- Search By Name --\n");

            searchName();
            Console.WriteLine("\nPress Enter To return to Main Menu!\n");
            Console.ReadLine();



        }

    }
}
