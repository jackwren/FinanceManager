using FinanceManger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinanceManger.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Details(int id)
        {
            UserContext UserContext = new UserContext();
            Users users = UserContext.Users.Single(u => u.UserID == id);
            return View(User);
        }
    }
}