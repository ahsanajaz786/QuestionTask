using Microsoft.AspNetCore.Mvc;
using QuestionTask.Domain.DTO;
using QuestionTask.Interface;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionTask.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IQuestion _question;
        public QuestionController(IQuestion question)
        {
            _question = question;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Add()
        {
            return View();
        }
        public async Task<IActionResult> ViewAnsers(int id)
        {
            return View(await _question.GetQuestionAnswer(id));
        }
        public async Task<IActionResult> RenderQuestionView()
        {
          
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddQuestion(QuestionDTO questionDTO)
        {
            return Ok(await _question.Add(questionDTO));
        }
        [HttpPost]
        public async Task<IActionResult> SaveQuestionResult(QuestionSubmittDTO questionSubmittDTO)
        {
           await _question.SaveQuestionResult(questionSubmittDTO);
            return RedirectToAction("users", "Home");
        }

        public async Task<IActionResult> Get()
        {

            var draw = Request.Query["draw"].FirstOrDefault() ?? "1";
            var start = Request.Query["start"].FirstOrDefault() ?? "1";
            var length = Request.Query["length"].FirstOrDefault() ?? "10";
            var sortColumn = Request.Query["columns[" + Request.Query["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDirection = Request.Query["order[0][dir]"].FirstOrDefault();
            var searchValue = Request.Query["search[value]"].FirstOrDefault();
            int pageSize = length != null ? Convert.ToInt32(length) : 0;
            int skip = start != null ? Convert.ToInt32(start) : 0;
            var res=await _question.Get(skip, pageSize, sortColumn, sortColumnDirection, searchValue);
            var jsonData = new { draw = draw, recordsFiltered = res.FirstOrDefault()?.Total ?? 0, recordsTotal = res.FirstOrDefault()?.Total ?? 0, data = res };

            return Ok(jsonData);
        }
        public async Task<IActionResult> GetUsers()
        {

            var draw = Request.Query["draw"].FirstOrDefault() ?? "1";
            var start = Request.Query["start"].FirstOrDefault() ?? "1";
            var length = Request.Query["length"].FirstOrDefault() ?? "10";
            var sortColumn = Request.Query["columns[" + Request.Query["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDirection = Request.Query["order[0][dir]"].FirstOrDefault();
            var searchValue = Request.Query["search[value]"].FirstOrDefault();
            int pageSize = length != null ? Convert.ToInt32(length) : 0;
            int skip = start != null ? Convert.ToInt32(start) : 0;
            var res = await _question.GetUsers(skip, pageSize, sortColumn, sortColumnDirection, searchValue);
            var jsonData = new { draw = draw, recordsFiltered = res.FirstOrDefault()?.Total ?? 0, recordsTotal = res.FirstOrDefault()?.Total ?? 0, data = res };

            return Ok(jsonData);
        }
    }
}
