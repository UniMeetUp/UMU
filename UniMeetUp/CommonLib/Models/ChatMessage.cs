﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommonLib.Models
{
    public class ChatMessage
    {
        [Key]
        public int ChatMessageId { get; set; }

        [Required]
        public string Message { get; set; }

        public DateTime TimeStamp
        {
            get
            {
                return DateTime.Now;
            }
            set { TimeStamp = DateTime.Now; }
        }

        public string UserId { get; set; }
        public int GroupId { get; set; }
        public User User { get; set; } = new User();
        public Group Group { get; set; } = new Group();
    }
}
