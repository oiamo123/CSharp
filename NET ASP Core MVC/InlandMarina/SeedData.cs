using InlandMarinaData;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace InlandMarina
{
    public static class SeedData
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {

            using (var scope = serviceProvider.CreateScope())
            {
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<Customer>>();
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                var context = scope.ServiceProvider.GetRequiredService<InlandMarinaContext>();

                context.Database.EnsureCreated();

                // Seed Customers
                if (!context.Customers.Any())
                {
                    var customers = new List<Customer>
                {
                new Customer
                {
                    Id = "1",
                    FirstName = "John",
                    LastName = "Doe",
                    Phone = "265-555-1212",
                    City = "Phoenix",
                    Email = "john.doe@example.com",
                    UserName = "john.doe@example.com"
                },
                new Customer
                {
                    Id = "2",
                    FirstName = "Sara",
                    LastName = "Williams",
                    Phone = "403-555-9585",
                    City = "Calgary",
                    Email = "sara.williams@example.com",
                    UserName = "sara.williams@example.com"
                },
                new Customer
                {
                    Id = "3",
                    FirstName = "Ken",
                    LastName = "Wong",
                    Phone = "802-555-3214",
                    City = "Kansas City",
                    Email = "ken.wong@example.com",
                    UserName = "ken.wong@example.com"
                }
                };

                await roleManager.CreateAsync(new IdentityRole("Customer"));

                foreach (var customer in customers)
                {
                        await userManager.CreateAsync(customer, "#Password1");
                        await userManager.AddToRoleAsync(customer, "Customer");
                }
                }

                // Seed a special user (Admin)
                if (!context.Users.Any(u => u.Email == "HarryPotter@Hogwarts.uk"))
                {
                    var user = new Customer
                    {
                        Id = "4",
                        FirstName = "Harry",
                        LastName = "Potter",
                        Email = "HarryPotter@Hogwarts.uk",
                        UserName = "HarryPotter@Hogwarts.uk",
                        City = "Calgary",
                        Phone = "555-555-5555"
                    };

                    await userManager.CreateAsync(user, "#Password1");
                }

                // Seed Leases
                if (!context.Leases.Any())
                {
                   context.Leases.AddRange(
                   new Lease { SlipID = 20, CustomerID = "1" },
                   new Lease { SlipID = 42, CustomerID = "2" },
                   new Lease { SlipID = 88, CustomerID = "3" }
               );
                }
               

                await context.SaveChangesAsync();

                // Seed Roles
                
                await roleManager.CreateAsync(new IdentityRole("Admin"));

                // Assign Admin role to Harry Potter
                var adminUser = await userManager.FindByEmailAsync("HarryPotter@Hogwarts.uk");
                if (adminUser != null)
                {
                    await userManager.AddToRoleAsync(adminUser, "Admin");
                }
            }
        }
    }
}
