using Newtonsoft.Json;
using SCC_Marina.Models;
using SCC_Marina.Services;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SCC_Marina.Controllers
{
    public class AuthController : Controller
    {
        private readonly AuthService _authService;

        public AuthController()
        {
            _authService = new AuthService();
        }

        // GET: Auth
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var result = await _authService.Authenticate(model);

                if(result != null)
                {
                    if (result.IsSuccessful)
                    {
                        var loggedInUser = JsonConvert.DeserializeObject<UserModel>(JsonConvert.SerializeObject(result.Data));
                        Session["Username"] = loggedInUser.Username;
                        Session["fullName"] = string.Format("{0}{1}", loggedInUser.FirstName, loggedInUser.LastName);

                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ViewBag.ErrorMessage = result.Message;
                    }
                }
            }

            return View();
        }

        public ActionResult LogOut()
        {
            Session["Username"] = null;
            Session["fullName"] = null;

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Register()
        {
            var model = new RegisterModel();

            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                if(model.Password != model.ConfirmPassword)
                {
                    return View(model);
                }
                else
                {
                    var result = await _authService.Register(model);

                    if (result.IsSuccessful)
                    {
                        ViewBag.Message = result.Message;

                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ViewBag.Message = result.Message;

                        return View(model);
                    }
                }
            }

            return View(model);
        }
    }
}