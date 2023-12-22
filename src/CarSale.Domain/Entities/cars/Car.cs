using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CarSale.Domain.Entities.cars
{
    public class Car : Auditable
    {
        public long  User_id { get; set; }
        public long Category_id { get; set; }
        public string Car_name { get; set; } = String.Empty;
        public string Car_price { get; set; } = String.Empty;
        public string Car_colour { get; set; } = String.Empty;
        public int Car_year { get; set; }
        public string Description { get; set; } = String.Empty;
        public string ImagePath { get; set; } = String.Empty;

    }
}
