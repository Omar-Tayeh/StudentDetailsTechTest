using Newtonsoft.Json;

namespace StudentDetailsTechTest.Models
{
    public class Subject
    {
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }
    }
}
