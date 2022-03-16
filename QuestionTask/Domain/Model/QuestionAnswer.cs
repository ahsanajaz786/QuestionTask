using System.ComponentModel.DataAnnotations;

namespace QuestionTask.Domain.Model
{
    public class UserInfo
    {
        [Key]
        public int Id { get; set; }

        public string FullName { get; set; }
        public string Email { get; set; }

    }
    public class QuestionAnswers
    {
        [Key]
        public int Id { get; set; }
        public int Fk_UserInfo { get; set; }
        public int FK_QuestionId { get; set; }
        public int FkQuestionAnswer { get; set; }
        public string TextAnswer { get; set; }

    }

}
