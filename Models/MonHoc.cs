using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MonHoc.Models
{
    [Table("MonHoc")]
    public class MonHoc
    {
        [Key]
        public string MonHocId { get; set; }
        public string TenMonHoc { get; set; }
        public int SoTinChi { get; set; }

    }
}