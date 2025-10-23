using System;
using System.ComponentModel.DataAnnotations;

namespace ContactApp.Models
{
    public enum Department
    {
        [Display(Name = "Muhasebe")]
        Accounting = 0,
        [Display(Name = "Teknik Destek")]
        TechnicalSupport = 1,
        [Display(Name = "İnsan Kaynakları")]
        HumanResources = 2
    }

    public class ContactMessage
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Adı Soyadı gerekli")]
        [StringLength(100)]
        [Display(Name = "Adı Soyadı")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Telefon gerekli")]
        [Phone(ErrorMessage = "Geçerli telefon girin")]
        [Display(Name = "Telefon")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "E-Posta gerekli")]
        [EmailAddress(ErrorMessage = "Geçerli e-posta girin")]
        [Display(Name = "E-Posta")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Departman seçiniz")]
        [Display(Name = "Departman")]
        public Department Department { get; set; }

        [StringLength(2000)]
        [Display(Name = "Mesaj")]
        public string Message { get; set; }

        public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;
    }
}
