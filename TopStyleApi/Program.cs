using Topsstyle.Core.Services.Implementations;
using Topsstyle.Core.Services.Interfaces;
using Topstyle.Data.Repos.Implementations;
using Topstyle.Data.Repos.Interfaces;
using TopStyleApi.Extensions;

namespace TopStyleApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            builder.Services.AddSwaggerExtended();
            builder.Services.AddContext();

            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IUserRepo, UserRepo>();


            var app = builder.Build();

            app.UseSwaggerExtended();
            app.UseRouting();
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
            
            app.Run();
        }
    }
}
