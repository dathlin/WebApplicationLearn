﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MachineEntities : DbContext
    {
        public MachineEntities()
            : base("name=MachineEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<电梯台帐> 电梯台帐 { get; set; }
        public virtual DbSet<锅炉台账> 锅炉台账 { get; set; }
        public virtual DbSet<起重设备台帐> 起重设备台帐 { get; set; }
        public virtual DbSet<下沙新厂压力容器台账> 下沙新厂压力容器台账 { get; set; }
        public virtual DbSet<压力管道台帐> 压力管道台帐 { get; set; }
        public virtual DbSet<一般设备台账> 一般设备台账 { get; set; }
    }
}
