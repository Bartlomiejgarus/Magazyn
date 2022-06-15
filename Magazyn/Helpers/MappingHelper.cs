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
            IList<UserViewModel> fakeUsersViewModel = new List<UserViewModel>();
            foreach (UserModel UserModel in usersModel)
            {
                UserViewModel fakeUserViewModel = new UserViewModel();
                fakeUserViewModel.Id = UserModel.UserId;
                fakeUserViewModel.LastName = UserModel.LastName;
                fakeUserViewModel.FirstName = UserModel.FirstName;
                fakeUserViewModel.Code = UserModel.Code.ToString();

                fakeUserViewModel.Position = string.Empty;
                fakeUserViewModel.Status = UserModel.Status.ToString();

                fakeUsersViewModel.Add(fakeUserViewModel);
            }
            return fakeUsersViewModel;

        }
    }
}
