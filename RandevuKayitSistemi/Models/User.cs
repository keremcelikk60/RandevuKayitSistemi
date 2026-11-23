using System.ComponentModel.DataAnnotations;

namespace RandevuKayitSistemi.Models

{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad soyad zorunludur. ")]
        [StringLength(100, ErrorMessage = "Ad soyad en fazla 100 karakter olabilir")]
        [Display(Name = "Ad Soyad")]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Kullanıcı adı zorunludur. ")]
        [StringLength(50, ErrorMessage = "Kullanıcı adı en fazla 50 karakter olabilir")]
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; } = String.Empty;

        [Required]
        public string PasswordHash { get; set; } = String.Empty;

        [StringLength(20, ErrorMessage = "Telefon en fazla 20 karakter olabilir")]
        [Display(Name = "Telefon")]
        public string? Phone {  get; set; }

        [StringLength(100, ErrorMessage = "E-posta en fazla 100 karakter olabilir")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz")]
        [Display(Name = "E-posta")]
        public string? Email { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Rol")]
        public string Role { get; set; } = "Hasta";

        [Display(Name = "Kayıt Tarihi")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
