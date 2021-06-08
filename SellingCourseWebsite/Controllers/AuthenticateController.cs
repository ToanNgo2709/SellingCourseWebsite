using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SellingCourseWebsite.BLL.Dao;
using SellingCourseWebsite.BLL.ViewModel;
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
            return View();
        }

        public IActionResult LoginDb()
        {
            return Json("result");
        }

        /**
         * ======================================================
         * REGISTER
        **/

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult RegisterDb(UserInfoViewModel user)
        {
            const string SessionAlert = "_Alert";
            if (!CheckExistUsername(user))
            {
                uiRequest.Add(user);
                return RedirectToAction();
            }
            else
            {

                HttpContext.Session.SetString(SessionAlert,"Username existed, please choose another");
            }            

            return RedirectToAction();
        }

        public bool CheckExistUsername(UserInfoViewModel user)
        {
            var item = uiRequest.GetById(user.Id);
            if (item != null)
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
            return View();
        }

        public IActionResult ForgotPasswordFeature()
        {
            return RedirectToAction();
        }


        /**
         * ======================================================
         * CHANGE PASSWORD
        **/
        public IActionResult ChangePassword()
        {
            return View();
        }

        public IActionResult ChangePasswordFeature()
        {
            return View();
        }


    }
}
