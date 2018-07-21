using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChatApp.Models
{
    public class Conversation
    {
        [Key]
        public int IdConversation { get; set; }
        public int sender { get; set; }
        public int receiver { get; set; }
        public DateTime time { get; set; }
    }
}