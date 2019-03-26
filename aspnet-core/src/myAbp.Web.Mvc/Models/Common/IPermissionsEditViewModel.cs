using System.Collections.Generic;
using myAbp.Roles.Dto;

namespace myAbp.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}