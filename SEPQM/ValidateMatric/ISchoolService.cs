using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEPQM.ValidateMatric
{
    public  interface ISchoolService
    {
        public  void GetTenantDetails();
        public  void SaveSchool();
        public  void DeleteSchool();
        public  void UpdateSchool();
    }
}
