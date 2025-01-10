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
            var packages = _context.Packages.ToList(); // Retrieve all packages from the database
            return View(packages); // Pass the list to the view
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
            return View(new PackageViewModel()); 
        }


        [HttpPost]
        public IActionResult AddPackage(PackageViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
                foreach (var error in errors)
                {
                    Console.WriteLine(error); // Debug log
                }
                return View(model);
            }


            string selectedDays = string.Join(",", model.SelectedDays ?? new List<string>());

            Package package = new Package
            {
                PackageName = model.PackageName,
                Duration = model.Duration,
                Price = model.Price,
                Days = selectedDays,
                Description = model.Description
            };

            _context.Packages.Add(package);
            _context.SaveChanges();
            TempData["Success"] = "Package Added Successfully!";

            return RedirectToAction("PackageList", "Home");
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

            package.PackageName = model.PackageName;
            package.Duration = model.Duration;
            package.Price = model.Price;
            package.Days = model.Days;
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
