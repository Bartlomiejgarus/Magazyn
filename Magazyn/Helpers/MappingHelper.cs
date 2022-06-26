using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models;
using Warehouse.ViewModel;

namespace Warehouse.Helpers
{
    public class MappingHelper
    {
        public static IList<UserViewModel> MapUserModelToUserViewModel
            (IList<UserModel> usersModel)
        {
            IList<UserViewModel> UsersViewModel = new List<UserViewModel>();
            foreach (UserModel UserModel in usersModel)
            {
                UserViewModel UserViewModel = new UserViewModel();
                UserViewModel.Id = UserModel.UserId;
                UserViewModel.LastName = UserModel.LastName;
                UserViewModel.FirstName = UserModel.FirstName;
                UserViewModel.Code = UserModel.Code.ToString();

                UserViewModel.Position = string.Empty;
                UserViewModel.Status = UserModel.Status.ToString();

                UsersViewModel.Add(UserViewModel);
            }
            return UsersViewModel;

        }

        public static UserViewModel MapUserModelToUserViewModel(UserModel userModel)
        {
            
                UserViewModel UserViewModel = new UserViewModel();
                UserViewModel.Id = userModel.UserId;
                UserViewModel.LastName = userModel.LastName;
                UserViewModel.FirstName = userModel.FirstName;
                UserViewModel.Code = userModel.Code.ToString();

                UserViewModel.Position = string.Empty;
                UserViewModel.Status = userModel.Status.ToString();


            return UserViewModel;

        }
    }
}
