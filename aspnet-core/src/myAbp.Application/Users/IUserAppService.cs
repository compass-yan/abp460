using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using myAbp.Roles.Dto;
using myAbp.Users.Dto;

namespace myAbp.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
