using System.ComponentModel.DataAnnotations;

namespace HouseManager.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Потребителско име")]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Име")]
        public string FirstName { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Презиме")]
        public string FathersName { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Фамилия")]
        public string FamilyName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Парола")]
        public string Password { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Имейл адрес")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Адрес")]
        public string Address { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Телефон за контакт")]
        public int TelephoneNumber { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Членове на домакинството")]
        public string HouseHoldMembers { get; set; }
        public string Role { get; set; }
        public virtual ICollection<Cashier>? Users { get; set; }

    }
}
