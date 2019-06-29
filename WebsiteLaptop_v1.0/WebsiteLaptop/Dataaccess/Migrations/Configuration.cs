namespace Dataaccess.Migrations
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Dataaccess.LaptopsDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Dataaccess.LaptopsDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //Rào lại để lỡ Update không bị trùng
            //Guid g1 = Guid.NewGuid();
            //Guid g2 = Guid.NewGuid();
            //context.Categories.AddOrUpdate(new Category() { CategoryID = 111, CategoryName = "Laptop" });
            //context.Categories.AddOrUpdate(new Category() { CategoryID = 112, CategoryName = "Mobile" });

            //context.Producers.AddOrUpdate(new Producer() { ProducerID = "ASU", ProducerName = "Asus" });

            //context.Products.AddOrUpdate(new Product() { ProducerID = "ASU", CategoryID = 111, ProductID = "ASU001", ProductName = "Asus VIVOBOOK X507UA-EJ234T", CPU = "Intel, Core i3", HardDrive = "HDD 5400rpm", RAM = "4 GB, DDR4", OperatingSystem = "Windows 10", Price = 10590000.0, VideoCard = "Intel HD graphics", Weight = 1.68, Size = "365 x 266 x 21.9", ImgName = "ASU001.jpg" });

            //context.Customers.AddOrUpdate(new Customer() { CustomerID = g1.ToString(), CustomerName = "Michael Owen", Address = "Chelsea City", Email = "cuuemvoi21@gmail.com", IdentityNumber = "123456789", Phone = "0774697027" });

            //context.Orders.AddOrUpdate(new Order() { OrderID = g2.ToString(), CustomerID = g1.ToString(), OrderDate = DateTime.Now });

            //context.OrderDetails.AddOrUpdate(new OrderDetail() { OrderID = g2.ToString(), ProductID = "ASU001", Quantity = 2 });

            context.SaveChanges();
        }
    }
}
