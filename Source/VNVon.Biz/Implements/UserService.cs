using AutoMapper;
using System;
using System.Linq;
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

        public LoginDTO Login(LoginDTO user)
        {
            LoginDTO result = null;

            var users = _repository.FindByCondition(u => u.Username == user.Username && u.MatKhau == user.Password);
            if(users != null && users.Any())
            {
                var model = users.ElementAt(0);
                result = new LoginDTO()
                {
                    Username = model.Username,
                    Role = "Admin"                    
                };
            }

            return result;
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
