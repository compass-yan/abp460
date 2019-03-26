using Abp.Application.Services;
using Abp.Collections.Extensions;
using Abp.Domain.Entities.Auditing;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Microsoft.EntityFrameworkCore;
using MQKJ.BSMP.ChineseBabies.PropMall.BabyPropTerms.Dtos;
using MQKJ.BSMP.ChineseBabies.PropMall.Props.Terms;
using myAbp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQKJ.BSMP.ChineseBabies.PropMall
{
    public class BabyPropTermApplicationService : IBabyPropTermApplicationService
    {
        private readonly IRepository<Baby, int> _babyRepository;
        private readonly IRepository<PlayerProfession, int> _playerProfessionRepository;
        //private readonly IRepository<BabyProp, int> _babyPropRepository;

        public BabyPropTermApplicationService(
            IRepository<Baby, int> babyRepository
            , IRepository<PlayerProfession, int> playerProfessionRepository
            //,IRepository<BabyProp, int> babyPropRepository
            )
        {
            _babyRepository = babyRepository;
            _playerProfessionRepository = playerProfessionRepository;
        }


        //[UnitOfWork]
        public  async Task<bool> ValideBabyPropTermSatisfyHandle(BabyPropBuyTermIsSatisfyInput input)
        {
            var res = await ProfessionLevelTermValidate(input, "dad");

            return res;
        }

        /// <summary>
        /// 父母职业等级校验
        /// </summary>
        /// <param name="input"></param>
        /// <param name="parentName"></param>
        /// <returns></returns>
        protected async Task<bool> ProfessionLevelTermValidate(BabyPropBuyTermIsSatisfyInput input, string parentName)
        {
            var baby = await _babyRepository.GetAllIncluding(s => s.Family).AsNoTracking()
                .FirstOrDefaultAsync(s => s.Id == input.BabyId && s.FamilyId == input.FamilyId);
            //var profession = await _playerProfessionRepository.GetAllIncluding()
            //         .WhereIf(parentName == "mom", s => s.PlayerId == baby.Family.MotherId)
            //         .WhereIf(parentName == "dad", s => s.PlayerId == baby.Family.FatherId)
            //         .FirstOrDefaultAsync(s => s.IsCurrent && s.FamilyId == input.FamilyId);
            //return profession.Level >= input.Term?.MinValue && profession.Level <= input.Term?.MaxValue;
            return false;
        }



    }
}
