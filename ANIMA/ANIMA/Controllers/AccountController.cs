using ANIMA.Domain.Entities;
using ANIMA.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ANIMA.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly UserManager<Author> userManager;
        private readonly SignInManager<Author> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public AccountController(UserManager<Author> userManager,
                                SignInManager<Author> signInManager,
                                RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }

        public IActionResult SignIn(string returnUrl)
        {
            ViewBag.ReturnURL = returnUrl;
            return View(new SignInViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(SignInViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    await Authenticate(user);
                    return Redirect(returnUrl ?? "/");
                }

                ModelState.AddModelError(nameof(SignInViewModel.Email), "FALSE PASSWORD OR LOGIN.");
            }

            return View(model);
        }

        public IActionResult SignUp(string returnUrl = null)
        {
            ViewBag.ReturnURL = returnUrl;
            return View(new SignUpViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(model.Email);
                if (user == null)
                {
                    user = new Author
                    {
                        Id = Guid.NewGuid().ToString(),
                        Email = model.Email,
                        UserName = model.AuthorName,
                        PasswordHash = new PasswordHasher<Author>().HashPassword(null, model.Password),
                    };

                    var result = await userManager.CreateAsync(user, model.Password);

                    await userManager.AddClaimAsync(user, new Claim(ClaimsIdentity.DefaultNameClaimType, user.Email));
                    await userManager.AddToRoleAsync(user, "user");

                    if (result.Succeeded)
                    {
                        await Authenticate(user);
                        return Redirect(returnUrl ?? "/");
                    }
                }
                else
                {
                    ModelState.AddModelError(nameof(SignInViewModel.Email), $"USER WITH EMAIL {model.Email} ALREADY EXISTS.");
                }
            }

            return View(model);
        }

        private async Task Authenticate(Author user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Email)
            };

            await signInManager.SignInWithClaimsAsync(user, true, claims);
        }
    }
}
