namespace VNVon.Service.DTO
{
    public class InvestmentDTO
    {
        public int NgayDauTu { get; set; }

        public int LaiSuat { get; set; }

        public decimal SoTienDauTu { get; set; }

        public decimal DoanhThuDuKien 
        {
            get
            {
                decimal result = 0;
                try
                {
                    result = (SoTienDauTu * LaiSuat) / 100;
                }
                catch
                {
                    result = 0;
                }

                return result;
            } 
        }
    }
}
