using Microsoft.AspNetCore.Mvc;
using QuestionTask.Interface;
using System.Threading.Tasks;

namespace QuestionTask.Components
{
    [ViewComponent(Name = "Questions")]
    public class QuestionsComponent : ViewComponent
    {
        private readonly IQuestion _question;
        public QuestionsComponent(IQuestion question)
        {
            _question = question;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await _question.GetQuestion();
            return View(data);
        }
    }
}
