using System.ComponentModel.DataAnnotations;

namespace DevCartWebApp.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجباری است ")]
        [MaxLength(100,ErrorMessage = "حداکثر طول نام 100 کارکتر است .")]
        [MinLength(3,ErrorMessage = "حداقل طول نام 3 کاراکتر است. ")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "ایمیل را به درستی وارد کنید ")]
        public string Email { get; set; }
        public string Service { get; set; }
        public string Message { get; set; }

    }
}
