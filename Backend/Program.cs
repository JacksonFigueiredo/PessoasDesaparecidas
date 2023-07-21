
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using PessoasDesaparecidas.Data;
using PessoasDesaparecidas.Helpers;
using PessoasDesaparecidas.Interfaces;
using PessoasDesaparecidas.Services;
using WebApplication1.Services;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            // Configuração do banco de dados em memória
            builder.Services.AddDbContext<DataContext>(options => options.UseInMemoryDatabase("Desaparecimentos"));

            // Injetando o serviço
            builder.Services.AddScoped<IPessoaService, PessoaService>();
            builder.Services.AddScoped<IDesaparecimentoService, DesaparecimentoService>();

            builder.Services.AddAutoMapper(typeof(MappingProfile));

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}