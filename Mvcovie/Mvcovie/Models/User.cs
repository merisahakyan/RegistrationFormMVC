using System;
using System.Collections.Generic;
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
        public string Name { get; set; }
        public string Surname { get; set; }
        public string eMail { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        
    }
}