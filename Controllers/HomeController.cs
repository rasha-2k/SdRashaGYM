using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SdRashaGYMV2.Data;
using SdRashaGYMV2.Models;
using SdRashaGYMV2.ViewModels;

namespace SdRashaGYMV2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        // Action to display the package list
        public IActionResult PackageList()
        {
            List<Package> objPackageList = _context.Packages.ToList(); 
            return View(objPackageList);
        }  
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult AddPackage()
        {
            return View(); 
        }


        [HttpPost]
        public IActionResult AddPackage(PackageViewModel obj)
        {
            string selectedDays = string.Join(",", obj.SelectedDays ?? new List<string>());

            Package package = new Package
            {
                PackageName = obj.PackageName,
                Duration = obj.Duration,
                Price = obj.Price,
                Days = selectedDays,
                Description = obj.Description
            };

            _context.Packages.Add(package);
            _context.SaveChanges();
            TempData["Success"] = "Package Added Successfully!";

            return RedirectToAction("PackageList","Home");
        }

        public IActionResult EditPackage(int id)
        {
            var package = _context.Packages.FirstOrDefault(p => p.Id == id);
            if (package == null)
            {
                return NotFound();
            }

            var model = new EditPackageViewModel
            {
                Id = package.Id,
                PackageName = package.PackageName,
                Duration = package.Duration,
                Price = package.Price,
                Days = package.Days,
                Description = package.Description
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult EditPackage(EditPackageViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var package = _context.Packages.FirstOrDefault(p => p.Id == model.Id);
            if (package == null)
            {
                return NotFound();
            }
            string selectedDays = string.Join(",", model.SelectedDays ?? new List<string>());

            package.PackageName = model.PackageName;
            package.Duration = model.Duration;
            package.Price = model.Price;
            package.Days = selectedDays;
            package.Description = model.Description;

            _context.Packages.Update(package);
            _context.SaveChanges();

            TempData["Success"] = "Package updated successfully!";
            return RedirectToAction("PackageList");
        }
        // GET: Confirm Delete Package
        public IActionResult DeletePackage(int id)
        {
            var package = _context.Packages.FirstOrDefault(p => p.Id == id);
            if (package == null)
            {
                return NotFound();
            }

            return View(package);

        }


        [HttpPost, ActionName("DeletePackage")]
        public IActionResult DeleteConfirmed(int id)
        {
            var package = _context.Packages.FirstOrDefault(p => p.Id == id);
            if (package == null)
            {
                return NotFound();
            }

            _context.Packages.Remove(package);
            _context.SaveChanges();

            TempData["Success"] = "Package deleted successfully!";
            return RedirectToAction("PackageList");

        }


    }
}
