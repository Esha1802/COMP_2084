using COMP_2084_Assigment_1.Data;
using COMP_2084_Assigment_1.Models.Landlord;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace COMP_2084_Assigment_1.Controllers
{
    public class LandlordController : Controller
    {
        private ApplicationDbContext datacontext;
        public LandlordController(ApplicationDbContext datacontext)
        {
            this.datacontext = datacontext;
        }
        public IActionResult Index()
        {
            // Fetch all landlord list and it will be displayed on main page
            var ladnlords = datacontext.Landlords.ToList();
            return View(ladnlords);
        }
        [Authorize]
        public IActionResult Edit(int landlordId)
        {
            //If landlord id is passed then we need to show old details so it will be fetched here
            var landlord = datacontext.Landlords.Where(x => x.Id == landlordId).FirstOrDefault();

            if (landlord == null)
                landlord = new Landlord();

            return View(landlord);
        }
        [Authorize]
        [HttpPost]
        public IActionResult Edit(Landlord landlord)
        {
            //When Id is zero it means it's in Add Mode
            if (landlord.Id == 0)
            {
                datacontext.Landlords.Add(landlord);
            }
            // If Id is not zero means it's in Edit Mode
            else
            {
                datacontext.Landlords.Update(landlord);
            }
            datacontext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
