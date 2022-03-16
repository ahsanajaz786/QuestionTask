using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using QuestionTask.Domain.DTO;
using QuestionTask.Domain.Model;
using QuestionTask.Domain.QuestionDbContext;
using QuestionTask.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Linq;

namespace QuestionTask.Services
{
    public class QuestionService : IQuestion
    {
        private readonly QuestionDbContext _questionDbContext;
       
       
        public IConfiguration _configuration { get; }


        public QuestionService(QuestionDbContext questionDbContext, IConfiguration configuration)
        {

            _questionDbContext = questionDbContext;
            _configuration=configuration;
        }
        public async Task<bool> SaveQuestionResult(QuestionSubmittDTO questionSubmittDTO)
        {
            bool status = false;

            var userInfo = new UserInfo()
            {
                Email=questionSubmittDTO.Email,
                FullName=questionSubmittDTO.FullName,

            };
            await _questionDbContext.UserInfos.AddAsync(userInfo);
            await _questionDbContext.SaveChangesAsync();
            foreach(var item in questionSubmittDTO.QuestionDTOs)
            {
                QuestionAnswers questionAswer;
                if (item.Type=="text")
                {
                     questionAswer = new QuestionAnswers()
                    {
                        TextAnswer=item.Answer,
                        FK_QuestionId=item.Id,
                        Fk_UserInfo=userInfo.Id

                    };
                    await _questionDbContext.QuestionAnswers.AddAsync(questionAswer);
                    await _questionDbContext.SaveChangesAsync();
                }
                else if(item.Type=="radio")
                {
                     questionAswer = new QuestionAnswers()
                    {
                        FkQuestionAnswer = int.Parse(item.Answer),
                        FK_QuestionId = item.Id,
                        Fk_UserInfo = userInfo.Id

                    };
                    await _questionDbContext.QuestionAnswers.AddAsync(questionAswer);
                    await _questionDbContext.SaveChangesAsync();

                }
                else
                {
                    var slected = item.QuestionOptions.Where(o => o.Checked).ToList();
                    foreach (var o in slected)
                    {
                         questionAswer = new QuestionAnswers()
                        {
                            FkQuestionAnswer = o.Id,
                            FK_QuestionId = item.Id,
                            Fk_UserInfo = userInfo.Id

                        };
                        await _questionDbContext.QuestionAnswers.AddAsync(questionAswer);
                        await _questionDbContext.SaveChangesAsync();
                    }
                }
               
            }
            return status;
        }
        public async Task<QuestionSubmittDTO> GetQuestion()
        {
            var QuestionSubmittDTO =new QuestionSubmittDTO();
            var questions = await _questionDbContext.Question.Select(p => new QuestionDTO()
            {

                Id=p.Id,
                Title=p.Title,
                Type=p.Type,
            }).ToListAsync();
            foreach(var item in questions)
            {
                if(item.Type !="text")
                {
                    var options = await _questionDbContext.QuestionOptions.Select(o=>new QuestionOptions
                    {
                        Id=o.Id,
                        Value=o.Value,
                        FKQuestionId=o.FKQuestionId
                    }).Where(o => o.FKQuestionId == item.Id).ToListAsync();
                    item.QuestionOptions = options;

                }
            }
            QuestionSubmittDTO.QuestionDTOs = questions;
            return QuestionSubmittDTO;


        }


            public async Task<Response<object>> Add(QuestionDTO questionDTO)
        { 
            try
            {
                var question = new Question()
                {
                    CreatedAt = DateTime.Now.ToString(),
                    Title = questionDTO.Title,
                    Type = questionDTO.Type
                };
                await _questionDbContext.Question.AddAsync(question);
                await _questionDbContext.SaveChangesAsync();

                foreach (var item in questionDTO.Options)
                {
                    var option = new QuestionOption()
                    {
                        FKQuestionId = question.Id,
                        Value = item
                    };

                    await _questionDbContext.QuestionOptions.AddAsync(option);
                    await _questionDbContext.SaveChangesAsync();
                   

                }
                return Response<object>.Success("Question Added");
            }
            catch(Exception l)
            {
                 return Response<object>.Failure(l.Message,ApiStatusCode.InternalServer);
            }
        }

        public async Task<IEnumerable<QuestionDTO>> Get(int page, int pageSize, string orderByColumn, string orderBy, string search) 
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@page", page);
            parameters.Add("@pageSize", pageSize);
            parameters.Add("@orderColumn", orderByColumn);
            parameters.Add("@orderBy", orderBy);
            parameters.Add("@search", search);
            using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            var res= await connection.QueryAsync<QuestionDTO>("GET_QUESTIONS", parameters, commandType: CommandType.StoredProcedure);
            return res;
            
        }
        public async Task<QuestionSubmittDTO> GetQuestionAnswer(int id)
        {
            var QuestionDTO =new List<QuestionDTO>();
            var response = new QuestionSubmittDTO();
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@id", id);
            using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            var res = await connection.QueryAsync<QuestionAnswerDTO>("GET_QUESTION_ANSWER", parameters, commandType: CommandType.StoredProcedure);
            var data= res.GroupBy(o => o.Title).ToList();
            response.FullName = res.FirstOrDefault().FullName;
            response.Email = res.FirstOrDefault().Email;
            
            foreach (var item in data)
            {
                var q = new QuestionDTO();
                q.Title = item.Key;
                q.Type = item.FirstOrDefault().Type;
                q.Answer = item.FirstOrDefault().TextAnswer;
                q.Options=item.Select(o=>o.Value).ToList();
                QuestionDTO.Add(q);



            }
            response.QuestionDTOs = QuestionDTO;
            return response;

        }
        public async Task<IEnumerable<UserDTO>> GetUsers(int page, int pageSize, string orderByColumn, string orderBy, string search)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@page", page);
            parameters.Add("@pageSize", pageSize);
            parameters.Add("@orderColumn", orderByColumn);
            parameters.Add("@orderBy", orderBy);
            parameters.Add("@search", search);
            using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            var res = await connection.QueryAsync<UserDTO>("GET_USERS", parameters, commandType: CommandType.StoredProcedure);
            return res;

        }
    }
}
