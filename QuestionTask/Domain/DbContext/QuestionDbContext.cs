using Microsoft.EntityFrameworkCore;
using QuestionTask.Domain.Model;

namespace QuestionTask.Domain.QuestionDbContext
{
    public class QuestionDbContext: DbContext
    {
        public QuestionDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Question> Question { get; set; }
        public DbSet<QuestionOption> QuestionOptions { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<QuestionAnswers> QuestionAnswers { get; set; }
    }
}
