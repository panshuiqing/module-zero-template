﻿using System.Data.Common;
using Abp.Zero.EntityFramework;
using AbpCompanyName.AbpProjectName.Authorization.Roles;
using AbpCompanyName.AbpProjectName.MultiTenancy;
using AbpCompanyName.AbpProjectName.Users;

namespace AbpCompanyName.AbpProjectName.EntityFramework
{
    public class AbpProjectNameDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for each Entity...

        //Example:
        //public virtual IDbSet<User> Users { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public AbpProjectNameDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in AbpProjectNameDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of AbpProjectNameDbContext since ABP automatically handles it.
         */
        public AbpProjectNameDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public AbpProjectNameDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}
