using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Text.Json;

namespace StudentDetailsTechTest.Models
{
    public class Grades
    {
        public int Id { get; set; }

        [JsonProperty("subjects")]
        public List<Subject> Subjects { get; set; }
    }
}
