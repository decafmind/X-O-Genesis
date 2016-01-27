using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace PetvetPOS_Inventory_System
{
    public class CompanyProfileMapper : DatabaseMapper
    {
        public CompanyProfileMapper(MySqlDB db)
            : base(db)
        {
            tableName = "company_profile_tbl";
            id = "compname";
            fieldsname = new string[] {
                "compname",
                "address",
                "contactno",
                "email",
                "logo_path",
            };

            fieldsname_forselect = new string[] {
                "compname",
                "address",
                "contactno",
                "email",
                "logo_path",
            };
        }

        public bool updateCompanyProfile(CompanyProf companyProfile)
        {
            string name = string.Empty, address = string.Empty, 
            contact = string.Empty, email = string.Empty, path = string.Empty;

            name = String.Format("compname = '{0}'", companyProfile.Name);
            address = String.Format("address = '{0}'", companyProfile.Address);
            contact = String.Format("contactno = '{0}'", companyProfile.Contact);
            email = String.Format("email = '{0}'", companyProfile.Email);
            path = String.Format("logo_path = '{0}'", companyProfile.Logo);

            string condition = String.Format("compname = '{0}'", companyProfile.Name);
            return update(updateSet(condition, name, address, contact, email, path));
        }
    }
}
