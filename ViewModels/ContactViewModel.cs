using System.ComponentModel.DataAnnotations;

namespace CoreMVC3.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        [MinLength(5)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }   
        [Required]
        public string Subject { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage="TOO LONG OVER 200 CHARACTER")]
        public string Message { get; set; } 




    }
}