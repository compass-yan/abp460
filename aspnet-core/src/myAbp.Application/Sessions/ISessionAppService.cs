using System.Threading.Tasks;
using Abp.Application.Services;
using myAbp.Sessions.Dto;

namespace myAbp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
