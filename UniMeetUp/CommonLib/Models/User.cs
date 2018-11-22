﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CommonLib.Models
{
    public class User
    {
        [Key][EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        public string HashedPassword { get; set; }
        [MaxLength(25)]
        public string DisplayName { get; set; }

        public List<UserGroup> UserGroups { get; set; }
    }
}
