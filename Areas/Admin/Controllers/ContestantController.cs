using Microsoft.AspNetCore.Mvc;
using FinalProject_ABBOTT.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization; //to authorize

namespace FinalProject_ABBOTT.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ContestantController : Controller
    {
        //AREA WHERE DATABASE CONTEXT IS CREATED

        private ContestantsContext context;
        public ContestantController(ContestantsContext ctx) => context = ctx;

        //AREA OF CODE FOR GRABBING INFORMATIONS

        //[Route("[controllers]s")] //Note to self: This did not work due to the admins stuff inprogram.cs
        [Route("contestants")]
        public IActionResult ContestantList(string filter)
        {
            string sessionFilters = HttpContext.Session.GetString("filters");

            //Grabs the information from the database
            ContestantsViewModel model = new ContestantsViewModel()
            {
                Contestants = context.Contestants.ToList(),
                Divisions = context.Divisions.ToList(),
                Schools = context.Schools.ToList(),
                CheckedFilters = Filters.CheckedFilterValues,
                Filters = new Filters(filter)
            };

            if (filter != null)
            {
                HttpContext.Session.SetString("filters", filter);
            }

            //Get the list of contestants from the database based on the applied filters
            IQueryable<Contestant> query = context.Contestants
                .Include(c => c.Division).Include(c => c.School);

            //Check in / check out filter does not work for some reason.
            if (model.Filters.HasDivisionID)
            {
                query = query.Where(c => c.DivisionID == model.Filters.DivisionID);
            }
            if (model.Filters.HasSchoolID)
            {
                query = query.Where(c => c.SchoolID == model.Filters.SchoolID);
            }
            if (model.Filters.HasCheckedStatus)
            {
                if (model.Filters.IsTrue)
                {
                    query = query.Where(c => c.CheckInStatus == true);
                }
                else if (model.Filters.IsFalse)
                {
                    query = query.Where(c => c.CheckInStatus == false);
                }
            }

            //Throws together all of the filters at the very end.
            var contestants = query.OrderBy(c => c.ContestantID).ToList();
            model.Contestants = contestants;

            return View(model);
        }

        //Stuff that grabs the details
        [HttpGet]
        [Route("contestant-details/{id}")]
        public IActionResult ContestantDetails(int id)
        {
            ViewBag.Divisions = context.Divisions.OrderBy(d => d.Name).ToList();
            ViewBag.Schools = context.Schools.OrderBy(s => s.SchoolName).ToList();
            var contestant = context.Contestants.Find(id);
            return View(contestant);
        }

        //AREA OF CODE FOR USING FILTERS
        //Works with applying the filters
        [HttpPost]
        public IActionResult Filter(string[] filter)
        {
            string id = string.Join('|', filter);
            return RedirectToAction("ContestantList", new {filter = id});
        }

        // AREA OF CODE FOR ADDING AND EDITING CONTESTANTS

        //sets page up to create a new contestant
        [HttpGet]
        [Route("add-contestant")]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Date = DateTime.Now;
            ViewBag.Divisions = context.Divisions.OrderBy(d => d.Name).ToList();
            ViewBag.Schools = context.Schools.OrderBy( s => s.SchoolName).ToList();
            return View("AddEditContestant", new Contestant());
        }

        //sets page up to modify an existing contestant
        [HttpGet]
        [Route("edit-contestant/{id}")]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Divisions = context.Divisions.OrderBy(d => d.Name).ToList();
            ViewBag.Schools = context.Schools.OrderBy(s => s.SchoolName).ToList();
            var contestant = context.Contestants.Find(id);
            ViewBag.Date = contestant.RegistrationDate;
            return View("AddEditContestant", contestant);
        }

        //Used to update or save the data of contestant
        [HttpPost]
        public IActionResult Save(Contestant contestant)
        {

                if (TempData["okEmail"] == null)
                {
                    string msg = Check.EmailExists(context, contestant.Email);
                    if (!string.IsNullOrEmpty(msg))
                    {
                        ModelState.AddModelError(nameof(Contestant.Email), msg);
                    }
                }           
                if (ModelState.IsValid)
                {

                        string tempquery = string.Empty; //used to show temporary data

                        if (contestant.ContestantID == 0)
                        {
                            //Makes sure that the status is false.
                            contestant.CheckInStatus = false;
                            //Creates the initial registration date of the contestant
                            contestant.RegistrationDate = DateTime.Now;

                            context.Contestants.Add(contestant);

                            tempquery = "added";
                        }
                        else
                        {

                            context.Contestants.Update(contestant);
                            tempquery = "modified";
                        }
                        context.SaveChanges();

                        TempData["message"] = $"The contestant \"{contestant.FirstName} {contestant.LastName}\" has been {tempquery}."; //creates the temporary data to show what occurred.
                        return RedirectToAction("ContestantList");

                    
                }
                else
                {
                    ViewBag.Action = contestant.ContestantID == 0 ? "Add" : "Edit";

                    ViewBag.Divisions = context.Divisions
                        .OrderBy(d => d.Name)
                        .ToList();

                    ViewBag.Schools = context.Schools
                        .OrderBy(s => s.SchoolName)
                        .ToList();

                    ViewBag.Date = contestant.RegistrationDate;

                    return View("AddEditContestant", contestant);
                }

        }

        //AREA OF CODE FOR CHECKING IN AND OUT CONTESTANTS

        //The method used to update the status of the contestant
        public IActionResult CheckContestant(int id)
        {
            var contestant = context.Contestants.Find(id);

            //Need to figure out how to pass in the data.
            if (contestant.CheckInStatus != true)
            {
                contestant.CheckInStatus = true;
            }
            else
            {
                contestant.CheckInStatus = false;
            }
            Debug.WriteLine(contestant.ContestantID + " " + contestant.FirstName + " " + contestant.LastName + " " + contestant.Email + " " + contestant.SchoolID + " " + contestant.School + " " + contestant.DivisionID + " " + contestant.Division + " " + contestant.CheckInStatus + " " + contestant.RegistrationDate);
            context.Contestants.Update(contestant);
            context.SaveChanges();
            return RedirectToAction("ContestantList");
        }


        //AREA OF CODE FOR DELETING CONTESTANTS

        //Sets up information for deleting a contestant.
        [HttpGet]
        [Route("Delete-Contestant/{id}")]
        public IActionResult DeleteContestant(int id)
        {
            var contestant =context.Contestants.Find(id);
            TempData["message"] = $"The contestant \"{contestant.FirstName} {contestant.LastName}\" has been deleted.";
            return View(contestant);
        }

        //The code used for deleting the contestant.
        [HttpPost]
        public IActionResult DeleteContestant(Contestant contestant)
        {
            context.Contestants.Remove(contestant);
            context.SaveChanges();
            return RedirectToAction("ContestantList");
        }
    }
}
