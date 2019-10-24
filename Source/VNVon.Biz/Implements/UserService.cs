using AutoMapper;
using System;
using System.Linq;
using VNVon.DataAccess.Interfaces;
using VNVon.DataAccess.Models;
using VNVon.Service.Common;
using VNVon.Service.CustomException;
using VNVon.Service.DTO;
using VNVon.Service.Interfaces;

namespace VNVon.Service.Implements
{
    public class UserService : ServiceBase<User>, IUserService
    {
        public UserService(IUnitOfWork unitOfWork, IRepositoryBase<User> repository) : base(unitOfWork, repository)
        {}

        public LoginDTO Login(LoginDTO user)
        {
            LoginDTO result = null;

            var users = _repository.FindByCondition(u => u.Username.ToLower() == user.Username.ToLower());

            // && u.MatKhau == user.Password
            if (users == null || users.Count() == 0 || !VerifyPasswordHash(user.Password, users.ElementAt(0).PasswordHash, users.ElementAt(0).PasswordSalt))
            {
                throw new ServiceException("Username or Password is invalid.", (int)ErrorCode.AccountNotExist);
            }                    

            var model = users.ElementAt(0);
            result = new LoginDTO()
            {
                Username = model.Username,
                Role = "Admin"                    
            };            

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

            byte[] passwordHash, passwordSalt;
            CreatePassworHard(caNhanDTO.MatKhau, out passwordHash, out passwordSalt);
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            user.Username = user.Cmnd;

            _repository.Create(user);
            _unitOfWork.Save();

            //MailHelper.SendMail(user.Email, user.Ten, "Mail xác nhận thông tin tài khoảng", "Done");
        }

        public void RegisterCompany(DoanhNghiepDauTuDTO doanhNghiepDauTu)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<DoanhNghiepDauTuDTO, User>();
                cfg.CreateMap<string, DateTime>().ConvertUsing(new DateTimeConverterForString());
            });
            IMapper iMapper = config.CreateMapper();
            var user = iMapper.Map<DoanhNghiepDauTuDTO, User>(doanhNghiepDauTu);

            byte[] passwordHash, passwordSalt;
            CreatePassworHard(doanhNghiepDauTu.MatKhau, out passwordHash, out passwordSalt);
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            user.Username = user.CongTySoDangKyKinhDoanh;

            _repository.Create(user);
            _unitOfWork.Save();

            //MailHelper.SendMail(user.Email, user.Ten, "Mail xác nhận thông tin tài khoảng", "Done");
        }

        private void CreatePassworHard(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key; //ramdomkey 
                passwordHash = hmac.ComputeHash(System.Text.UTF8Encoding.UTF8.GetBytes(password));
            }
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var _passwordHash = hmac.ComputeHash(System.Text.UTF8Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < _passwordHash.Length; i++)
                {
                    if (_passwordHash[i] != passwordHash[i])
                        return false;
                }
            }
            return true;
        }

        public object ChangePassword(ChangePassDto changePass)
        {
            var users = _repository.FindByCondition(u => u.Username == changePass.Username);
            var user = users.FirstOrDefault();
            if (users == null || !VerifyPasswordHash(changePass.OldPassword, user.PasswordHash, user.PasswordSalt))
                return new
                {
                    success = false,
                    message = CommonConstant.ChangePassUnsuccess
                };

            byte[] passwordHash, passwordSalt;
            CreatePassworHard(changePass.NewPassword, out passwordHash, out passwordSalt);
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            _unitOfWork.Save();

            return new
            {
                success = true,
                message = CommonConstant.ChangePassSuccess
            };
        }

        public object ForgetPassword(ForgetPassDto forgetPass)
        {
            var users = _repository.FindByCondition(u => u.Email == forgetPass.email);
            if (users == null)
                return new
                {
                    success = false,
                    message = CommonConstant.EmailNotExit
                };

            return new
            {
                success = true,
                message = CommonConstant.VerifyMailSucess
            };
        }
    }
}
