
using System;
using System.Data;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using Abp.UI;
using Abp.AutoMapper;
using Abp.Extensions;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Application.Services.Dto;
using Abp.Linq.Extensions;


using MQKJ.BSMP.ChineseBabies;
using MQKJ.BSMP.ChineseBabies.PropMall;
using Abp;
using Abp.Dependency;
using MQKJ.BSMP.ChineseBabies.PropMall.Props.Props;
using MQKJ.BSMP.ChineseBabies.PropMall.BabyPropTerms.Dtos;
using MQKJ.BSMP.ChineseBabies.PropMall.Props.Terms;
using Abp.Domain.Uow;
using myAbp.Core;

namespace MQKJ.BSMP.ChineseBabies
{
    /// <summary>
    /// BabyProp应用层服务的接口实现方法  
    ///</summary>
    public class BabyPropAppService : IBabyPropAppService
    {
        private readonly IBabyPropTermApplicationService _babyPropBuyTermApplicationService;
        private readonly IRepository<Family, int> _familyRepository;
        /// <summary>
        /// 构造函数 
        ///</summary>
        public BabyPropAppService(
      IRepository<Family, int> familyRepository
          , IBabyPropTermApplicationService babyPropBuyTermApplicationService
        )
        {
            _familyRepository = familyRepository;
            _babyPropBuyTermApplicationService = babyPropBuyTermApplicationService;
        }

        public async Task<ICollection<GetFamilyPropBuyInfoOutput>> Test(GetFamilyPropBuyInfoInput input)
        {
            return await GetFamilyPropBuyInfo(input);
        }

        public async Task<ICollection<GetFamilyPropBuyInfoOutput>> GetFamilyPropBuyInfo(GetFamilyPropBuyInfoInput input)
        {
            var response = new List<GetFamilyPropBuyInfoOutput>();
            for (int i = 0; i < 20; i++)
            {
                var termStaff = await _babyPropBuyTermApplicationService.ValideBabyPropTermSatisfyHandle(new BabyPropBuyTermIsSatisfyInput() { FamilyId = 1, BabyId = 1 });
                Console.WriteLine("循环次数："+i);
                response.Add(new GetFamilyPropBuyInfoOutput() { Res=termStaff   });
            }
            return response;
        }




    }
}


