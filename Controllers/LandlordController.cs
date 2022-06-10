using COMP_2084_Assigment_1.Data;
using COMP_2084_Assigment_1.Models.Landlord;
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
            return View();
        }
        public IActionResult Edit(int landlordId)
        {
            var landlord = datacontext.Landlords.Where(x => x.Id == landlordId).FirstOrDefault();
            if (landlord == null)
                landlord = new Landlord();
            return View(landlord);
        }
        [HttpPost]
        public IActionResult Edit(Landlord landlord)
        {
            if (landlord.Id == 0)
            {
                datacontext.Landlords.Add(landlord);
            }
            else
            {
                datacontext.Landlords.Update(landlord);
            }
            datacontext.SaveChanges();
            return View("Index");
        }
    }
}
