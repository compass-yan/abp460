using System.Collections.Generic;
using myAbp.Roles.Dto;
using myAbp.Users.Dto;

namespace myAbp.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
