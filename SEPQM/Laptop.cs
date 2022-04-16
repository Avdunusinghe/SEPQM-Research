using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEPQM
{
    public class Laptop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public double Price { get; set; }
        public string Manufacture { get; set; }

        public Laptop()
        {

        }
        public Laptop(int id, string name, string code, double price, string manufacture)
        {
            this.Id = id;
            this.Name = name;
            this.Code = code;
            this.Price = price;
            this.Manufacture = manufacture;
        }

        public void PrintLaptopDetails(Customer customer, int showRoomId)
        {
            Console.WriteLine("Show Room Id : " + showRoomId);
        }

        public void PrintLaptopDetails(string manufacture)
        {
            Console.WriteLine("Laptop Manufacture : " + manufacture);
        }

        public void updateLaptopDetails()
        {

        }

    }
}
















