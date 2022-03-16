using Microsoft.Extensions.DependencyInjection;
using QuestionTask.Interface;
using QuestionTask.Services;

namespace QuestionTask.DInstaller
{
    public static class ServiceInstaller
    {
        public static void ServiceInstall(IServiceCollection services)
        {
            //DI
            services.AddScoped<IQuestion, QuestionService>();
        }
    }
}
