using AutoMapper;
using System;
using VNVon.DataAccess.Interfaces;
using VNVon.DataAccess.Models;
using VNVon.Service.Common;
using VNVon.Service.DTO;
using VNVon.Service.Interfaces;

namespace VNVon.Service.Implements
{
    public class UserService : ServiceBase<User>, IUserService
    {
        public UserService(IUnitOfWork unitOfWork, IRepositoryBase<User> repository) : base(unitOfWork, repository)
        {
        }

        public void Register(CaNhanDTO caNhanDTO)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<CaNhanDTO, User>();
                cfg.CreateMap<string, DateTime>().ConvertUsing(new DateTimeConverterForString());
            });
            IMapper iMapper = config.CreateMapper();
            var user = iMapper.Map<CaNhanDTO, User>(caNhanDTO);

            _repository.Create(user);
            _unitOfWork.Save();            
        }
    }
}
