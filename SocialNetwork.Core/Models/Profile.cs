﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Core.Models
{
    public class Profile
    {
        public int id {  get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PictureUrl { get; set; }

        public string AccountId { get; set; }
    }
}
