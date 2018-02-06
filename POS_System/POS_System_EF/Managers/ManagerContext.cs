using POS_System_EF.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System_EF.Managers
{
    public class ManagerContext:DbContext
    {
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Outlet> Outlets { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ItemCategory> ItemCategories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        

        
    }
}
