using Microsoft.EntityFrameworkCore;
using TesteLandysModel.Models;

namespace TesteLandysRepository.Context
{
    public class TesteLanysContext : DbContext
    {
        public TesteLanysContext(DbContextOptions<TesteLanysContext> options)
           : base(options)
        {
        }

        public DbSet<EndPoint> EndPoints { get; set; }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<EndPoint>(endpoint =>
            {
                endpoint.HasKey(e => e.Id);
                endpoint.HasIndex(e => e.SerialNumber);
                endpoint.Property(e => e.Id).IsRequired();
                endpoint.Property(e => e.MeterFirmwareVersion).IsRequired();
                endpoint.Property(e => e.MeterNumber).IsRequired();
                endpoint.Property(e => e.ModelId).IsRequired();
                endpoint.Property(e => e.SerialNumber).IsRequired();
                endpoint.Property(e => e.SwitchState).IsRequired();
            });
        
            base.OnModelCreating(modelBuilder);
        }
    }
}
