using Energify.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Energify.Data
{
    public static class InitialData
    {
        public static void seed(this EnergifyDbContext dbContext)
        {
            if (!dbContext.UsersList.Any())
            {
                dbContext.UsersList.Add(new UserEntity {rolecode=0, Name = "Admin",Email="Admin@energify.com" ,Password="Admin123",Address="NA"});
                dbContext.UsersList.Add(new UserEntity { rolecode = 1, Name = "Rishabh", Email = "Rishabh@energify.com", Password = "Rishabh123", Address = "HSR layout" });
                dbContext.UsersList.Add(new UserEntity { rolecode = 1, Name = "Shukla", Email = "Shukla@energify.com", Password = "Shukla123", Address = "Nagpara" });
                dbContext.SaveChanges();
            }
            if (!dbContext.ProductsList.Any())
            {
                dbContext.ProductsList.Add(new ProductEntity
                {
                    Name = "Shell Helix Ultra",
                    Description = "This is a two wheeler engine oil ",
                    Price = 400,
                    Quantity = 1,
                    Measurement = "litres",
                    Status = "In stock/Available",
                    Image = "https://rukminim1.flixcart.com/image/416/416/kqwobrk0/vehicle-lubricant/j/z/g/4-helix-ultra-5w-40-fully-synthetic-motor-oil-shell-original-imag4t94uttqcbpn.jpeg?q=70",
                    CategoryName = "Lubricants"
                });

                dbContext.ProductsList.Add(new ProductEntity
                {

                    Name = "Shell Advance",
                    Description = "This is a two wheeler engine oil ",
                    Price = 600,
                    Quantity = 1,
                    Measurement = "litres",
                    Status = "In stock/Available",
                    Image = "https://m.media-amazon.com/images/I/416HIhblslL.jpg",
                    CategoryName = "Lubricants"
                });
                dbContext.ProductsList.Add(new ProductEntity
                {


                    Name = "Shell Advance AX-5",
                    Description = "This is a two wheeler engine oil ",
                    Price = 650,
                    Quantity = 1,
                    Measurement = "litres",
                    Status = "Out of stock/Unavailable",
                    Image = "https://m.media-amazon.com/images/I/71kjJSfI2pL._SY355_.jpg",
                    CategoryName = "Lubricants"

                });

                dbContext.ProductsList.Add(new ProductEntity
                {


                    Name = "Petrol",
                    Description = "This is Petrol ",
                    Price = 105,
                    Quantity = 1,
                    Measurement = "litres",
                    Status = "Available",
                    Image = "https://hindi.cdn.zeenews.com/hindi/sites/default/files/2022/09/25/1337563-3.jpg",
                    CategoryName = "Fuel"

                });
                dbContext.ProductsList.Add(new ProductEntity
                {


                    Name = "Diesel",
                    Description = "This is Diesel ",
                    Price = 95,
                    Quantity = 1,
                    Measurement = "litres",
                    Status = "Available",
                    Image = "https://img.theweek.in/content/dam/week/news/biz-tech/diesel.jpg",
                    CategoryName = "Fuel"

                });
                dbContext.ProductsList.Add(new ProductEntity
                {


                    Name = "Bio-diesel",
                    Description = "This is bio-diesel",
                    Price = 68,
                    Quantity = 1,
                    Measurement = "litres",
                    Status = "Available",
                    Image = "https://5.imimg.com/data5/VX/IF/MY-8909419/biodiesel-500x500.jpg",
                    CategoryName = "Fuel"

                });
                dbContext.ProductsList.Add(new ProductEntity
                {


                    Name = "LPG",
                    Description = "This is LPG ",
                    Price = 39,
                    Quantity = 1,
                    Measurement = "litres",
                    Status = "Available",
                    Image = "https://punegas.com/wp-content/uploads/2020/07/Untitled-design-1-2.png",
                    CategoryName = "Fuel"

                });
                dbContext.SaveChanges();




            }
            if (!dbContext.TicketList.Any())
            {
                dbContext.TicketList.Add(new TicketEntity
                {
                    TicketId = "RTM101",
                    Email = "abc@energify.com",
                    Category = "Shell Advance",
                    Description = "This is a two wheeler engine oil ",
                    Status = "Approved",
                }); ;
                dbContext.TicketList.Add(new TicketEntity
                {

                    TicketId = "RTM102",
                    Email = "abc@energify.com",
                    Category = "Shell Advance AX-5",
                    Description = "This is a two wheeler engine oil ",
                    Status = "Rejected",

                });

                dbContext.TicketList.Add(new TicketEntity
                {

                    TicketId = "RTM103",
                    Email = "abc@energify.com",
                    Category = "Petrol",
                    Description = "This is Petrol ",
                    Status = "Approved",

                });
                dbContext.TicketList.Add(new TicketEntity
                {

                    TicketId = "RTM104",
                    Email = "abc@energify.com",
                    Category = "Diesel",
                    Description = "This is Diesel ",
                    Status = "Approved",

                });
                dbContext.TicketList.Add(new TicketEntity
                {

                    TicketId = "RTM105",
                    Email = "abc@energify.com",
                    Category = "Bio-diesel",
                    Description = "This is bio-diesel",
                    Status = "Rejected",


                });
                dbContext.TicketList.Add(new TicketEntity
                {

                    TicketId = "RTM106",
                    Email = "abc@energify.com",
                    Category = "LPG",
                    Description = "This is LPG ",
                    Status = "Approved",

                });
                dbContext.SaveChanges();

            }
        }
    }
}
