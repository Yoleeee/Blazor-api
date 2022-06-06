
namespace BlazorApp7.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
        new Product
        {
                     Id = 1,
                     Title = "Ldssdabas",
                     Description = "t be shock, awe, or any other strongly felt emotion. In these such situations one must exclaim 'Bruh!', typically in a low tone of voice. Typically only men will exclaim using the word 'bruh', however, the S.O.B. (Society of Bruh) is a progressive union full of verified gamer bros and care not whether man nor woman exclaims with the word 'bruh'.",
                     ImageUrl = "https://static.truckersmp.com/images/vtc/logo/21823.1594940844.png",
                     Price = 9.99m
         },
        new Product
        {
            Id = 2,
            Title = "Ate",
            Description = "ffdfdffdfd",
            ImageUrl = "https://i1.sndcdn.com/artworks-WUn6AbCdLf93PTsy-G96wBw-t500x500.jpg",
            Price = 9.99m
        },
        new Product
        {
            Id = 3,
            Title = "Alio",
            Description = "ffdfd",
            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS2N6mPp7pI4GYStZ1HR9RKsXsvdzr3GT8wXA&usqp=CAU",
            Price = 9.99m
        }
                );
        }
        public DbSet<Product> Products { get; set; }
    }
}
