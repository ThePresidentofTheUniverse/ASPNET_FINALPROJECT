using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalProject_ABBOTT.Models;
using System.Diagnostics;
using FinalProject_ABBOTT.Migrations;

namespace FinalProject_ABBOTT.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContestantController : Controller
    {
        //AREA WHERE DATABASE CONTEXT IS CREATED

        private ContestantsContext context;
        public ContestantController(ContestantsContext ctx) => context = ctx;

        //AREA OF CODE FOR GRABBING INFORMATIONS

        //[Route("[controllers]s")] //Note to self: This did not work due to the admins stuff inprogram.cs
        public IActionResult ContestantList()
        {
            //Get the contestants from the database (VERY BASIC PLAN ON DOING MORE IF POSSIBLE).
            var contestants = context.Contestants.OrderBy(c => c.ContestantID).ToList();
            return View(contestants);
        }

        //Stuff that grabs the details
        [HttpGet]
        public IActionResult ContestantDetails(int id)
        {
            ViewBag.Divisions = context.Divisions.OrderBy(d => d.Name).ToList();
            ViewBag.Schools = context.Schools.OrderBy(s => s.SchoolName).ToList();
            var contestant = context.Contestants.Find(id);
            return View(contestant);
        }

        // AREA OF CODE FOR ADDING AND EDITING CONTESTANTS

        //sets page up to create a new contestant
        [HttpGet]
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

                return View("AddEditContestant", contestant);
            }
        }

        //AREA OF CODE FOR CHECKING IN AND OUT CONTESTANTS

        //The method used to update the status of the contestant
        public IActionResult CheckContestant(Contestant contestant)
        {

            //Need to figure out how to pass in the data.
            if (contestant.CheckInStatus!)
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
