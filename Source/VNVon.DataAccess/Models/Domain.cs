using System.ComponentModel.DataAnnotations.Schema;

namespace VNVon.DataAccess.Models
{
    public class Domain
    {
        public int Id { get; set; }

        [Column("Vie.LinhVuc")]
        public string VieLinhVuc { get; set; }

        [Column("En.LinhVuc")]
        public string EnLinhVuc { get; set; }
    }
}
