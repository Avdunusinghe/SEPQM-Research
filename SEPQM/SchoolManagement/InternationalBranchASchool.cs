using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEPQM
{
    public class InternationalBranchASchool : InternationalSchool
    {
        public override string GetTenantDetails()
        {
            var schoolSettings = "School Name";
            return schoolSettings;
        }

        public override string GetInternationalSchoolTeacherDetails()
        {
            var teacherDetails = "Teacher Details Internation Branch A";
            return teacherDetails;
        }

        public void GetBranchMangerName()
        {
            Console.WriteLine("InternationalBranchA Manager");
        }
     }
}
