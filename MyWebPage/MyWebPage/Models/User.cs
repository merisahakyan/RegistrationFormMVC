using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWebPage.Models
{
    public class User
    {
        [Required]
        [RegularExpression("[a-z A-Z]", ErrorMessage = "Name can contain only letters")]
        public string Name { get; set; }

        [Required]
        [RegularExpression("[a-z A-Z]", ErrorMessage = "Surname can contain only letters")]
        public string Surname { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string eMail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}