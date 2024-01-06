using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NguyenSyTien637.Models
{
    [Table("SinhViens")]
    public class SinhVien
    {
        [Key]
        
        public string SinhVienId { get; set; }

        public string FullName { get; set; }
        
        public string Address { get; set; }
        
    }
}