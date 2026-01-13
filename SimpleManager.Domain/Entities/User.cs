using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleManager.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } = "Customer";
        public string Avata { get; set; }
        public string Phone { get; set; }
        public DateTime CrateUser { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true; 



    }
}
