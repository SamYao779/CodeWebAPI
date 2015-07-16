using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoWebAPI.Models.DB
{
    public class Contact
    {
        [Required]
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required, EmailAddress, MaxLength(50)]
        public string Email { get; set; }
    }
}