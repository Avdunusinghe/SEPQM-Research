using SEPQM.ValidateMatric;
using System;

namespace SEPQM
{
    class Program
    {
        static void Main(string[] args)
        {

            ISchoolService schoolService = new SchoolService();


            School school = new InternationalSchool();
            School internationBranchASchool = new InternationalBranchASchool();
            InternationalBranchASchool internationalBranchASchoolObj = new InternationalBranchASchool();

            internationalBranchASchoolObj.GetBranchMangerName();
            internationBranchASchool.GetTenantDetails();
            internationalBranchASchoolObj.GetTenantDetails();
            school.GetTenantDetails();
        }
    }
}


