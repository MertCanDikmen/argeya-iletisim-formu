using System.ComponentModel.DataAnnotations;

namespace argeya.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Adınızı giriniz.")]
        [Display(Name = "Ad")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyadınızı giriniz.")]
        [Display(Name = "Soyad")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Telefon numaranızı giriniz.")]
        [Phone]
        [Display(Name = "Telefon Numarası")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "E-postanızı giriniz.")]
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Departman")]
        public string Department { get; set; }

        [Required(ErrorMessage = "Mesajınız boş olamaz!")]
        [Display(Name = "Mesajınız")]
        public string Message { get; set; }
    }
}
