using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeDetails.Models
{
    public class EmployeeEntryReply
    {
        String cname;
        public String completeName
        {
            get; set;
            // get { return cname; }
            // set { cname = value; }
        }
        String CompanyName;
        public String companyName
        {
            get; set;
            // get { return CompanyName; }
            // set { CompanyName = value; }
        }
        String hireDate;
        public String HireDate
        {
            get; set;
            //  get { return hireDate; }
            //  set { hireDate = value; }
        }
        String EmployeeID;
        public String employeeid
        {
            get; set;
            //get { return EmployeeID; }
            //set { EmployeeID = value; }
        }
        String registrationStatus;
        public String RegistrationStatus
        {
            get; set;
            // get { return registrationStatus; }
            // set { registrationStatus = value; }
        }
    }
}