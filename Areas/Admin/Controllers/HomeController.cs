using FinalProject_ABBOTT.Models;
using Microsoft.AspNetCore.Authorization; //to authorize
using Microsoft.AspNetCore.Mvc;

namespace FinalProject_ABBOTT.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        //AREA WHERE DATABASE CONTEXT IS CREATED
        private ContestantsContext context;
        public HomeController(ContestantsContext ctx) => context = ctx;


        //AREA FOR BOOTING UP THE INDEX PAGE
        [Route("administrator-home")]
        public IActionResult Index()
        {
            return View();
        }

        //AREA FOR BOOTING UP THE SUMMARY PAGE
        [Route("summary-page")]
        public IActionResult SummaryPage()
        {
            //Grabs the information from the database
            ContestantsViewModel model = new ContestantsViewModel()
            {
                Contestants = context.Contestants.ToList(),
                Divisions = context.Divisions.ToList(),
                Schools = context.Schools.ToList(),
            };

            //Code to get number of contestants at all events combined.
            ViewBag.ContestantsAMT = model.Contestants.Count;

            //Get the checked in and checked out contestants
            int checkedIn = 0;
            List<Contestant> checkedOut = new List<Contestant>();

            foreach (Contestant contestant in model.Contestants)
            {
                if(contestant.CheckInStatus == true)
                {
                    //Just need to know how many is checked in.
                    checkedIn++;
                }
                else
                {
                    //Adds contestant to checked out list.
                    checkedOut.Add(contestant);
                }
            }
            //Counts the number of contestants checked in.
            ViewBag.CheckedIn=checkedIn;
            //Counts the number of contestants not checked in.
            ViewBag.CheckedOutAMT = checkedOut.Count();
            //List of contestants not checked in.
            ViewBag.CheckedOutContestants = checkedOut.ToArray();

            //Get the contestants by divisions, organizing them.
            List<Contestant> contestants = model.Contestants.ToList();
            List<Division> divisions = model.Divisions.ToList();

            ViewBag.Divisions = divisions;
            ViewBag.Contestants = contestants;

            return View(model);
        }
    }
}
