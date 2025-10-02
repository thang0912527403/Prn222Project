using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Prn222Project.Models;

namespace Prn222Project.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Cấu hình quan hệ
            modelBuilder.Entity<ProductVariant>()
       .HasOne(pv => pv.Product)
       .WithMany(p => p.ProductVariants)
       .HasForeignKey(pv => pv.ProductId);

            modelBuilder.Entity<ProductCategory>()
                .HasKey(pc => new { pc.ProductId, pc.CategoryId });

            modelBuilder.Entity<ProductCategory>()
                .HasOne(pc => pc.Product)
                .WithMany(p => p.ProductCategories)
                .HasForeignKey(pc => pc.ProductId);

            modelBuilder.Entity<ProductCategory>()
                .HasOne(pc => pc.Category)
                .WithMany(c => c.ProductCategories)
                .HasForeignKey(pc => pc.CategoryId);
            modelBuilder.Entity<OrderDetail>()
                .HasKey(od => new { od.order_id, od.productVariant_id });
            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.order_id);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.ProductVariant)
                .WithMany()
                .HasForeignKey(od => od.productVariant_id);

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Lược dáng cá heo gỗ bách xanh",
                    Description = "Lược Gỗ Massage Da Đầu Thủ Công - Bí quyết chăm sóc sức khoẻ tự nhiên mỗi ngày!",
                    IsDeleted = false,
                    IsActive = true,
                    ModifiedDate = DateTime.Now,
                    ImageUrl = "/images/luoc_dang_ca_heo_go_bach_xanh.webp", 
                    Price = 40000
                },
                new Product
                {
                    Id = 2,
                    Name = "Lược bán tròn bách xanh",
                    Description = "Lược Gỗ Massage Da Đầu Thủ Công - Bí quyết chăm sóc sức khoẻ tự nhiên mỗi ngày!",
                    IsDeleted = false,
                    IsActive = true,
                    ModifiedDate = DateTime.Now,
                    ImageUrl = "/images/luoc_ban_tron_bach_xanh.PNG", 
                    Price = 40000
                }, new Product
                {
                    Id = 3,
                    Name = "Lược gỗ cá heo đàn hương",
                    Description = "Lược Gỗ Massage Da Đầu Thủ Công - Bí quyết chăm sóc sức khoẻ tự nhiên mỗi ngày!",
                    IsDeleted = false,
                    IsActive = true,
                    ModifiedDate = DateTime.Now,
                    ImageUrl = "/images/luoc-go-ca-heo-dan-huong.PNG", 
                    Price = 50000
                }, new Product
                {
                    Id = 4,
                    Name = "Giá đỡ điện thoại gỗ sồi nhỏ trắng",
                    Description = "Giá đỡ điện thoại gỗ - phụ kiện nhỏ gọn nhưng cực kỳ hữu ích cho bàn học, bàn làm việc và không gian sống của bạn.",
                    IsDeleted = false,
                    IsActive = true,
                    ModifiedDate = DateTime.Now,
                    ImageUrl = "/images/gia-do-dt-go-soi-nho-trang.PNG", 
                    Price = 50000
                }, new Product
                {
                    Id = 5,
                    Name = "Giá đỡ điện thoại gỗ óc chó nhỏ nâu",
                    Description = "Giá đỡ điện thoại gỗ - phụ kiện nhỏ gọn nhưng cực kỳ hữu ích cho bàn học, bàn làm việc và không gian sống của bạn.",
                    IsDeleted = false,
                    IsActive = true,
                    ModifiedDate = DateTime.Now,
                    ImageUrl = "/images/gia-do-dt-go-oc-cho-nho-nau.PNG", 
                    Price = 63000
                }, new Product
                {
                    Id = 6,
                    Name = "Giá đỡ điện thoại to trắng gỗ sồi",
                    Description = "Giá đỡ điện thoại gỗ - phụ kiện nhỏ gọn nhưng cực kỳ hữu ích cho bàn học, bàn làm việc và không gian sống của bạn.",
                    IsDeleted = false,
                    IsActive = true,
                    ModifiedDate = DateTime.Now,
                    ImageUrl = "/images/gia-do-dt-to-trang-go-soi.PNG", 
                    Price = 75000
                }, new Product
                {
                    Id = 7,
                    Name = "Bàn chải masa",
                    Description = "Lược gỗ massage toàn thân - dụng cụ chăm sóc sức khỏe tự nhiên, giúp thư giãn và giảm căng thẳng hiệu quả.",
                    IsDeleted = false,
                    IsActive = true,
                    ModifiedDate = DateTime.Now,
                    ImageUrl = "/images/ban-chai-masa.PNG", 
                    Price = 50000
                }, new Product
                {
                    Id = 8,
                    Name = "Túi đựng thìa đũa 3 món",
                    Description = "Bộ thìa đũa gỗ kèm túi vải họa tiết Nhật Bản - lựa chọn hoàn hảo cho những ai yêu thích sự tiện lợi và lối sống xanh.",
                    IsDeleted = false,
                    IsActive = true,
                    ModifiedDate = DateTime.Now,
                    ImageUrl = "/images/tui-dung-thia-dua-3-mon.PNG", 
                    Price = 68000
                }, new Product
                {
                    Id = 9,
                    Name = "Túi đựng thìa đũa 2 món trơn",
                    Description = "Bộ thìa đũa gỗ kèm túi vải họa tiết Nhật Bản - lựa chọn hoàn hảo cho những ai yêu thích sự tiện lợi và lối sống xanh.",
                    IsDeleted = false,
                    IsActive = true,
                    ModifiedDate = DateTime.Now,
                    ImageUrl = "/images/tui-dung-thia-dua-2-mon-tron.PNG", 
                    Price = 43000
                }, new Product
                {
                    Id = 10,
                    Name = "Túi đựng thìa đũa 2 món cán bọc",
                    Description = "Bộ thìa đũa gỗ kèm túi vải họa tiết Nhật Bản - lựa chọn hoàn hảo cho những ai yêu thích sự tiện lợi và lối sống xanh.",
                    IsDeleted = false,
                    IsActive = true,
                    ModifiedDate = DateTime.Now,
                    ImageUrl = "/images/tui-dung-thia-dua-2-mon-can-boc.PNG", 
                    Price = 50000
                }, new Product
                {
                    Id = 11,
                    Name = "Hộp đựng thìa đũa 2 món cán trơn",
                    Description = "Bộ đũa muỗng gỗ kèm hộp đựng tiện lợi - giải pháp gọn gàng, vệ sinh và thân thiện môi trường cho bữa ăn mỗi ngày.",
                    IsDeleted = false,
                    IsActive = true,
                    ModifiedDate = DateTime.Now,
                    ImageUrl = "/images/hop-dung-thia-dua-2-mon-can-tron.PNG", 
                    Price = 56000
                }, new Product
                {
                    Id = 12,
                    Name = "Hộp đựng thìa đũa 2 món cán bọc",
                    Description = "Bộ đũa muỗng gỗ kèm hộp đựng tiện lợi - giải pháp gọn gàng, vệ sinh và thân thiện môi trường cho bữa ăn mỗi ngày.",
                    IsDeleted = false,
                    IsActive = true,
                    ModifiedDate = DateTime.Now,
                    ImageUrl = "/images/hop-dung-thia-dua-2-mon-can-boc.PNG", 
                    Price = 69000
                }, new Product
                {
                    Id = 13,
                    Name = "Móc treo 12 con giáp",
                    Description = "Móc khóa 12 con giáp bằng gỗ 2025 là một phụ kiện thời trang độc đáo, mang đậm nét văn hóa và phong thủy Việt Nam.",
                    IsDeleted = false,
                    IsActive = true,
                    ModifiedDate = DateTime.Now,
                    ImageUrl = "/images/moc-treo-12-con-giap.PNG", 
                    Price = 79000
                }, new Product
                {
                    Id = 14,
                    Name = "Quạt cầm tay",
                    Description = "Quạt Cầm Tay Bằng Rơm Dệt Thủ Công Ba Tiêu Cổ Trang.",
                    IsDeleted = false,
                    IsActive = true,
                    ModifiedDate = DateTime.Now,
                    ImageUrl = "/images/quat-cam-tay.PNG", 
                    Price = 90000
                }, new Product
                {
                    Id = 15,
                    Name = "Rổ tre đan 2 lớp",
                    Description = "Mây Tre Truyền Thống - Rổ Tre Đan Thủ Công 2 Lớp là sản phẩm lưu trữ hoàn hảo cho ngôi nhà của bạn.",
                    IsDeleted = false,
                    IsActive = true,
                    ModifiedDate = DateTime.Now,
                    ImageUrl = "/images/ro-tre-dan-2-lop.PNG", 
                    Price = 103000
                }, new Product
                {
                    Id = 16,
                    Name = "Dép cói",
                    Description = "Dép Cói Thủ Công là sự kết hợp hoàn hảo giữa phong cách truyền thống và sự thoải mái hiện đại.",
                    IsDeleted = false,
                    IsActive = true,
                    ModifiedDate = DateTime.Now,
                    ImageUrl = "/images/dep-coi.PNG", 
                    Price = 51000
                }, new Product
                {
                    Id = 17,
                    Name = "Bình giữ nhiệt đan tre ",
                    Description = "BÌNH GIỮ NHIỆT ĐAN TRE - ĐẸP, BỀN, CHUẨN XANH!",
                    IsDeleted = false,
                    IsActive = true,
                    ModifiedDate = DateTime.Now,
                    ImageUrl = "/images/binh-giu-nhiet-dan-tre.PNG", 
                    Price = 450000
                }, new Product
                {
                    Id = 18,
                    Name = "Lược bán tròn đàn hương",
                    Description = "Lược Gỗ Massage Da Đầu Thủ Công - Bí quyết chăm sóc sức khoẻ tự nhiên mỗi ngày!",
                    IsDeleted = false,
                    IsActive = true,
                    ModifiedDate = DateTime.Now,
                    ImageUrl = "/images/luoc_dang_ca_heo_go_bach_xanh.webp", 
                    Price = 45000
                }
            );
        }
    }
}
