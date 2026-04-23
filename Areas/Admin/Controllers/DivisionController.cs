using FinalProject_ABBOTT.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject_ABBOTT.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DivisionController : Controller
    {
        //AREA WHERE DATABASE CONTEXT IS CREATED
        private ContestantsContext context;
        public DivisionController(ContestantsContext ctx) => context = ctx;

        public IActionResult DivisionList()
        {
            var divisions = context.Divisions.OrderBy(d => d.DivisionID).ToList();
            return View(divisions);
        }

        //AREA OF CODING FOR ADDING AND EDITING DIVISIONS

        //sets up page to create a new division
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("AddEditDivision", new Division());
        }

        //sets up page to edit a existing division
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var division = context.Divisions.Find(id);
            return View("AddEditDivision", division);
        }

        //Used to update or save the data of division
        [HttpPost]
        public IActionResult Save(Division division)
        {
            if (ModelState.IsValid)
            {
                string tempquery = string.Empty; //used to show temporary data

                if (division.DivisionID == 0)
                {
                    
                    //Add the new division
                    context.Divisions.Add(division);

                    tempquery = "added";
                }
                else
                {
                    //update the existing division
                    context.Divisions.Update(division);
                    tempquery = "modified";
                }
                context.SaveChanges();

                TempData["message"] = $"The {division.Name} division has been {tempquery}.";
                return RedirectToAction("DivisionList");
            }
            else
            {
                if (division.DivisionID == 0)
                {
                    ViewBag.Action = "Add";
                }
                else
                {
                    ViewBag.Action = "Edit";
                }
                return View("AddEditDivision", division);
            }
        }

        //AREA OF CODE FOR DELETING DIVISIONS

        //sets up information for deleting a division.
        [HttpGet]
        public IActionResult DeleteDivision(int id)
        {
            var division = context.Divisions.Find(id);
                TempData["message"] = $"The {division.Name} division has been deleted.";
            return View(division);
        }

        //The code used for deleting a division
        [HttpPost]
        public IActionResult DeleteDivision(Division division)
        {
                context.Divisions.Remove(division);
                context.SaveChanges();
                return RedirectToAction("DivisionList");
        }
    }
}
