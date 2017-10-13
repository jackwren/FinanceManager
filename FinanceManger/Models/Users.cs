using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FinanceManger.Models
{
    [Table("Users")]
    public class Users
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
    public class UserContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
    }
}