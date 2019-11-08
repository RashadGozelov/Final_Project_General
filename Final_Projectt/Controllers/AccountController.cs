using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;     // Send email
using System.Threading.Tasks;
using Final_Projectt.DAL;
using Final_Projectt.Models;
using Final_Projectt.Utilities;
using Final_Projectt.ViewModel;
using Microsoft.AspNetCore.Authorization;     //ForgotPassword 
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Final_Projectt.Controllers
{
    public class AccountController : Controller
    {
        private AppDbContext _context;
        private UserManager<AppUser> _userManager;
        private SignInManager<AppUser> _signInManager;
        public RoleManager<IdentityRole> _roleManager;

        public AccountController(AppDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (!ModelState.IsValid) return View(registerViewModel);
            AppUser newUser = new AppUser()
            {
                Name = registerViewModel.Name,
                Surname = registerViewModel.Surname,
                Email = registerViewModel.Email,
                UserName = registerViewModel.Email
            };

            IdentityResult identityResult = await _userManager.CreateAsync(newUser, registerViewModel.Password);

            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(registerViewModel);
            }
            await _userManager.AddToRoleAsync(newUser, Utility.Roles.Member.ToString());
            await _signInManager.SignInAsync(newUser, true);
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid) return View(loginViewModel);
            AppUser user = await _userManager.FindByEmailAsync(loginViewModel.Email);
            if (user == null)
            {
                ModelState.AddModelError("", "E-poçt ünvani v? sifr? s?hvdir");
                return View(loginViewModel);
            }
            Microsoft.AspNetCore.Identity.SignInResult signInResult = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, loginViewModel.RememberMe, true);
            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "E-poçt ünvani v? sifr? s?hvdir");
                return View(loginViewModel);
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Accountt()
        {
            return View();
        }

        public async Task RoleSeeder()
        {
            if (!await _roleManager.RoleExistsAsync(Utility.Roles.Admin.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Utility.Roles.Admin.ToString()));
            }
            if (!await _roleManager.RoleExistsAsync(Utility.Roles.Member.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Utility.Roles.Member.ToString()));
            }
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgotPassword()
        {
            return View();
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
        //{
        //    var MyUser = _context.Users.Where(x => x.Email == model.Email).FirstOrDefault();
        //    if (MyUser == null)
        //    {
        //        return BadRequest();
        //    }
        //    string mypass = Guid.NewGuid().ToString();
        //    string donedpass = mypass.Substring(0, 6);

        //    MailMessage mail = new MailMessage();
        //    mail.To.Add(model.Email);
        //    mail.From = new MailAddress(model.Email);


        //    mail.Body = $"<a href='https://localhost:44366/Account/Login' class='btn btn-primary'> Yeni Parolunuz</a>  <strong> {donedpass.ToString()} </strong> ";

        //    mail.Subject = "Yeni Sifreni Daxil Edin";

        //    mail.IsBodyHtml = true;
        //    SmtpClient smtp = new SmtpClient();
        //    smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
        //    smtp.Credentials = new System.Net.NetworkCredential
        //         ("emailini yazzzzzzz", "emailinin sifresinni yazzzzz"); // ***use valid credentials***
        //    smtp.Port = 587;

        //    //Or your Smtp Email ID and Password
        //    smtp.EnableSsl = true;
        //    smtp.Send(mail);

        //    MyUser.PasswordHash = _userManager.PasswordHasher.HashPassword(MyUser, donedpass);

        //    var result = await _userManager.UpdateAsync(MyUser);
        //    if (!result.Succeeded)
        //    {
        //        return Content("Parol deyisdirilmedi");
        //    }

        //    return Content("Deyisdirildi");
        //}


        //public IActionResult ResetPassword(string userid)
        //{
        //    return View("ResetPassword");
        //}



        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}


    }
}
