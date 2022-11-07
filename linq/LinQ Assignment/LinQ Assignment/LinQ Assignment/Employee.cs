using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Assignment
{
  
      public class Employee
        {
            public Employee(int id, string name, string department, string technology, string company_name)
            {
                Id = id;
                Name = name;
                Department = department;
                Technology = technology;
                Company_name = company_name;
            }

            public int Id { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
            public string Technology { get; set; }
            public string Company_name { get; set; }


        }
    }

