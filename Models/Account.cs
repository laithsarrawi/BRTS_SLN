using System.ComponentModel.DataAnnotations;

namespace BRTS.Web.Models
{
    public class Account
    {
        [Key]



        public int accountId { get; set; }

        [Required(ErrorMessage = "Please enter your first name.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters.")]
        public string? firstName { get; set; }


        [Required(ErrorMessage = "Please enter your last name.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters.")]
        public string? lastName { get; set; }


        public string? role { get; set; }

        [Required(ErrorMessage = "Please enter your email address.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string? emailAddress { get; set; }

        [Required(ErrorMessage = "Please enter your phone number.")]
        [Phone(ErrorMessage = "Invalid phone number.")]
        public string? phoneNumber { get; set; }



        public String? gender { get; set; }

        [Required(ErrorMessage = "Please enter a username.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 50 characters.")]
        public string? userName { get; set; }

        [Required(ErrorMessage = "Please enter a password.")]
        [DataType(DataType.Password)]
        public string? password { get; set; }
    }
}
