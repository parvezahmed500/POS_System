using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System_EF.EntityModels
{
    public class Outlet
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(12)]
        public string Code { get; set; }
        [Required]
        [MaxLength(250)]
        public string Address { get; set; }
        [Required]
        [MaxLength(11)]
        public string ContactNo { get; set; }
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }


            public string GenerateCode(string Name, string Address)
        {
            int sl=0;
            var firstThreeChars = Name.Length <= 3 ? Name : Name.Substring(0, 3);
            var firstThreeCharsAddress = Address.Length <= 3 ? Address : Address.Substring(0, 3);
            return firstThreeChars + "-" + firstThreeCharsAddress+"-"+sl++;
        }
    }
}
