using FinalProject_ABBOTT.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace FinalProject_ABBOTT.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ValidationController : Controller
    {
        private ContestantsContext context;
        public ValidationController(ContestantsContext ctx) => context = ctx;

        public JsonResult CheckEmail(string email)
        {
            string msg =Check.EmailExists(context, email);
            if (string.IsNullOrEmpty(msg))
            {
                TempData["okEmail"] = true;
                return Json(TempData);
            }
            else return Json(msg);
        }
    }

    //Used to check if the email already exists in the database
    public static class Check
    {
        public static string EmailExists(ContestantsContext ctx, string email)
        {
            string msg = string.Empty;
            if (!string.IsNullOrEmpty(email))
            {
                var contestant = ctx.Contestants.FirstOrDefault(
                    c => c.Email.ToLower() == email.ToLower());
                if (contestant != null)
                    msg = $"Email address {email} is already in use.";
            }
            return msg ;
        }
    }
}
