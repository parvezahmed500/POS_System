using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System_EF.EntityModels
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        [ForeignKey("Item")]
        public int ItemId { get; set; }
        public Item Item { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal CostPrice { get; set; }
        public decimal TotalPrice { get; set; }
        [Required]
        public DateTime PurchaseDate { get; set; }
        public string Remarks { get; set; }
        [ForeignKey("Outlet")]
        public int OutletId { get; set; }
        public Outlet Outlet { get; set; }
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        [ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
    }
}