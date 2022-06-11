using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models.Dictionares;

namespace Warehouse.Models
{
    public class UserModel : EntityModel
    {
        public string UserName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? DateBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public StatusModel Status { get; set; }
        
    }
}
