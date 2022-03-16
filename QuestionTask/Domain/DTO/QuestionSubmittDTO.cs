using System.Collections.Generic;

namespace QuestionTask.Domain.DTO
{
    public class QuestionSubmittDTO
    {
        public QuestionSubmittDTO()
        {
            QuestionDTOs=new List<QuestionDTO>();
        }
        public string FullName { get; set; }
        public string Email { get; set; }
        public List<QuestionDTO> QuestionDTOs { get; set; }

    }
    public class UserDTO
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public int Total { get; set; }

    }
    public class QuestionAnswerDTO
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }
        public string TextAnswer { get; set; }
        public string Type { get; set; }

    }
}
