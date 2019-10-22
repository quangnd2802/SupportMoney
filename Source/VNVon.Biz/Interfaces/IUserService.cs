using VNVon.DataAccess.Models;
using VNVon.Service.DTO;

namespace VNVon.Service.Interfaces
{
    public interface IUserService : IServiceBase<User>
    {
        public void Register(CaNhanDTO caNhanDTO);
            
    }
}
