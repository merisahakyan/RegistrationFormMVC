using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvcovie.Models
{
    public enum Gender
    {
        male,
        female,
        other
    }
    public class User
    {
        [Key]
        public int ID { get; set; }
        [StringLength(20,MinimumLength =1)]
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        [StringLength(20, MinimumLength = 1)]
        [Required(ErrorMessage = "Surname is required.")]
        public string Surname { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "eMail is required.")]
        public string eMail { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }
        public string Gender { get; set; }
        
    }
}