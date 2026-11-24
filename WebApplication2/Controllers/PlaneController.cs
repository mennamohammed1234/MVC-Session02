using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using WebApplication2.Dbcontext;
using WebApplication2.Entites;

namespace WebApplication2.Controllers
{
    public class PlaneController: Controller
    {
        private Gymcontxt gymcontxt=new Gymcontxt();
        public ViewResult Index()
        {

            var plans=gymcontxt.Set<Entites.Plane >().ToList();
            return View(plans);
        }

    }
}
