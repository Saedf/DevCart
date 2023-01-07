using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCartWebApp.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجباری است ")]
        [MaxLength(100,ErrorMessage = "حداکثر طول نام 100 کارکتر است .")]
        [MinLength(3,ErrorMessage = "حداقل طول نام 3 کاراکتر است. ")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "ایمیل را به درستی وارد کنید ")]
        [Required(ErrorMessage = "این فیلد اجباری است ")]
        public string Email { get; set; }

        public int Service { get; set; }
        public SelectList Services { get; set; }
        public string Message { get; set; }

    }
}
