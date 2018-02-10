using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System_EF.EntityModels
{
    public class ExpenseOperation
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string ExpenseName { get; set; }
        [Required]
        public int  Qty { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public decimal Paid  { get; set; }
        public decimal Due  { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [MaxLength(250)]
        public string Remarks { get; set; }
        [Required]
        [MaxLength(150)]
        public string EmployeeName { get; set; }
        [Required]
        [MaxLength(150)]
        public string OrganizationName { get; set; }
        [Required]
        [MaxLength(150)]
        public string OutletName { get; set; }
    }
}
