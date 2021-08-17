using EPM.Core.Base;
using System.ComponentModel.DataAnnotations;

namespace EPM.Core.UserManagement
{
    public class Authenticate: BaseModel<int>
    {
        [Required(ErrorMessage ="User name is required")]
        [MaxLength(100,ErrorMessage ="User name is too large")]
        [MinLength(5, ErrorMessage = "User name is too small")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Password do not match")]
        public string ConfirmPassword { get; set; }
    }
}
