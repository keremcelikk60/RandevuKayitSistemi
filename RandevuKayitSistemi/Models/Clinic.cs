
using System.ComponentModel.DataAnnotations;

namespace RandevuKayitSistemi.Models
{
    public class Clinic
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Hastane Adı Zorunludur")]
        [StringLength(150, ErrorMessage ="Hastane adı en fazla 150 karakter olabilir")]
        [Display(Name= "Hastane Adı")]
        public string HospitalName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Poliklinik adı zorunludur")]
        [StringLength(100, ErrorMessage = "Poliklinik adı en fazla 100 karakter olabilir")]
        [Display(Name = "Poliklinik adı")]
        public string ClinicName { get; set; } = string.Empty;

        [StringLength(300, ErrorMessage = "Açıklama en fazla 300 karakter olabilir")]
        [Display(Name = "Açıklama")]
        public string? Description { get; set; }

        [Display(Name = "Aktif mi?")]
        public bool IsActive { get; set; } = true;
    }
}
