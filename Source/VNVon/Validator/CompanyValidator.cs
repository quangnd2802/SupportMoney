using FluentValidation;
using VNVon.Service.DTO;

namespace VNVon.Validator
{
    public class CompanyValidator : AbstractValidator<DoanhNghiepDauTuDTO>
    {
        public CompanyValidator()
        {
            RuleFor(x => x.Ten).NotEmpty();
            RuleFor(x => x.Cmnd).NotEmpty();
            RuleFor(x => x.NgayCap).NotEmpty();
            RuleFor(x => x.NoiCap).NotEmpty();
            RuleFor(x => x.GioiTinh).GreaterThan(0);
            RuleFor(x => x.NgaySinh).NotEmpty();
            RuleFor(x => x.MaSoThue).NotEmpty();
            RuleFor(x => x.SoDiDong).NotEmpty();
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.ThanhPho).GreaterThan(1);
            RuleFor(x => x.DiaChiNha).NotEmpty();
            RuleFor(x => x.MatKhau).NotEmpty();
            RuleFor(x => x.ViTriTrongCongTy).NotEmpty();

            RuleFor(x => x.CongTyTen).NotEmpty();
            RuleFor(x => x.CongTyIdLinhVuc).GreaterThan(0);
            RuleFor(x => x.CongTySoDangKyKinhDoanh).NotEmpty();
            RuleFor(x => x.CongTyNgayCapPhep).NotEmpty();
            RuleFor(x => x.CongTyDuocCapBoi).NotEmpty();
            RuleFor(x => x.CongTyDiaChiCongTy).NotEmpty();
        }
    }
}
