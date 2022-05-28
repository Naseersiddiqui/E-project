using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;
using Security_system.Models;
using System.Data.Entity;
using System.IO;


namespace Security_system.Controllers
{
    public class AdminController : Controller
    {

        db_Star_SecurityEntities db = new db_Star_SecurityEntities();


        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            if (Session["user_id"] != null)
            {
                return RedirectToAction("Index", "Admin");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Register(tb_Users users)
        {
            if (ModelState.IsValid)
            {
                var isEmailAlreadyExists = db.tb_Users.Any(x => x.email == users.email);
                if (isEmailAlreadyExists)
                {
                    ModelState.AddModelError("email_address", "Email already exists, please enter another email");
                    return View(users);
                }

                users.join_date = DateTime.Now;
                users.updated_at = DateTime.Now;

                db.tb_Users.Add(users);
                //db.SaveChanges();
                TempData["success"] = "Your account has been created!";

                return RedirectToAction("Login");
            }

            return View(users);
        }
        [HttpGet]
        public ActionResult Login()
        {
            if (Session["admin_id"] != null)
            {
                return RedirectToAction("Index", "Admin");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel login_form)
        {
            if (ModelState.IsValid)
            {
                var admin = db.tb_Users.Where(a => a.email.Equals(login_form.email) && a.password.Equals(login_form.password) ).FirstOrDefault();

                if (admin != null)
                {
                    Session["admin_id"] = admin.user_id.ToString();
                    Session["admin_name"] = admin.name.ToString() + " " + admin.name.ToString();

                    FormsAuthentication.SetAuthCookie(admin.address, false); // form fields saved in browser are stored in cookies

                    return RedirectToAction("Index", "Admin");
                }
            }

            // in case of error
            ModelState.AddModelError("InvalidLoginError", "Invalid email or password or perhaps you are not a verified user!");
            return View(login_form);
        }
    }
}