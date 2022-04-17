using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEPQM.ValidateMatric
{
    public  class SchoolService : ISchoolService
    {
        public void GetTenantDetails()
        {
            Console.WriteLine("Get Tanent Details");
        }

        public void SaveSchool()
        {
            Console.WriteLine("Save School");
        }

        public void DeleteSchool()
        {
            Console.WriteLine("Delete School");
        }

        public void UpdateSchool()
        {

            Console.WriteLine("Update School");
        }
        
    }
}
