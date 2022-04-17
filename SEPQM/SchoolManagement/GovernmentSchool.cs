using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEPQM
{
    public class GovernmentSchool : School
    {
        public override string GetTenantDetails()
        {
            var schoolSettings = "School Name";
            return schoolSettings;
        }

        public string GetGovernmentTeacherDetails()
        {
            var teacherDetails = "Teacher Details";
            return teacherDetails;

        }
    }
}
