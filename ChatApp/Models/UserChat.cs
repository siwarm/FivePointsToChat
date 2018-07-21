using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChatApp.Models
{
    public class UserChat
    {

        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(56)]
        public string UserName { get; set; }
        [Required]
        [StringLength(15)]
        public string PASSWORD { get; set; }

        [Required]
        [StringLength(128)]
        public string ADRESSE_MAIL { get; set; }
    }
}