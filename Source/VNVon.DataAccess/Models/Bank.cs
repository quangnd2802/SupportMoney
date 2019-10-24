using System.ComponentModel.DataAnnotations.Schema;

namespace VNVon.DataAccess.Models
{
    [Table("Bank")]
    public class Bank
    {
        public int Id { get; set; }

        public string TenNganHang { get; set; }

        public string MaNganHang { get; set; }
    }
}
