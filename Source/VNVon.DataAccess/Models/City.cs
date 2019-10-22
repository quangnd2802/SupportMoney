using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VNVon.DataAccess.Models
{
    [Table("City")]
    public class City
    {
        public int Id { get; set; }

        public string ThanhPho { get; set; }
    }
}
