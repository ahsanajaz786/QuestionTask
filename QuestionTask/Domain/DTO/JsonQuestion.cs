using System.Collections.Generic;

namespace QuestionTask.Domain.DTO
{
   
    public class JsonQuestion
    {
        public string Type { get; set; }
        public string Label { get; set; }
        public List<string> Options { get; set; }
    }
}
