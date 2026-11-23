using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RandevuKayitSistemi.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

        [Required(ErrorMessage = "Poliklinik seçimi zorunludur")]
        [Display(Name = "Poliklinik")]
        public int ClinicId { get; set; }

        [ForeignKey("ClinicId")]
        public Clinic? Clinic { get; set; }

        [StringLength(50, ErrorMessage = "Ünvan en fazla 50 karakter olabilir")]
        [Display(Name = "Ünvan")]
        public string Title { get; set; } = "Dr.";

        [Display(Name = "Aktif mi?")]
        public bool IsActive { get; set; } = true;
    }
}
