using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Data.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<OrderDetail> OrderLines { get; set; }

        [Display(Name ="First Name")]
        [Required(ErrorMessage ="First name is Mandatory.")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last name is Mandatory.")]
        [StringLength(50)]
        public string LastName { get; set; }


        [Display(Name = "Adress")]
        [Required(ErrorMessage = "Adress is Mandatory.")]
        [StringLength(80)]
        public string Adress { get; set; }

        [Display(Name = "Zip Code")]
        [Required(ErrorMessage = "Zip Code is Mandatory.")]
        [StringLength(10,MinimumLength =4)]
        public string ZipCode { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "State is Mandatory.")]
        [StringLength(80)]
        public string State { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country is Mandatory.")]
        [StringLength(80)]
        public string Country { get; set; }

        [Display(Name = "Adress")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Adress is Mandatory.")]
        [StringLength(30)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Email Adress")]
        [Required(ErrorMessage = "Email adress is Mandatory.")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "The email address is not entered in a correct format")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public decimal OrderTotal { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderPlaced { get; set; }
    }
}
