using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Assignment
{
    public class PrintEmployee
    {
        List<Employee> empList = new List<Employee>();
        public PrintEmployee(List<Employee> empList)
        {
            this.empList = empList;
        }

        public void PrintAllEmployee()
        {

            Console.WriteLine($"    ID   Name          Department        Technology         Company_Name  \n");
            int i = 0; 
            foreach (var emp in empList)
            {
                emp.Id = i++;
                Console.WriteLine($"    {emp.Id}    {emp.Name}         {emp.Department}       {emp.Technology}           {emp.Company_name}  ");
            }
        }
    }
}
