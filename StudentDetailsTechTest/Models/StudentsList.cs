using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Text.Json;

namespace StudentDetailsTechTest.Models
{
    public class StudentsList
    {
        public int Id { get; set; }
        [JsonProperty("students")]
        public Student[] Students { get; set; }
    }
}
