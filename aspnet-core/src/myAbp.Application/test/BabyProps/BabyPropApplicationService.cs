
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

namespace MQKJ.BSMP.ChineseBabies
{
    /// <summary>
    /// BabyProp应用层服务的接口实现方法  
    ///</summary>
    public class BabyPropAppService :IBabyPropAppService
    {
        private readonly IBabyPropTermApplicationService _babyPropBuyTermApplicationService;
        /// <summary>
        /// 构造函数 
        ///</summary>
        public BabyPropAppService(
     
          IBabyPropTermApplicationService babyPropBuyTermApplicationService
        ) 
        {
            _babyPropBuyTermApplicationService = babyPropBuyTermApplicationService;
        }

        public async Task<ICollection<GetFamilyPropBuyInfoOutput>> GetFamilyPropBuyInfo(GetFamilyPropBuyInfoInput input)
        {
            var termStaff = await _babyPropBuyTermApplicationService.ValideBabyPropTermSatisfyHandle(new BabyPropBuyTermIsSatisfyInput() { FamilyId = 1, Term = null, BabyId = 1 });
            return null;
        }



       
    }
}


