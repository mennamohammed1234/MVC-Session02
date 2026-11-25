using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using WebApplication2.Dbcontext;
using WebApplication2.Entites;
using WebApplication2.reposetaries.interfaces;
using Plane = WebApplication2.Entites.Plane;

namespace WebApplication2.Controllers
{
    public class PlaneController: Controller
    {
       private Iplan _planrepo;
        private IMembershiprepocs _membershiprepo;
      
        public PlaneController(Iplan planrepo,IMembershiprepocs membershiprepo)
        {
            _planrepo = planrepo;
            _membershiprepo = membershiprepo;
        }

        public async Task<IActionResult> Index(CancellationToken ct)
        {

            var plans= await _planrepo.GetPlanesAsync(ct);
            return View( plans);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id,CancellationToken ct)
        {
            var plan= await _planrepo.GetPlanebyidasync(id,ct);

            if(plan==null | plan.IsActive == false)
            {
                TempData["Erorr Message"] = "plan cant be Edited";
                return RedirectToAction("Index");
            }

            var membership=await _membershiprepo.inMembership(plan=>plan.Id==id & plan.EndDate>DateTime.Now,ct);

            if (membership)
            {
                TempData["Erorr Message"] = "plan has membership";
                return RedirectToAction("Index");
            }

           

            return View(plan);

        }
        [HttpPost]
        public async Task<IActionResult> Edit(Plane plane, CancellationToken ct)
        {
            if (!ModelState.IsValid) return View(plane);
            var plan = await _planrepo.GetPlanebyidasync(plane.Id, ct);
            if (plan == null | plan.IsActive == false)
            {
                TempData["Erorr Message"] = "plan cant be Edited";
                return RedirectToAction("Index");
            }

            var membership = await _membershiprepo.inMembership(plan => plan.Id == plan.Id & plan.EndDate > DateTime.Now, ct);

            if (membership)
            {
                TempData["Erorr Message"] = "plan has membership";
                return RedirectToAction("Index");
            }

            plan.DurationDays = plane.DurationDays;
            plan.Description = plane.Description;
            plan.Price = plane.Price;

            if(await _planrepo.UpdateasAsync(ct)==0)
            {
                TempData["Erorr Message"] = "plan cant be Edited";
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");

        }
    }
}
