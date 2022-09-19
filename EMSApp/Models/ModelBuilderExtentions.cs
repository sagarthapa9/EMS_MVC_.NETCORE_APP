using Microsoft.EntityFrameworkCore;

namespace EMSApp.Models
{
    public static class ModelBuilderExtentions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "John Wick",
                    Email = "john_wick@watchnow.com"
                },
                new Employee
                {
                    Id = 2,
                    Name = "King Solomen",
                    Email = "iam_king@watchnow.com"
                },
                new Employee
                {
                    Id = 3,
                    Name = "Ram Charan",
                    Email = "ram.charan@watchnow.com"
                }

                );

        }
    }
}
