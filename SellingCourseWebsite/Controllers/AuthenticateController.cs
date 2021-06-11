using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SellingCourseWebsite.BLL.Dao;
using SellingCourseWebsite.BLL.ViewModel;
using SellingCourseWebsite.Utilities.Crypto;
using SellingCourseWebsite.Utilities.Email;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace SellingCourseWebsite.Controllers
{
    public class AuthenticateController : Controller
    {

        private readonly UserInfoDAORequest uiRequest = UserInfoDAORequest.GetInstance();

        /**
         * ======================================================
         * LOGIN
        **/

        public IActionResult Login()
        {
            ViewBag.alert = null;
            ViewBag.alert = TempData["alert"];
            return View();
        }

        [HttpPost]
        public IActionResult LoginDb()
        {
            string username = Request.Form["username"];
            string password = Request.Form["password"];
            var item = uiRequest.GetByUsername(username);
            if (item != null)
            {
                string hashed = PasswordSecurity.DecryptString(item.HashPassword);
                if (password.Equals(hashed))
                {
                    HttpContext.Session.SetInt32("id", item.Id);
                    HttpContext.Session.SetString("username", item.Username);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["alert"] = "Password wrong, try again";
                    return RedirectToAction("Login");
                }
            }
            else
            {
                TempData["alert"] = "this account is not exist, please sign up";
                return RedirectToAction("Login");
            }
        }

        public bool checkUsername(string username)
        {
            var item = uiRequest.GetByUsername(username);
            if (item != null)
            {
                return true;
            }
            return false;
        }


        /**
         * ======================================================
         * REGISTER
        **/

        public IActionResult Register()
        {
            ViewBag.alert = null;
            ViewBag.alert = TempData["RegisterAlert"];
            return View();
        }

        [HttpPost]
        public IActionResult RegisterDb()
        {
            string username = Request.Form["username"];
            string password = Request.Form["password"];
            string rePassword = Request.Form["re_password"];
            string email = Request.Form["email"];
            if (!CheckExistUsername(username, email))
            {
                if (CheckPasswordMatch(password, rePassword))
                {
                    string hashed = PasswordSecurity.EncryptString(password);
                    UserInfoViewModel newUser = new UserInfoViewModel()
                    {
                        Username = username,
                        HashPassword = hashed,
                        Email = email,
                        UserTypeId = 2,
                        Active = true
                    };

                    uiRequest.Add(newUser);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["RegisterAlert"] = "The Password and Re-Password not match";
                    return RedirectToAction("Register");
                }

            }
            else
            {
                TempData["RegisterAlert"] = "The username or email exist, Please try again";
                return RedirectToAction("Register");
            }
        }

        public bool CheckExistUsername(string username, string email)
        {
            var item = uiRequest.GetByUsernameAndEmail(username, email);
            if (item != null)
            {
                return true;
            }
            return false;
        }

        public bool CheckPasswordMatch(string password, string rePassword)
        {
            if (password.Equals(rePassword))
            {
                return true;
            }
            return false;

        }

        public bool CheckNullField(UserInfoViewModel user)
        {
            foreach (PropertyInfo pi in user.GetType().GetProperties())
            {
                if (pi.PropertyType == typeof(string))
                {
                    string value = (string)pi.GetValue(user);
                    if (string.IsNullOrEmpty(value))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /**
         * ======================================================
         * LOGOUT
        **/
        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        //Upload Image - Need to check
        public async Task<bool> UploadImage(IFormFile ufile)
        {
            if (ufile != null && ufile.Length > 0)
            {
                var fileName = Path.GetFileName(ufile.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\uploadImage", fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await ufile.CopyToAsync(fileStream);
                }
            }
            return false;
        }


        /**
         * ======================================================
         * FORGOT PASSWORD
        **/
        public IActionResult ForgotPassword()
        {
            ViewBag.alert = null;
            ViewBag.alert = TempData["fpAlert"];
            return View();
        }

        public IActionResult ForgotPasswordFeature()
        {
            string username = Request.Form["username"];
            string email = Request.Form["email"];
            if (CheckExistUsername(username, email))
            {
                var item = uiRequest.GetByUsername(username);
                string password = PasswordSecurity.DecryptString(item.HashPassword);
                string subject = "KrakenForce Forgot Password";
                string body = $"Your password is {password}";

                EmailFeature.SendEmail(email, subject, body);

                TempData["fpAlert"] = "Sent Email, Check your email to get Password";
                return RedirectToAction("ForgotPassword");
            }
            else
            {
                TempData["fpAlert"] = "Account not Exist, please register";
                return RedirectToAction("ForgotPassword");
            }

        }


        /**
         * ======================================================
         * CHANGE PASSWORD
        **/
        public IActionResult ChangePassword()
        {

            ViewBag.alert = null;
            ViewBag.alert = TempData["cpAlert"];
            return View();
        }

        public IActionResult ChangePasswordFeature()
        {
            var id = HttpContext.Session.GetInt32("id");

            var user = uiRequest.GetById((int)id);
            string password = PasswordSecurity.DecryptString(user.HashPassword);
            string oldPassword = Request.Form["oldPassword"];
            string newPassword = Request.Form["newPassword"];
            string rePassword = Request.Form["rePassword"];
            if (oldPassword.Equals(password))
            {
                if (CheckPasswordMatch(newPassword, rePassword))
                {
                    user.HashPassword = PasswordSecurity.EncryptString(newPassword);
                    uiRequest.Update(user);

                    TempData["cpAlert"] = "Change Password succesfully";
                    return RedirectToAction("ChangePassword");
                }
                else
                {
                    TempData["cpAlert"] = "New Password not match, try again";
                    return RedirectToAction("ChangePassword");
                }
            }
            else
            {
                TempData["cpAlert"] = "Wrong Password, please try again";
                return RedirectToAction("ChangePassword");
            }

        }

    }


}
