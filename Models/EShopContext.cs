using EShop.ViewModel;
using System.Data.Entity;


namespace EShop.Models
{
    public class EShopContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public EShopContext() : base("name=EShopContext")
        {
        }

        public DbSet<Item> Item { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Cart> Carts { get; set; }

        public DbSet<ShoppingViewModelCart> ShoppingViewModelCarts { get; set; }
    }
}