﻿using LWI.Views.Account;
using Microsoft.AspNetCore.Identity;

namespace LWI.Models
{
    public class AccountService
    {
        UserManager<CourseCreator> userManager;
        SignInManager<CourseCreator> signInManager;
        RoleManager<IdentityRole> roleManager;
        public AccountService(UserManager<CourseCreator> userManager,
        SignInManager<CourseCreator> signInManager,
        RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public async Task<string> CreateAccount(CreateVM model)
        {
            var user = new CourseCreator
            {
                UserName = model.Username,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Occupation = model.Profession,
                Description = model.Description
            };

            IdentityResult result = await userManager.CreateAsync(user, model.Password);

            return result.Succeeded ? null : "Ditt konto kunde inte skapas :( ";
        }

        internal async Task Logout()
        {
            await signInManager.SignOutAsync();
        }

        internal async Task<string> TryLoginAsync(LoginVM model)
        {
            SignInResult result = await signInManager.PasswordSignInAsync(
                model.Username,
                model.Password,
                isPersistent: false,
                lockoutOnFailure: false
                );

            return result.Succeeded ? null : "Kunde inte logga in";
        }
    }
}
