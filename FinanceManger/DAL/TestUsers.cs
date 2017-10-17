using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using FinanceManger.Models;

namespace FinanceManger.DAL
{
    public class TestUsers : System.Data.Entity.DropCreateDatabaseIfModelChanges<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            var users = new List<Users>
            {
            new Users{UserID=100,Username="test",Password="pasword"},
            new Users{UserID=200,Username="test2",Password="pasword"}
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

        }
    }
}