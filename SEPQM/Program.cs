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







































            //Excecuting the constructors when object is intanciated
            Laptop laptop = new Laptop(1, "Hp i7", "0002", 275000.00, "Hewlett-Packard Development Company, L.P.");

            Laptop laptop1 = new Laptop();

            int showRoomId = 1;

            //First Step => Instansiate a Reference
            Customer customer = new Customer();

            //Second Step => Calling The Functions



            laptop.PrintLaptopDetails(customer, showRoomId);
            laptop.PrintLaptopDetails("Hp");
            laptop.updateLaptopDetails();
        }
    }
}


