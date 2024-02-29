namespace BlogProject002.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BlogProject002.BlogDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BlogProject002.BlogDbContext context)
        {
            context.AdminInfo.Add(new AdminInfo { EmailId = "kiran@admin.com", Password = "kiran@1234" });
            context.SaveChanges();
            base.Seed(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
