using System;

namespace SEPQM
{
    class Program
    {
        static void Main(string[] args)
        {

            School school = new InternationalSchool();
            school.GetTenantDetails();

            School internationBranchASchool = new InternationalBranchASchool();
            internationBranchASchool.GetTenantDetails();

            InternationalBranchASchool internationalBranchASchoolObj = new InternationalBranchASchool();
            internationalBranchASchoolObj.GetTenantDetails();


            internationalBranchASchoolObj.GetBranchMangerName();

        }
    }
}


