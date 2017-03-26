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
        public int ID { get; set; }
        [StringLength(20,MinimumLength =1)]
        public string Name { get; set; }
        [StringLength(20, MinimumLength = 1)]
        public string Surname { get; set; }
        [DataType(DataType.EmailAddress)]
        public string eMail { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Gender { get; set; }
        
    }
}