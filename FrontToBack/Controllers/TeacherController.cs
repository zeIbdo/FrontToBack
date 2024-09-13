using FrontToBack.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Controllers
{
    public class TeacherController:Controller
    {
        private readonly AppDbContext _appDbContext;
        public TeacherController(AppDbContext dbContext)
        {
            _appDbContext = dbContext;
        }
        public IActionResult Index()
        {
            var teachers = _appDbContext.Teachers.Include(x=>x.TeacherStudents).ThenInclude(y=>y.Student).ToList();
            return View(teachers);
        }
    }
}
