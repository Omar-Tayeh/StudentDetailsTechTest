using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Text.Json;

namespace StudentDetailsTechTest.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Attendance
    { 
        public int Id { get; set; }

        [JsonProperty("subjects")]
        public List<Subject> Subjects { get; set; }
    }
}