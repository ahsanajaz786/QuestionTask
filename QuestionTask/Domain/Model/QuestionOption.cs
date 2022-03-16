using System.ComponentModel.DataAnnotations;

namespace QuestionTask.Domain.Model
{
    public class QuestionOption
    {
        [Key]
        public int Id { get; set; }
        public int FKQuestionId { get; set; }
        public string Value { get; set; }


    }
}
