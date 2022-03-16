using System.ComponentModel.DataAnnotations;

namespace QuestionTask.Domain.Model
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string CreatedAt { get; set; }
        


    }
}
