using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeDetails.Models;

namespace EmployeeDetails.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        public List<Employees> GetAllStudents()
        {

            return EmployeeEntry.getInstance().getallemployee();
        }

        //Add Employee [HTTP:Post]
        [HttpPost]
        public EmployeeEntryReply addEmployee(Employees empregd)
        {
            Console.WriteLine("In addEmployee");
            EmployeeEntryReply empentryreply = new EmployeeEntryReply();
            EmployeeEntry.getInstance().Add(empregd);
            empentryreply.completeName = empregd.completeName;
            empentryreply.companyName = empregd.companyName;
            empentryreply.HireDate = empregd.HireDate;
            empentryreply.employeeid = empregd.employeeid;
            empentryreply.RegistrationStatus = "Successful";
            return empentryreply;
        }

        //Update Employee: [HTTP:Put]
        [HttpPut]
        public String PutEmployeeRecord(Employees emp)
        {
            Console.WriteLine("In updateEmployeeRecord");
            return EmployeeEntry.getInstance().UpdateStudent(emp);
        }

        //Delete Employee: [HTTP:Delete] 
        [HttpDelete]
        public String DeleteEmployeeRecord(String regID)
        {
            Console.WriteLine("In deleteEmployeeRecord");
            return EmployeeEntry.getInstance().Remove(regID);
        }
    }
}