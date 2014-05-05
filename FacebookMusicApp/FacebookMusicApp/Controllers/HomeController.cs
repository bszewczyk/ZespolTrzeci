using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.AspNet.Mvc.Facebook;
using Microsoft.AspNet.Mvc.Facebook.Client;
using FacebookMusicApp.Models;
using System.Web;
using DayPilot.Web.Mvc;
using DayPilot.Web.Mvc.Events.Calendar;

namespace FacebookMusicApp.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Page in build";
        }
        [FacebookAuthorize("email", "user_photos")]
        public async Task<ActionResult> Index(FacebookContext context)
        {
            using (var ctx = new FBBDContext())
            {
                User nUser = new User() { NameAndSurname = "Pablo Pable"};

                ctx.User.Add(nUser);
                ctx.SaveChanges();

            }


            if (ModelState.IsValid)
            {
                var user = await context.Client.GetCurrentUserAsync<MyAppUser>();
                return View(user);
            }

            return View("Error");
        }

        // This action will handle the redirects from FacebookAuthorizeFilter when 
        // the app doesn't have all the required permissions specified in the FacebookAuthorizeAttribute.
        // The path to this action is defined under appSettings (in Web.config) with the key 'Facebook:AuthorizationRedirectPath'.
        public ActionResult Permissions(FacebookRedirectContext context)
        {
            if (ModelState.IsValid)
            {
                return View(context);
            }

            return View("Error");
        }
        public ActionResult Backend()
        {
            return new Dpc().CallBack(this);
        }
        class Dpc : DayPilotCalendar
        {

            protected override void OnInit(InitArgs e)
            {
                var db = new FBBDContext();
               // Events = from ev in db.Callendar select ev;

                DataIdField = "id";
                DataTextField = "text";
                DataStartField = "eventstart";
                DataEndField = "eventend";

                Update();
            }
        }
    }
}
