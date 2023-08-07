using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StudentDetailsTechTest.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("university")]
        public string University { get; set; }

        [JsonProperty("major")]
        public string Major { get; set; }

        [JsonProperty("student_id")]
        public int StudentId { get; set; }

        [JsonProperty("grades")]
        public Grades Grades { get; set; }

        [JsonProperty("attendance")]
        public Attendance Attendance { get; set; }
    }
}
