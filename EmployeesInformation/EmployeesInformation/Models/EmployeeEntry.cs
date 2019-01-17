using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace EmployeeDetails.Models
{
    public class EmployeeEntry
    {
        List<Employees> employeeList;
        static EmployeeEntry empentryd = null;
        private EmployeeEntry()
        {
            employeeList = new List<Employees>();
        }
        public static EmployeeEntry getInstance()
        {
            if (empentryd == null)
            {
                empentryd = new EmployeeEntry();
                return empentryd;
            }
            else
            {
                return empentryd;
            }
        }
        public void Add(Employees employee)
        {
            employeeList.Add(employee);
        }
        public String Remove(String eID)
        {
            for (int i = 0; i < employeeList.Count; i++)
            {
                Employees emp = employeeList.ElementAt(i);
                if (emp.employeeid.Equals(eID))
                {
                    employeeList.RemoveAt(i);//update the new record
                    return "Delete successful";
                }
            }
            return "Delete un-successful";
        }
        public List<Employees> getallemployee()
        {
            return employeeList;
        }
        public String UpdateStudent(Employees std)
        {
            for (int i = 0; i < employeeList.Count; i++)
            {
                Employees emp = employeeList.ElementAt(i);
                if (emp.employeeid.Equals(std.employeeid))
                {
                    employeeList[i] = std;//update the new record
                    return "Update successful";
                }
            }
            return "Update un-successful";
        }
    }
}