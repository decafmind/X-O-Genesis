using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.Entity;
using MySql.Data.MySqlClient;

namespace PetvetPOS_Inventory_System
{
    public class EmployeeMapper : DatabaseMapper
    { 
        public EmployeeMapper(MySqlDB db):base(db)
        {
            tableName = "employee_tbl";
            id = "id";
            fieldsname = new string[] {
                "user_id",
                "firstname",
                "middlename",
                "lastname",
                "mobile_no",
                "email_address",
                "address",
                "image_path",
            };
        }

        public string createEmployee(Employee employee)
        {
            return insertValues(employee.User_id, employee.Firstname, employee.MiddleName, employee.Lastname, employee.MobileNo, employee.EmailAddress , employee.Address, formatImagePath(employee.ImagePath));
        }

        public bool updateEmployee(Employee oldE, Employee newE){
            // Make sure that the employee have the same user_id
            if (oldE.User_id != newE.User_id)
                return false;
        
            string updateFirstname, updateMiddlename, updateLastname, updateMobileno, updateEmailAdd, updateAddress, updateImagepath;
            updateFirstname = updateMiddlename = updateLastname = updateMobileno = updateEmailAdd = updateAddress = updateAddress = updateImagepath = "";
            
            if (oldE.Firstname != newE.Firstname && !String.IsNullOrEmpty(newE.Firstname))
                updateFirstname = String.Format("firstname = '{0}'", newE.Firstname);
            if (oldE.MiddleName != newE.MiddleName && !String.IsNullOrEmpty(newE.MiddleName))
                updateMiddlename = String.Format("middlename = '{0}'", newE.MiddleName);

            if (oldE.Lastname != newE.Lastname && !String.IsNullOrEmpty(newE.Lastname))
                updateLastname = String.Format("lastname = '{0}'", newE.Lastname);
            if (oldE.MobileNo != newE.MobileNo && !String.IsNullOrEmpty(newE.MobileNo))
                updateMobileno = String.Format("mobile_no = '{0}'", newE.MobileNo);

            if (oldE.EmailAddress != newE.EmailAddress && !String.IsNullOrEmpty(newE.EmailAddress))
                updateEmailAdd = string.Format("email_address = '{0}'", newE.EmailAddress);

            if (oldE.Address != newE.Address && !String.IsNullOrEmpty(newE.Address))
                updateAddress = String.Format("address = '{0}'", newE.Address);
            if (oldE.ImagePath != newE.ImagePath && !String.IsNullOrEmpty(newE.ImagePath))
                updateImagepath = String.Format("image_path = '{0}'", newE.ImagePath);


            string condition = String.Format("user_id = '{0}'", newE.User_id);
            return update(
                updateSet(condition, updateFirstname, updateMiddlename, 
                updateLastname, updateMobileno, updateEmailAdd, updateAddress, 
                formatImagePath(updateImagepath))
                );
        }

        public string formatImagePath(string path)
        {
            string newString = "";
            char backSlash = '\\';

            if (path.Contains(backSlash))
            {
                string[] parseOfString = path.Split(backSlash);
                newString += parseOfString[0] + "\\\\";
                int n = parseOfString.Length;
                for (int i = 1; i < n; i++)
                    newString += "\\\\" + parseOfString[i];
            }
            return newString;
        }

        public Employee getEmployeeFromUserId(User user){
            string condition = String.Format("user_id = '{0}'", user.UserId);
            Employee employee = new Employee(getEntityWhere(condition));
            employee.Position = user.getUserLevel();
            return employee;
        }

    }
}
