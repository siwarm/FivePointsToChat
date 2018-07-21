
using ChatApp.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChatApp.Controllers
{
    public class UserController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        // GET: User
        public ActionResult Index()
        {
            var userIdConnect = User.Identity.GetUserId();
            var ListUsers = (from l in _db.Users where
                                  !l.Id.Equals(userIdConnect)
                                 select l).ToList();

            return View(ListUsers);
        }
    }
}