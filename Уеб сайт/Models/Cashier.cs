using System.ComponentModel.DataAnnotations;

namespace HouseManager.Models
{
    public class Cashier
    {
        public int Id { get; set; }
        //public virtual ICollection<User>? Users { get; set; }
        public virtual User? ClientId { get; set; }
        public int UserId { get; set; }
        
        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Дължима сума")]
        public double Sum{ get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Краен срок за плащане")]
        public DateTime endDate { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Дата на заплащане")]
        public DateTime payDate { get; set; }
       
    }
}
