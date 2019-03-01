namespace NLayerCore.Migrations
{
    using Microsoft.EntityFrameworkCore;

    public class DbContextDesignTimeDbContextFactory :
        DesignTimeDbContextFactoryBase<MyDbContext>
    {
        protected override MyDbContext CreateNewInstance(
            DbContextOptions<MyDbContext> options)
        {
            return new MyDbContext(options);
        }
    }
}