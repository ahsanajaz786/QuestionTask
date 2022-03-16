using QuestionTask.Domain.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuestionTask.Interface
{
    public interface IQuestion
    {
        public Task<Response<object>> Add(QuestionDTO questionDTO);
        Task<QuestionSubmittDTO> GetQuestion();
        Task<QuestionSubmittDTO> GetQuestionAnswer(int id);
        Task<bool> SaveQuestionResult(QuestionSubmittDTO questionSubmittDTO);
        Task<IEnumerable<UserDTO>> GetUsers(int page, int pageSize, string orderByColumn, string orderBy, string search);
        public Task<IEnumerable<QuestionDTO>> Get(int page, int pageSize, string orderByColumn, string orderBy, string search);
    }
}
