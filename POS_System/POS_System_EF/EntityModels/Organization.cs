﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System_EF.EntityModels
{
    public class Organization
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(12)]
        public string Code { get; set; }
        public byte[] Logo { get; set; }
        [Required]
        [MaxLength(250)]
        public string Address { get; set; }
        [Required]
        [MaxLength(11)]
        public string ContactNo { get; set; }

        public bool IsDelete { get; set; }
        public string GenerateCode(string Name, string address)
        {
            int code=0;
            var firstThreeChars = Name.Length <= 3 ? Name : Name.Substring(0, 3);
            var firstThreeCharsAddress = address.Length <= 3 ? address : address.Substring(0, 3);
            return firstThreeChars + "-" + firstThreeCharsAddress+"-"+code++;
        }
    }
}
