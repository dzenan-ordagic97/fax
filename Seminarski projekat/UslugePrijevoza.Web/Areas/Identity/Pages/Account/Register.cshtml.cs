using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using UslugePrijevoza.Web.Areas.Identity.Data;
using UslugePrijevoza.Web.Areas.Identity.ViewModels;
using UslugePrijevoza.Web.Models;

namespace UslugePrijevoza.Web.Areas.Identity.Pages.Account
{


    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<MojIdentityUser> _signInManager;
        private readonly UserManager<MojIdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly MojDBContext _db;


        public RegisterModel(
            UserManager<MojIdentityUser> userManager,
            SignInManager<MojIdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,MojDBContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            Input = new InputModel();
            _db = db;
        }

        public class InputModel
        {
            [Required]
            [Display(Name = "FirstName")]
            public string FirstName { get; set; }

            [Required]
            [Display(Name = "LastName")]
            public string LastName { get; set; }
            public FormaKlijentVM Klijent { get; set; }
            public FormaPrijevoznikVM Prijevoznik { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }
        [BindProperty]
        public InputModel Input { get; set; }


        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }


        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }


        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            IdentityResult result = null;
            if (ModelState.IsValid)
            {
                MojIdentityUser user = null;
                if (Input.Klijent != null)
                {
                    int? _AdresaID = _db.Adresa.Where(x => x.Naziv.Equals(Input.Klijent.Adresa)).Select(x => x.AdresaID).FirstOrDefault();
                    if (_AdresaID == 0 || _AdresaID == null)
                    {
                        Adresa adresa = new Adresa()
                        {
                            Naziv = Input.Klijent.Adresa,
                            GradID = Input.Klijent.GradID
                        };
                        _db.Adresa.Add(adresa);
                        _db.SaveChanges();
                        _AdresaID = adresa.AdresaID;
                    }
                    user = new MojIdentityUser { Ime = Input.FirstName, Prezime = Input.LastName, UserName = Input.Email,PhoneNumber = Input.Klijent.Telefon,AdresaID = (int)_AdresaID, Email = Input.Email, EmailConfirmed = true,Spol=Input.Klijent.Spol,JMBG=Input.Klijent.JMBG,DatumRodjenja=Input.Klijent.DatumRodjenja };
                    result = await _userManager.CreateAsync(user, Input.Password);
                    if (result.Succeeded)
                    {
                        var curentUser = await _userManager.FindByNameAsync(user.UserName);
                        await _userManager.AddToRoleAsync(curentUser, "Klijent");
                    }
                }
                if (Input.Prijevoznik != null)
                {
                    int? _AdresaID = _db.Adresa.Where(x => x.Naziv.Equals(Input.Prijevoznik.Adresa)).Select(x => x.AdresaID).FirstOrDefault();
                    if (_AdresaID == 0 || _AdresaID == null)
                    {
                        Adresa adresa = new Adresa()
                        {
                            Naziv = Input.Prijevoznik.Adresa,
                            GradID = Input.Prijevoznik.GradID
                        };
                        _db.Adresa.Add(adresa);
                        _db.SaveChanges();
                        _AdresaID = adresa.AdresaID;
                    }
                    user = new MojIdentityUser { Ime = Input.FirstName, Prezime = Input.LastName, UserName = Input.Email, PhoneNumber = Input.Prijevoznik.Telefon, AdresaID = (int)_AdresaID, Email = Input.Email, EmailConfirmed = true,Spol=Input.Prijevoznik.Spol,JMBG=Input.Prijevoznik.JMBG,DatumRodjenja=Input.Prijevoznik.DatumRodjenja };
                   
                    result = await _userManager.CreateAsync(user, Input.Password);

                    var curentUser = await _userManager.FindByNameAsync(user.UserName);
                    await _userManager.AddToRoleAsync( curentUser, "Prijevoznik");


                    Models.Prijevoznik prijevoznik = new Models.Prijevoznik()
                    {
                        EmailPrijevoznika = Input.Prijevoznik.KontaktEmail,
                        NazivPrijevoznika = Input.Prijevoznik.NazivPrijevoznika,
                        UserID = user.Id
                        
                    };
                    _db.Prijevoznik.Add(prijevoznik);
                    _db.SaveChanges();
                }
                if (result.Succeeded)
                {

                 
                        _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));

                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
