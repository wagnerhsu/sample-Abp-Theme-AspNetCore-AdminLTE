﻿using MongoDB.Driver;
using AdminLETDemo.Users;
using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace AdminLETDemo.MongoDB
{
    [ConnectionStringName("Default")]
    public class AdminLETDemoMongoDbContext : AbpMongoDbContext
    {
        public IMongoCollection<AppUser> Users => Collection<AppUser>();

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.Entity<AppUser>(b =>
            {
                /* Sharing the same "AbpUsers" collection
                 * with the Identity module's IdentityUser class. */
                b.CollectionName = "AbpUsers";
            });
        }
    }
}
