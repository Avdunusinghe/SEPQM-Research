using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEPQM
{
    public class InternationalSchool : School
    {
        public override string GetTenantDetails()
        {
            var schoolSettings = "School Name";
            return schoolSettings;
        }

        public virtual string GetInternationalSchoolTeacherDetails()
        {
            var teacherDetails = "Teacher Details";
            return teacherDetails;

        }


    }
}


