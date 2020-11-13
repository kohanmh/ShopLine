using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopLine.Domain.Entity
{
    [Table("Cst1_Customer",Schema = "Cst")]
    public class CustomerEntity :BaseEntity
    {
        [Column("Cst1_Customer_ID")]
        public int ID { get; set; }
        [Column("Cst1_Customer_FirstName")]
        public string FirstName { get; set; }
        [Column("Cst1_Customer_LastName")]
        public string LastName { get; set; }
        [Column("Cst1_Customer_Age")]
        public int Age { get; set; }
        [Column("Cst1_Customer_BirthDay")]
        public DateTime BirthDay { get; set; }
    }
    public class CustomerEntityMap: EntityTypeConfiguration
}
