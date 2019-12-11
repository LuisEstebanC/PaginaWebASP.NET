using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Socios.Areas.Socio.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private UserManager<IdentityUser> _userManager;
        public RegisterModel(UserManager<IdentityUser>userManager)
        {
            _userManager = userManager;
        }
        public void OnGet()
        {

        }
        [BindProperty]
        public InputModel Input { get; set; }
        public class InputModel
        {
            [Required(ErrorMessage ="El campo email es obligatorio.")]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }


            [Required(ErrorMessage = "El campo contraseña  es obligatorio.")]
            [DataType(DataType.Password)]
            [Display(Name = "Contraseña")]
            [StringLength(100, ErrorMessage ="El numero de caracteres de {0} debe ser al menos {2}.",MinimumLength =6)]
            public string Password { get; set; }


            [Required(ErrorMessage = "El campo confirmacion contraseña  es obligatorio.")]
            [DataType(DataType.Password)]
            [Compare("Password",ErrorMessage ="La contraseña de confirmacion es incorrecta.")]
            public string ConfirmarPassword { get; set; }

            public string ErrorMessage { get; set; }
        }
        
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var userList = _userManager.Users.Where(u => u.Email.Equals(Input.Email)).ToList();
                if (userList.Count.Equals(0))
                {
                    var user = new IdentityUser
                    {
                        UserName = Input.Email,
                        Email =Input.Email
                    };
                    var result = await _userManager.CreateAsync(user, Input.Password);
                    if(result.Succeeded)    
                    {
                        return Page();
                    } else
                    {
                        foreach(var item in result.Errors)
                        {
                            Input = new InputModel
                            {
                                ErrorMessage = item.Description,
                            };
                        }
                        return Page();
                    }
                }
                else
                {
                    Input = new InputModel
                    {
                        ErrorMessage = "El Usuario " + Input.Email + " ya esta registrado",
                    };
                }
            }
          
            return Page();
        }
    }
}
