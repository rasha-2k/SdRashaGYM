using Microsoft.AspNetCore.Mvc;
using SdRashaGYMV2.Data;
using SdRashaGYMV2.Models;

namespace SdRashaGYMV2.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _db;
        public UsersController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<User> objUsersList=_db.Users.ToList();
            return View(objUsersList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(User obj)
        {
            if (ModelState.IsValid)
            {
                _db.Users.Add(obj);
                _db.SaveChanges();
                TempData["Success"] = "User Added Successfully!";
                return RedirectToAction("Index");

            }
            return View();
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            User ? userformDb = _db.Users.Find(id);


            if (userformDb == null)
            {
                return NotFound();
            }
            return View(userformDb);
        }
        [HttpPost]
        public IActionResult Edit(User obj)
        {

            if (ModelState.IsValid)
            {
                _db.Users.Update(obj);
                _db.SaveChanges();
                TempData["Success"] = "User Updated Successfully!";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            User? userformDb = _db.Users.Find(id);
            //User ? userformDb1 = _db.Users.FirstOrDefault(u=>u.Id==id);
            //User ? userformDb2 = _db.Users.Where(u => u.Id == id).FirstOrDefault();

            if (userformDb == null)
            {
                return NotFound();
            }
            return View(userformDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            User? obj = _db.Users.Find(id);
                
            if (obj == null)
            {
                return NotFound();
            }
            _db.Users.Remove(obj);
            _db.SaveChanges();
            TempData["Success"] = "User Deleted Successfully!";
            return RedirectToAction("Index");
        }
    }
}
