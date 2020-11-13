using Microsoft.EntityFrameworkCore;
using ShopLine.Data.Infra;
using ShopLine.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ShopLine.Data
{
    public class ShopLineDBContext : DbContext
    {
        #region Ctor
        public ShopLineDBContext(DbContextOptions<ShopLineDBContext> options) : base(options)
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    // optionsBuilder.UseSqlServer(@"data source=.;initial catalog=MyProject;user id=sa;password=123456");
        //}

        public string GenerateCreateScript()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Utilities

        #endregion
        #region Methods





        #endregion

        //public static CallClassEntity()
        //{
        //    Type parentType = typeof(BaseEntity);
        //    var ListClassEntity = MyReflection.GetClassByParentName(parentType);
        //    foreach (var entity in ListClassEntity)
        //    {
        //            cntx.Set(entity.GetType()).Add(entity);
              
        //        DbSet<entity> entities { get;DbSet; }
        //    }
        //}
    }
}
