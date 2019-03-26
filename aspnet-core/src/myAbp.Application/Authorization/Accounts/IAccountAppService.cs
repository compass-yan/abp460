using System.Threading.Tasks;
using Abp.Application.Services;
using myAbp.Authorization.Accounts.Dto;

namespace myAbp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
