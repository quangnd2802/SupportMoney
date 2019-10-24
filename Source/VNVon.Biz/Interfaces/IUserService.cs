using VNVon.DataAccess.Models;
using VNVon.Service.DTO;

namespace VNVon.Service.Interfaces
{
    public interface IUserService : IServiceBase<User>
    {
        public void Register(CaNhanDTO caNhanDTO);

        public void RegisterCompany(DoanhNghiepDauTuDTO doanhNghiepDauTu);

        public LoginDTO Login(LoginDTO user);

        public object ChangePassword(ChangePassDto changePass);

        public object ForgetPassword(ForgetPassDto forgetPass);
    }
}
