using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            //var connectionsString = "Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=mudar@123";
            var connectionsString = "Server=.\\SQLEXPRESS2017;User Id=sa;Pwd=mudar@123;Database=course";
            //var connectionsString = "Server=(local)\\SQLEXPRESS2017:1433;Database=dbAPI;";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseSqlServer(connectionsString);
            //optionsBuilder.UseMySql(connectionsString);
            return new MyContext(optionsBuilder.Options);
        }
    }
}
