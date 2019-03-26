using Abp.Application.Services;
using Abp.Application.Services.Dto;
using myAbp.MultiTenancy.Dto;

namespace myAbp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

