using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Quiz
    {
        [Required(ErrorMessage = "این فیلد اجباری است")]

        public string Email { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است")]
        [StringLength(11,MinimumLength =11,ErrorMessage = "تعداد رقم ها باید دقیقا 11 رقم باشد")]
        public string Mobile { get; set; }
    }
}
