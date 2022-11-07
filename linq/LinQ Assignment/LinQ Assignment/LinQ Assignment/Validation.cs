using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinQ_Assignment
{
    public class Validation
    {
        public string CheckName(string name)
        {
            string regex = @"^[a-zA-Z]+[a-zA-Z\s]+$";
            Regex re = new Regex(regex);
            if (re.IsMatch(name))
            {
                return name;
            }
            string fname = "";
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Correct Name: ");
                string tempName = Console.ReadLine();
                if (re.IsMatch(tempName))
                {
                    fname = tempName;
                    flag = false;
                }
            }
            return fname;
        }
        
        public string getTechnology()
        {
            string technology = "";
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("\nEnter Technology: ");
                    technology = Console.ReadLine();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nInvalid Input!");
                }
            }


            return technology;

            //string regex = @"^[a-zA-Z]+[a-zA-Z\s]+$";
            //Regex re = new Regex(regex);
            //if (re.IsMatch(technology))
            //{
            //    return technology;
            //}
            //string fname = "";
            //bool flag = true;
            //while (flag)
            //{
            //    Console.WriteLine("Enter Correct Technology: ");
            //    string tempName = Console.ReadLine();
            //    if (re.IsMatch(tempName))
            //    {
            //        fname = tempName;
            //        flag = false;
            //    }
            //}
            //return fname;


        }
        public string getCompany_name()
        {
            string company = "";
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("\nEnter Company_Name: ");
                    company = Console.ReadLine();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nInvalid Input!");
                }
            }
            return company;
            //string regex = @"^[a-zA-Z]+[a-zA-Z\s]+$";
            //Regex re = new Regex(regex);
            //if (re.IsMatch(company))
            //{
            //    return company;
            //}
            //string fname = "";
            //bool flag = true;
            //while (flag)
            //{
            //    Console.WriteLine("Enter Correct Company: ");
            //    string tempName = Console.ReadLine();
            //    if (re.IsMatch(tempName))
            //    {
            //        fname = tempName;
            //        flag = false;
            //    }
            //}
            //return fname;
        }
    }
}
