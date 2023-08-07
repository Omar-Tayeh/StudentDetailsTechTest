using StudentDetailsTechTest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using StudentDetailsTechTest.Data;
using Newtonsoft.Json;

namespace StudentDetailsTechTest.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentDbContext _context;

        public StudentController(StudentDbContext context)
        {
            _context = context;
        }

        [HttpPost("studentPost")]
        public IActionResult PostStudents()
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly
            .GetExecutingAssembly().Location)!, @"Data\Students\students.json");

            if (System.IO.File.Exists(path))
            {
                string fileString = System.IO.File.ReadAllText(path);
                var studentsList = JsonConvert.DeserializeObject<StudentsList>(fileString)!;

                if (studentsList != null)
                {
                    _context.Students.AddRange(studentsList.Students);
                    _context.SaveChanges();
                }

                return Ok(studentsList);
            }
            else
            {
                return Ok(new StudentsList { });
            }
        }

        [HttpGet("student/{id:int}")]
        public IActionResult GetStudentById(int id)
        {
            var student = _context.Students.Where(s => s.StudentId == id);
            if (student == null)
            {
                return BadRequest("No such student available");
            }
            return Ok(student);
        }

        [HttpGet("student/{searchName}")]
        public IActionResult GetStudentByName(string searchName)
        {
            var student = _context.Students.Where(s => s.Name.Contains(searchName));
            if (student == null)
            {
                return BadRequest("No such student available");
            }
            return Ok(student);
        }

        [HttpPut("student")]
        public IActionResult EditStudent([FromForm]Student student)
        {
            var studentToUpdate = _context.Students.Where(s => s.StudentId == student.StudentId).FirstOrDefault();
            if (studentToUpdate == null)
            {
                return BadRequest("No such student available");
            }
            _context.Students.Remove(studentToUpdate);

            studentToUpdate = student;

            _context.Students.Add(studentToUpdate);

            return Ok(studentToUpdate);
        }
    }
}
