namespace GiftListEditor.DAL.Migrations
{
    using GiftListEditor.BLL.Enums;
    using GiftListEditor.BLL.Models;
    using PDCore.Extensions;
    using PDCoreNew.Extensions;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Globalization;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GiftListEditor.DAL.WebmailContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GiftListEditor.DAL.WebmailContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
