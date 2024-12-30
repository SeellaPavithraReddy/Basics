using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFApp.Models
{
    [Table(name: "EmpValidations1")]

    public class EmpValidations1
    {
        [Key]
        [Required(ErrorMessage = "Please Enter Empno")]
        public int Empno { get; set; }

        [Required(ErrorMessage = "Please Enter Emp name")]
        // [StringLength(25,ErrorMessage ="name must be max 25 char")]
        [MaxLength(25, ErrorMessage = "name must be max 25 char")]

        [MinLength(length: 3, ErrorMessage = "name must have more than 3 characters")]

        public String? Ename { get; set; }

        [Required(ErrorMessage = "Please Enter gender")]

        public String? Gender { get; set; }

        [Required(ErrorMessage = "Please Enter Pancard")]
        [RegularExpression(pattern: "^[A-Z]{5}[0-9]{4}[A-Z]{1}$", ErrorMessage = "Invalid Format")]

        public String? Pancard { get; set; }

        [Required(ErrorMessage = "Please Enter Email")]
        [RegularExpression(pattern: "^[a-zA-Z0-9._%+-]{0,50}@{1}[a-zA-Z0-9.-]{1,9}[.][a-zA-Z]{2,6}$", ErrorMessage = "Invalid Format")]

        public String? Email { get; set; }

        [Required(ErrorMessage = "Please Enter DOB")]
        [Range(typeof(DateTime),"01/01/1980", "01/01/2010", ErrorMessage ="Date Not in the range")]
        public Nullable<DateTime> Dob { get; set; }
        [AgeValidation]
        [Required(ErrorMessage = "Please Enter DOJ")]
        [Joining(ErrorMessage = "Date must not greater than todays date")]

        public Nullable<DateTime> Doj { get; set; }
    }
    public enum Gender
    {
        Male,
        Female,
        Others
    }
}