using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website_DienThoai.Models.EF
{
    [Table("ThongKes")]
    public class ThongKe
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime ThoiGian { get; set; }
        public long SoTruyCap { get; set; }
    }
}