using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.ViewModel
{
    public class UserViewModel
    {
        public int Id { get; set; }
        private string lastName;
        public string LastName 
        {
            get { return lastName.ToUpper(); }
            set { lastName = value; } 
        }
        private string firstName;
        public string FirstName 
        {
            get { return firstName.ToUpper(); }
            set { firstName = value; }
        }

        public string Position { get; set; }

        public string Status { get; set; }

    }
}
