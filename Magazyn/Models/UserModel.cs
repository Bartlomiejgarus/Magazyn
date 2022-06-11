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
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? DateBirth { get; set; }
        public SexModel Sex { get; set; }

        public PositionModel Position { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public StatusModel Status { get; set; }
        
    }
}
