using System.ComponentModel.DataAnnotations;

namespace CODE_FIRST.Models
{
    public class BacSi
    {
        [Key] // Tự hiểu là Primary Key, Identity(1,1)
        public int MaBS { get; set; }

        [Required(ErrorMessage = "Không được để trống tên")]
        [StringLength(100)]
        public string TenBacSi { get; set; }

        public string ChuyenKhoa { get; set; }
    }
}