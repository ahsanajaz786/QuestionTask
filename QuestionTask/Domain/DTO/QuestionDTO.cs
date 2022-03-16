using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace QuestionTask.Domain.DTO
{
    public class QuestionDTO
    {
        public QuestionDTO()
        {
            Options = new List<string>();
            QuestionOptions = new List<QuestionOptions>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string CreatedAt { get; set; }
        public List<string> Options { get; set; }
        public List<QuestionOptions> QuestionOptions { get; set; }
        public string Answer { get; set; }
        public int Total { get; set; }
    }
    public class QuestionOptions
    {
        public int Id { get; set; }
        public int FKQuestionId { get; set; }
        public string Value { get; set; }
        [BindProperty]
        public bool Checked { get; set; }
    }
}
