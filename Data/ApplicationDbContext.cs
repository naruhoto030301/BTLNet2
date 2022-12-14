using BTLNet2_Nhom11.Models;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Attribute = BTLNet2_Nhom11.Models.Attribute;




#nullable disable
namespace BTLNet2_Nhom11.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Attribute> Attributes { get; set; }
        public DbSet<AttributesPrice> AttributesPrices { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<QuangCao> QuangCaos { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<TransactStatus> TransactStatuses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<TinDang> TinDangs { get; set; }
        public DbSet<BTLNet2_Nhom11.ModelViews.RegisterViewModel> RegisterViewModels { get; set; }
        public DbSet<BTLNet2_Nhom11.ModelViews.LoginViewModel> LoginViewModels { get; set; }
        public DbSet<BTLNet2_Nhom11.ModelViews.CartItem> CartItems { get; set; }
        public DbSet<BTLNet2_Nhom11.ModelViews.ChangePasswordViewModel> ChangePasswordViewModels { get; set; }
        public DbSet<BTLNet2_Nhom11.ModelViews.HomeViewVM> HomeViewVMs { get; set; }
        public DbSet<BTLNet2_Nhom11.ModelViews.MuaHangSuccessVM> MuaHangSuccessVMs { get; set; }
        public DbSet<BTLNet2_Nhom11.ModelViews.MuaHangVM> muaHangVMs { get; set; }
        public DbSet<BTLNet2_Nhom11.ModelViews.ProductHomeVM> ProductHomeVMs { get; set; }
        public DbSet<BTLNet2_Nhom11.ModelViews.SearchProductVM> SearchProductVMs { get; set; }
        public DbSet<BTLNet2_Nhom11.ModelViews.XemDonHang> xemDonHangs { get; set; }
        
    }

}
