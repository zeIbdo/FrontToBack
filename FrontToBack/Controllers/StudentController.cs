using FrontToBack.DataAccessLayer;
using FrontToBack.DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Controllers
{
    public class StudentController:Controller
    {
        private readonly AppDbContext _dbContext;
        public StudentController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var students = _dbContext.Students.Include(x=>x.TeacherStudents).ThenInclude(y=>y.Teacher).ToList();
            return View(students);
        }

    }
}
