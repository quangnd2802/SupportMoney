using FluentValidation;
using VNVon.Service.DTO;

namespace VNVon.Validator
{
    public class UserValidator : AbstractValidator<CaNhanDTO>
    {
        public UserValidator()
        {            
            RuleFor(x => x.Ten).NotEmpty();
            RuleFor(x => x.Cmnd).NotEmpty();
            RuleFor(x => x.NgayCap).NotEmpty();
            RuleFor(x => x.NoiCap).NotEmpty();
            RuleFor(x => x.GioiTinh).NotEmpty();
            RuleFor(x => x.NgaySinh).NotEmpty();
            RuleFor(x => x.MaSoThue).NotEmpty();
            RuleFor(x => x.SoDiDong).NotEmpty();
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.ThanhPho).GreaterThan(1);
            //RuleFor(x => x.DiaChiNha).NotEmpty();
            RuleFor(x => x.MatKhau).NotEmpty();
        }
    }
}
