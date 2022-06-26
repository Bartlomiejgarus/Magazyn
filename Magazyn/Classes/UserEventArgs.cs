using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models;

namespace Warehouse.Classes
{
    public class UserEventArgs : EventArgs
    {
        public UserModel User { private set; get; }

        public UserEventArgs(UserModel user)
        { User = user; }
    }
}
